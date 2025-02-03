namespace Animals;

public class AnimalService : IAnimalService
{
    private List<Animal> animals = new List<Animal>
    {
        new Animal {
            Id = 1,
            Type = AnimalType.Cat,
            Species = "Perzsa macska",
            ImageUrl = "https://th.bing.com/th/id/OIP.ndyfVdc8U7MM_G02pQ4aKgHaHa?rs=1&pid=ImgDetMain",
            Description = "Ez egy perzsa macska leírás"
        },
        new Animal {
            Id = 2,
            Type = AnimalType.Cat,
            Species = "Sziámi macska",
            ImageUrl = "https://www.zooplus.hu/magazin/wp-content/uploads/2017/03/siamkatze-1024x680.jpg",
            Description = "Ez egy sziámi macska leírás"
        },
        new Animal {
            Id = 3,
            Type = AnimalType.Cat,
            Species = "Brit rövidszőrű",
            ImageUrl = "https://www.zooplus.hu/magazin/wp-content/uploads/2017/03/britisch-kurzhaar-gelb-augen.jpg",
            Description = "Ez egy Brit macska leírás"
        },
        new Animal {
            Id = 4,
            Type = AnimalType.Dog,
            Species = "Afgán agár",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/f/fe/Afghan_Hound.jpg",
            Description = "Ez egy Afgán kutya leírás"
        },
        new Animal {
            Id = 5,
            Type = AnimalType.Dog,
            Species = "Amerikai buldog",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/5e/American_Bulldog_600.jpg",
            Description = "Ez egy Amerikai kutya leírás"
        },
        new Animal {
            Id = 6,
            Type = AnimalType.Dog,
            Species = "Basenji",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/59/Basenji_600.jpg",
            Description = "Ez egy Basenji kutya leírás"
        },
        new Animal {
            Id = 7,
            Type = AnimalType.Fish,
            Species = "Szibériai tok",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e9/Siberian_sturgeon.jpg/1280px-Siberian_sturgeon.jpg",
            Description = "Ez egy szibériai tokhal leírás"
        },
        new Animal {
            Id = 8,
            Type = AnimalType.Fish,
            Species = "Ponty",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/a8/Common_carp.jpg",
            Description = "Ez egy ponty leírás"
        },
        new Animal {
            Id = 9,
            Type = AnimalType.Fish,
            Species = "Harcsa",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/44/EuropeseMeervalLucasVanDerGeest.jpg",
            Description = "Ez egy harcsa leírás"
        },
    };

    public void AddAnimal(Animal newAnimal)
    {

        newAnimal.Id = animals.Any() ? animals.Max(a => a.Id) + 1 : 1;
        animals.Add(newAnimal);
    }
    public List<Animal> GetAllAnimals()
    {
        return animals;
    }
    public IEnumerable<Animal> GetSpeciesForType(AnimalType type)
    {
        return animals.Where(a => a.Type == type);
    }

    public Animal GetAnimalById(int id)
    {
        return animals.Single(a => a.Id == id);
    }
}
