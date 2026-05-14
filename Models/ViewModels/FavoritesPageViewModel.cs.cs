using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using YorubaCatholicHymn.Models;
using YorubaCatholicHymn.Data;

namespace YorubaCatholicHymn.ViewModels
{
    public class FavoritesPageViewModel : BindableObject
    {
        public ObservableCollection<Hymn> Favorites => FavoritesData.Favorites;

        public ICommand RemoveFavoriteCommand { get; }
        public ICommand ClearAllFavoritesCommand { get; }
        public ICommand OpenHymnDetailCommand { get; }

        public FavoritesPageViewModel()
        {
            RemoveFavoriteCommand = new Command<Hymn>(RemoveFavorite);
            ClearAllFavoritesCommand = new Command(ClearAllFavorites);
            OpenHymnDetailCommand = new Command<Hymn>(OpenHymnDetail);

            // Subscribe to favorites change event so UI updates automatically
            FavoritesData.FavoritesChanged += () =>
            {
                OnPropertyChanged(nameof(Favorites));
            };
        }

        private void RemoveFavorite(Hymn hymn)
        {
            if (hymn != null)
            {
                FavoritesData.Remove(hymn);
                Application.Current.MainPage.DisplayAlertAsync("Favorites", $"{hymn.Title} removed from favorites!", "OK");
            }
        }

        private void ClearAllFavorites()
        {
            if (FavoritesData.Favorites.Count > 0)
            {
                FavoritesData.Clear();
                Application.Current.MainPage.DisplayAlertAsync("Favorites", "All favorites cleared!", "OK");
            }
        }
        private async void OpenHymnDetail(Hymn hymn)
        {
            if (hymn != null)
                await Shell.Current.GoToAsync($"{nameof(HymnDetailPage)}?number={hymn.Number}");
        }
    }
}
