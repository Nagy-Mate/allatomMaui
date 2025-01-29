
namespace Animals
{
    public interface IAnimalService
    {
        Animal GetAnimalById(int id);
        IEnumerable<Animal> GetSpeciesForType(AnimalType type);
    }
}