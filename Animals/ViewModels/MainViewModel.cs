namespace Animals.ViewModels;

public partial class MainViewModel : Animal
{
    private readonly IAnimalService _animalService;

    public ObservableCollection<AnimalType> AnimalsTypes { get; set; }

    public ICommand AddAnimalCommand => new RelayCommand(AddAnimal);

    public MainViewModel(IAnimalService animalService)
    {
        _animalService = animalService;
        AnimalsTypes = new ObservableCollection<AnimalType>(Enum.GetValues(typeof(AnimalType)).Cast<AnimalType>());
    }

    private void AddAnimal()
    {
        if (!string.IsNullOrWhiteSpace(Species) && !string.IsNullOrWhiteSpace(ImageUrl) && !string.IsNullOrWhiteSpace(Description))
        {
            _animalService.AddAnimal(this);

            // Beviteli mezők törlése
            Species = string.Empty;
            ImageUrl = string.Empty;
            Description = string.Empty;
        }
    }
}
