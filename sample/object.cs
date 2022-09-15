namespace obj
{
    class bike
    {
        string type = "Twister";
        int cc = 125;
        public static void obj()
        {
            bike model = new bike();
            bike engine = new bike();

            Console.WriteLine("Enetr Bike Name?");
            model.type = Console.ReadLine();
            Console.WriteLine("Enetr CC of Bike?");
            engine.cc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(model.type + " is " + engine.cc + "cc Bike.");

        }
    }
}