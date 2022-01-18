// See https://aka.ms/new-console-template for more information
class program
{ static void Main(string[] args)
    {
        DisplayRandomFood();
        displayRandomDrink();
        displayRandomMovie();
    }
        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);
            string randomfood = foods[randomIndex];
            Console.WriteLine($"computer picked: {randomfood}");
        }
    private static void displayRandomDrink()
    {
        string[] drinks = { "beer", "coca cola", "jack daniels", "wine", "vodka" };
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, drinks.Length);
        string randomDrinks = drinks[randomIndex];
        Console.WriteLine($"computer picked: {randomDrinks}");
    }
    private static void displayRandomMovie()
    {
        string[] movies = { "Avengers", "Titanic", "South Park", "Breaking Bad", "Kill Bill" };
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, movies.Length);
        string randomMovies = movies[randomIndex];
        Console.WriteLine($"computer picked: {randomMovies}");

    }



    }
