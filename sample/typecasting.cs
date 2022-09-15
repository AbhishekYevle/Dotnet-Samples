
//Type casting
namespace typecasting
{
    class prac4
    {
        public static void typecasting()
        {
            char one = 'a';
            int two = one;
            long three = two;
            float four = three;
            double five = four;

            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine(three);
            Console.WriteLine(four);
            Console.WriteLine(five);

            object z=1;
            z="jhgj";

            doSomething(z as string);
        }

        public static void doSomethin   g(string x)
        {

        }               
    }
}
