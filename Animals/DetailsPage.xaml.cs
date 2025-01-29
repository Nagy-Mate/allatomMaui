
namespace Animals;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(Animal selectedAnimal)
	{
		InitializeComponent();
        AnimalImage.Source = selectedAnimal.ImageUrl;
        SpeciesLabel.Text = selectedAnimal.Species;
        DescriptionLabel.Text = selectedAnimal.Description;
    }

}