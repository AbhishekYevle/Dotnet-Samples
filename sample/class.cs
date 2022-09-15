namespace classes
{
    class prac8
    {
        string model = "";
        string color = "";
        int maxSpeed;

        public static void classes()
        {
            prac8 ford = new prac8();
            ford.model = "mustang";
            ford.color = "RED";
            ford.maxSpeed = 350;

            prac8 bmw = new prac8();
            bmw.model = "BMW-x6";
            bmw.color = "Purple";
            bmw.maxSpeed = 300;

            Console.WriteLine(ford.model);
            Console.WriteLine(ford.color);
            Console.WriteLine(ford.maxSpeed);
            Console.WriteLine(bmw.model);
            Console.WriteLine(bmw.color);
            Console.WriteLine(bmw.maxSpeed);
        }

    }
    
}