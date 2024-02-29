using Circustrein_algoritme;
using System.Runtime.CompilerServices;

Main main = new Main();

class Main 
{
    List<Animals> animals;
    Train train = new Train();
    public Main() 
    { 
        animals = new List<Animals>();

        GetAnimals();
        PrintAnimals();
        AddAnimalsToTrain();
        train.printTrain();
    }

    private void AddAnimalsToTrain()
    {
        foreach (Animals animal in animals)
        {
            train.AddToCart(animal);
        }
    }

    private void AddAnimals(int size, bool carnivore, int count)
    {
        for (int i = 0; i < count; i++)
        {
            animals.Add(new Animals(size, carnivore));
        }
    }

    private void PrintAnimals()
    {
        foreach (Animals animal in animals)
        {
            Console.WriteLine(animal.size.ToString() + " " + animal.carnivore.ToString());
        }
    }

    private void GetAnimals() 
    {
        int count = 0;
        Console.WriteLine("Carnivore amount");
        Console.WriteLine("Big:");
        count = Convert.ToInt32(Console.ReadLine());
        AddAnimals(5, true, count);
        Console.WriteLine("Medium:");
        count = Convert.ToInt32(Console.ReadLine());
        AddAnimals(3, true, count);
        Console.WriteLine("Small:");
        count = Convert.ToInt32(Console.ReadLine());
        AddAnimals(1, true, count);

        Console.WriteLine("Herbivore amount");
        Console.WriteLine("Big:");
        count = Convert.ToInt32(Console.ReadLine());
        AddAnimals(5, false, count);
        Console.WriteLine("Medium:");
        count = Convert.ToInt32(Console.ReadLine());
        AddAnimals(3, false, count);
        Console.WriteLine("Small:");
        count = Convert.ToInt32(Console.ReadLine());
        AddAnimals(1, false, count);
        }


 }