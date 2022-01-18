// See https://aka.ms/new-console-template for more information
class program
{

    static void Main(string[] args)

    {
        string randomFood, randomDrink, RandomMovie;
        randomFood = GetRandomFromFile("foods.txt");
        randomDrink = GetRandomFromFile("drinks.txt");
        RandomMovie = GetRandomFromFile("movies.txt");
        Console.WriteLine($"Tonight you will have some {randomFood}, with {randomDrink}, and watch {RandomMovie}");

          }



    private static int GenerateRandomIndex(string[] someArray) 
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, someArray.Length);

        return randomIndex;
    }
    
    private static string GetRandomFromFile(string Filename)
    {
        string filepath = $@"C:\Users\marti\samples\{Filename}";
        string[] dataFromFile= File.ReadAllLines(filepath);
        string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];
        return randomElement;
    }
    }
