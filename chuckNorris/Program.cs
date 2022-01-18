// See https://aka.ms/new-console-template for more information
class program
{
    static void Main(string[] args)
    

        {
            string chuckNorris, randomDrink, RandomMovie;
            chuckNorris = GetRandomFromFile("chuck.txt");
            Console.WriteLine($"{chuckNorris}");

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
            string[] dataFromFile = File.ReadAllLines(filepath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];
            return randomElement;
        }
    
}