// See https://aka.ms/new-console-template for more information
class program
{
    static void Main(string[] args)
    {
        DisplayRandomFood();
        displayRandomDrink();
        displayRandomMovie();
    }

        private static int GernerateRandomIndex(string[] someArray)
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, someArray.Length);

        return randomIndex; 
    }

    
       
    private static void DisplayRandomFood()
    {
        string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
        Console.WriteLine($"computer picked: {foods[GernerateRandomIndex(foods)]}");
    }  
    private static void displayRandomDrink()
    {
        string[] drinks = { "beer", "coca cola", "jack daniels", "wine", "vodka" };
        Console.WriteLine($"computer picked: {drinks[GernerateRandomIndex(drinks)]}");
    }
    private static void displayRandomMovie()
    {
        string[] movies = { "Avengers", "Titanic", "South Park", "Breaking Bad", "Kill Bill" };
        Console.WriteLine($"computer picked: {movies[GernerateRandomIndex(movies)]}");

    }



}

