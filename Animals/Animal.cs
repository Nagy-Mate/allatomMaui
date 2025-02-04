namespace Animals;

public partial class Animal: ObservableObject
{
    public int Id { get; set; }
    
    [ObservableProperty]
    private string species;

    [ObservableProperty]
    private AnimalType type;

    [ObservableProperty]
    private string imageUrl;

    [ObservableProperty]
    private string description;
}
