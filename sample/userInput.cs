//user input
namespace userInput
{
    class prac5
    {
        public static void userInput()
        {
            Console.WriteLine("Enter name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your Name is {name} and your age is {age}");

        }
    }
}
