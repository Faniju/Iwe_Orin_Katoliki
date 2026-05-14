using System;
using System.Collections.ObjectModel;
using YorubaCatholicHymn.Models;

namespace YorubaCatholicHymn.Data
{
    public static class FavoritesData
    {
        public static ObservableCollection<Hymn> Favorites { get; } = new ObservableCollection<Hymn>();

        // Event raised whenever favorites change
        public static event Action FavoritesChanged;

        public static void Add(Hymn hymn)
        {
            if (!Favorites.Contains(hymn))
            {
                Favorites.Add(hymn);
                FavoritesChanged?.Invoke();
            }
        }

        public static void Remove(Hymn hymn)
        {
            if (Favorites.Contains(hymn))
            {
                Favorites.Remove(hymn);
                FavoritesChanged?.Invoke();
            }
        }

        public static void Clear()
        {
            Favorites.Clear();
            FavoritesChanged?.Invoke();
        }
    }
}
