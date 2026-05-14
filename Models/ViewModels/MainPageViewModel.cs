using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using YorubaCatholicHymn.Models;
using YorubaCatholicHymn.Data;

namespace YorubaCatholicHymn.ViewModels
{
    public class MainPageViewModel : BindableObject
    {
        private ObservableCollection<Hymn> allHymns;
        private ObservableCollection<Hymn> filteredHymns;

        public ObservableCollection<string> Categories { get; }
        public ObservableCollection<Hymn> FilteredHymns
        {
            get => filteredHymns;
            set { filteredHymns = value; OnPropertyChanged(); }
        }

        public string FavoriteIcon => "fav.png";
        private int favoritesCount;
        public int FavoritesCount
        {
            get => favoritesCount;
            set { favoritesCount = value; OnPropertyChanged(); }
        }

        public ICommand OpenFavoritesCommand { get; }
        public ICommand ClearAllFavoritesCommand { get; }
        public ICommand HymnTappedCommand { get; }

        public MainPageViewModel()
        {
            allHymns = new ObservableCollection<Hymn>(HymnData.Hymns);
            FilteredHymns = new ObservableCollection<Hymn>(allHymns);

            var categories = HymnData.AllCategories.ToList();
            // Insert a catch-all category at the top
            categories.Insert(0, "ALL");
            Categories = new ObservableCollection<string>(categories);

            OpenFavoritesCommand = new Command(OpenFavorites);
            ClearAllFavoritesCommand = new Command(ClearAllFavorites);
            HymnTappedCommand = new Command<Hymn>(OpenHymnDetail);

            // Subscribe to favorites changes
            FavoritesData.FavoritesChanged += UpdateFavoritesCount;
            UpdateFavoritesCount();
        }

        public void FilterHymns(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                FilteredHymns = new ObservableCollection<Hymn>(allHymns);
            }
            else
            {
                var lower = searchText.ToLower();
                FilteredHymns = new ObservableCollection<Hymn>(
                    allHymns.Where(h => h.Number.Contains(lower) || h.Title.ToLower().Contains(lower))
                );
            }
        }

        public void FilterByCategory(string category)
        {
            if (string.IsNullOrWhiteSpace(category) || string.Equals(category, "ALL", System.StringComparison.OrdinalIgnoreCase))
            {
                FilteredHymns = new ObservableCollection<Hymn>(allHymns);
                return;
            }

            FilteredHymns = new ObservableCollection<Hymn>(
                allHymns.Where(h => h.Category == category)
            );
        }

        private async void OpenFavorites()
        {
            await Shell.Current.GoToAsync(nameof(FavoritesPage));
        }

        private void ClearAllFavorites()
        {
            FavoritesData.Clear();
        }

        private async void OpenHymnDetail(Hymn hymn)
        {
            if (hymn != null)
                await Shell.Current.GoToAsync($"{nameof(HymnDetailPage)}?number={hymn.Number}");
        }

        private void UpdateFavoritesCount()
        {
            FavoritesCount = FavoritesData.Favorites.Count;
        }
    }
}
