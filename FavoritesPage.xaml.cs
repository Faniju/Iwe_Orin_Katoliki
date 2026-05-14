using Microsoft.Maui.Controls;
using YorubaCatholicHymn.ViewModels;

namespace YorubaCatholicHymn
{
    public partial class FavoritesPage : ContentPage
    {
        public FavoritesPage()
        {
            InitializeComponent();
            BindingContext = new FavoritesPageViewModel();
        }
    }
}
