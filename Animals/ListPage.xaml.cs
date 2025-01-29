namespace Animals;

public partial class ListPage : ContentPage
{
    private readonly IAnimalService _animalService;

    public ListPage(IAnimalService animalService)
    {
        InitializeComponent();
        _animalService = animalService;

        var currentRoute = Shell.Current.CurrentState.Location.ToString();
        IEnumerable<Animal> animals = new List<Animal>();

        switch (currentRoute)
        {
            case "//CatPage":
                animals = _animalService.GetSpeciesForType(AnimalType.Cat);
                break;
            case "//DogPage":
                animals = _animalService.GetSpeciesForType(AnimalType.Dog);
                break;
            case "//FishPage":
                animals = _animalService.GetSpeciesForType(AnimalType.Fish);
                break;
            default:
                break;
        }

        AnimalsListView.ItemsSource = animals;
    }


    private async void OnAnimalSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            var selectedAnimal = (Animal)e.SelectedItem;
            await Navigation.PushAsync(new DetailsPage(selectedAnimal));
            ((ListView)sender).SelectedItem = null;
        }
    }
}