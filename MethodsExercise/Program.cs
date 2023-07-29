namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("What is the name of your dog?");
            string userDogName = Console.ReadLine();

            Console.WriteLine("What color is your dog?");
            string userDogColor = Console.ReadLine();

            Console.WriteLine($"There was a man name {userName}, he was {age} years old.");
            Console.WriteLine($"He had a {userDogColor} dog named {userDogName}.");
            Console.WriteLine($"{userName} loved {userDogName}, but didn't love being {age} years old!");

        }
    }
}
