using AnimailRescue;
public class App
{

    public static void Main(string[] args)
    {
        //Animal animal = new Animal("Boby", 3, 8, 4, 9, "chicken", "ball");
        Adopter adopter = new Adopter("Andrei", 130);
        AnimalFood food = new AnimalFood("Pedigree", 20, 30, new DateOnly(2023, 12, 03), 20);
        Activity activity = new Activity("run");
        Veterinarian veterinarian = new Veterinarian("Bob", "dogs");
        //Game game = new Game(adopter, animal, veterinarian);

        //animal.SetName("rex");
        //Console.WriteLine(animal.toString());

        Console.WriteLine(adopter.toString());

        Console.WriteLine(food.toString());

        Console.WriteLine(activity.toString());

        Console.WriteLine(veterinarian.toString());

        //Console.WriteLine(game.toString());
        Console.WriteLine();
        Dog dog = new Dog("Boby", 3, 8, 4, 9, "chicken", "ball", "Madalina");
        dog.SetFavoriteActivity("run");
        Console.WriteLine(dog.toString());
        Console.WriteLine(dog.speak());

        Console.WriteLine();
        Cat cat = new Cat("Kitty", 3, 8, 4, 9, "chicken", "ball", "Sam");
        cat.SetFavoriteFood("fish");
        Console.WriteLine(cat.toString());
        Console.WriteLine(cat.speak());

        Animal cat2= new Cat("cat", 3, 8, 4, 9, "chicken", "ball", "Sam");
        Console.WriteLine(cat2.toString());
        Console.WriteLine(cat2.speak());


    }
}
