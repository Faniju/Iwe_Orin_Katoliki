namespace YorubaCatholicHymn
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {

            InitializeComponent();
            // Register routes for navigation
            Routing.RegisterRoute(nameof(FavoritesPage), typeof(FavoritesPage));
            Routing.RegisterRoute(nameof(HymnDetailPage), typeof(HymnDetailPage));
            Routing.RegisterRoute(nameof(OrderOfMassPage), typeof(OrderOfMassPage));

        }
    }
}
