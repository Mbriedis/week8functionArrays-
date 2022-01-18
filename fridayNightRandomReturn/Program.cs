// See https://aka.ms/new-console-template for more information
class program
{
    static void Main(string[] args)
    {
        string randomFood, randomDrink, RandomMovie;
        string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
        string[] drinks = { "beer", "coca cola", "jack daniels", "wine", "vodka" };
        string[] movies = { "Avengers", "Titanic", "South Park", "Breaking Bad", "Kill Bill" };
        randomFood = PickRandomElementFromArray(foods);
        randomDrink=PickRandomElementFromArray(drinks);
        RandomMovie = PickRandomElementFromArray(movies);

        Console.WriteLine($"Tonight you will have some {randomFood}, with {randomDrink}, and watch {RandomMovie}");

    }

    private static int GernerateRandomIndex(string[] someArray)
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, someArray.Length);

        return randomIndex;
    }
    private static string PickRandomElementFromArray(string[] somearray)
    {
        string randomElement = somearray[GernerateRandomIndex(somearray)];
        return randomElement;
    }




}

