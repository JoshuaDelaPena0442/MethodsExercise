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

        public static int Add(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        public static int Multiply(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }

        public static int Divide(int numberOne, int numberTwo)
        {
            return numberOne / numberTwo;
        }


        public static int Subtract(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }
        static void Main(string[] args)
        {
            //littleIntro();
            Console.WriteLine(Add(numberOne:5, numberTwo:5));
            Console.WriteLine(Multiply(numberOne:5, numberTwo:4));
            Console.WriteLine(Divide(numberOne:10, numberTwo:5));
            Console.WriteLine(Subtract(numberOne:20, numberTwo:20));
            
        }
        
    }
}
