using Microsoft.Maui.Controls;
using YorubaCatholicHymn.ViewModels;

namespace YorubaCatholicHymn
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            viewModel = new MainPageViewModel();
            BindingContext = viewModel;
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            viewModel.FilterHymns(e.NewTextValue);
        }

        private void OnCategorySelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is string category)
            {
                viewModel.FilterByCategory(category);
            }
        }
    }
}