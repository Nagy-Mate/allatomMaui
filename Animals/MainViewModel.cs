using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Animals;
public partial class MainViewModel : ObservableObject
{
    private readonly IAnimalService _animalService;
    public MainViewModel() { }
    public ObservableCollection<Animal> Animals { get; set; }

    [ObservableProperty]
    private string species;

    [ObservableProperty]
    private AnimalType selectedType;

    [ObservableProperty]
    private string imageUrl;

    [ObservableProperty]
    private string description;

    public ICommand AddAnimalCommand { get; }

    public MainViewModel(IAnimalService animalService)
    {
        _animalService = animalService;
        Animals = new ObservableCollection<Animal>(_animalService.GetAllAnimals());
        AddAnimalCommand = new RelayCommand(AddAnimal);
    }

    private void AddAnimal()
    {
        if (!string.IsNullOrWhiteSpace(Species) && !string.IsNullOrWhiteSpace(ImageUrl) && !string.IsNullOrWhiteSpace(Description))
        {
            var newAnimal = new Animal
            {
                Type = SelectedType,
                Species = Species,
                ImageUrl = ImageUrl,
                Description = Description
            };

            _animalService.AddAnimal(newAnimal);
            Animals.Add(newAnimal);

            // Beviteli mezők törlése
            Species = string.Empty;
            ImageUrl = string.Empty;
            Description = string.Empty;
        }
    }
}
