namespace MethodsExercise
{
    public class Program
    {
        public static void littleIntro()
        {
            Console.WriteLine("Hello, what is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}! WHat's your favorite color?");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("What's your favorite animal?");
            string favoriteAnimal = Console.ReadLine();
            Console.WriteLine("What's your favorite band?");
            string favoriteBand = Console.ReadLine();
            
            Console.WriteLine($"{userName} adores {favoriteAnimal} especially {favoriteColor} " +
                              $"colored ones. {userName}'s favorite hobby is to listen to their " +
                              $"favorite band {favoriteBand}.");
        }

        
        static void Main(string[] args)
        {
            littleIntro();
            
            
        }
        
    }
}
