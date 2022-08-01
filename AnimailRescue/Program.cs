using AnimailRescue;
public class App
{

    public static void Main(string[] args)
    {
        Animal animal = new Animal("Boby", 3, 8, 4, 9, "chicken", "ball");
        Adopter adopter = new Adopter("Andrei", 130);
        AnimalFood food = new AnimalFood("Pedigree", 20, 30, new DateOnly(2023, 12, 03), 20);
        Activity activity = new Activity("run");
        Veterinarian veterinarian = new Veterinarian("Bob", "dogs");
        Game game = new Game(adopter, animal, veterinarian);

    }
}
