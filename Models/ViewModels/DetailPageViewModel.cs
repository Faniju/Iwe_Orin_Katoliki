using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using YorubaCatholicHymn.Models;
using YorubaCatholicHymn.Data;

namespace YorubaCatholicHymn.ViewModels
{
    public class DetailPageViewModel : BindableObject
    {
        private readonly Hymn hymn;

        public string PageTitle => $"{hymn.Number}. {hymn.Title}";
        public string Title => hymn.Title;
        public string Number => hymn.Number;
        public string Author => hymn.Author;
        public string Snippet => hymn.Snippet;

        public List<string> ChorusLines { get; }
        public string FirstChorusLine => ChorusLines != null && ChorusLines.Count > 0 ? ChorusLines[0] : string.Empty;
        public List<string> RemainingChorusLines => ChorusLines != null && ChorusLines.Count > 1 ? ChorusLines.Skip(1).ToList() : new List<string>();
        public bool HasChorus => ChorusLines != null && ChorusLines.Count > 0;

        public List<VerseViewModel> Verses { get; }

        public bool IsFavorite => FavoritesData.Favorites.Contains(hymn);
        public string FavoriteButtonText => IsFavorite ? "Remove from Favorites" : "Add to Favorites";

        public ICommand ToggleFavoriteCommand { get; }

        public DetailPageViewModel(Hymn hymn)
        {
            this.hymn = hymn;
            ChorusLines = hymn.Chorus ?? new List<string>();
            Verses = hymn.Verses?.Select(v => new VerseViewModel
            {
                Number = v.Number,
                Lines = v.Lines,
                FirstLine = v.Lines?.FirstOrDefault(),
                RemainingLines = v.Lines?.Skip(1).ToList() ?? new List<string>()
            }).ToList() ?? new List<VerseViewModel>();

            ToggleFavoriteCommand = new Command(ToggleFavorite);

            // Subscribe to favorites changes so button text updates
            FavoritesData.FavoritesChanged += () =>
            {
                OnPropertyChanged(nameof(IsFavorite));
                OnPropertyChanged(nameof(FavoriteButtonText));
            };
        }

        public void ToggleFavorite()
        {
            if (FavoritesData.Favorites.Contains(hymn))
                FavoritesData.Remove(hymn);
            else
                FavoritesData.Add(hymn);
        }
    }

    public class VerseViewModel
    {
        public string Number { get; set; }
        public List<string> Lines { get; set; }
        public string FirstLine { get; set; }
        public List<string> RemainingLines { get; set; }
    }
}
