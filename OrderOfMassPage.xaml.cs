using Microsoft.Maui.Controls;
using YorubaCatholicHymn.ViewModels;

namespace YorubaCatholicHymn
{
    public partial class OrderOfMassPage : ContentPage
    {
        private OrderOfMassViewModel vm;

        public OrderOfMassPage()
        {
            InitializeComponent();
            vm = new OrderOfMassViewModel();
            BindingContext = vm;

            // Animate when confession visibility changes
            vm.PropertyChanged += async (s, e) =>
            {
                if (e.PropertyName == nameof(vm.IsConfession1Visible) && vm.IsConfession1Visible)
                {
                    await Confession2Block.FadeToAsync(0, 200);
                    await Confession3Block.FadeToAsync(0, 200);
                    Confession1Block.Opacity = 0;
                    Confession1Block.IsVisible = true;
                    await Confession1Block.FadeToAsync(1, 250);
                }
                else if (e.PropertyName == nameof(vm.IsConfession2Visible) && vm.IsConfession2Visible)
                {
                    await Confession1Block.FadeToAsync(0, 200);
                    await Confession3Block.FadeToAsync(0, 200);
                    Confession2Block.Opacity = 0;
                    Confession2Block.IsVisible = true;
                    await Confession2Block.FadeToAsync(1, 250);
                }
                else if (e.PropertyName == nameof(vm.IsConfession3Visible) && vm.IsConfession3Visible)
                {
                    await Confession1Block.FadeToAsync(0, 200);
                    await Confession2Block.FadeToAsync(0, 200);
                    Confession3Block.Opacity = 0;
                    Confession3Block.IsVisible = true;
                    await Confession3Block.FadeToAsync(1, 250);
                }
            };
        }
    }
}
