namespace Animals
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Routing.RegisterRoute("CatPage", typeof(ListPage));
            Routing.RegisterRoute("DogPage", typeof(ListPage));
            Routing.RegisterRoute("FishPage", typeof(ListPage));
            Routing.RegisterRoute("DetailsPage", typeof(DetailsPage));
            InitializeComponent();
        }
    }
}
