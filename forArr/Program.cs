using System;


namespace forArr
{
  class Program
  {
    static void Main(string[] args)
    {
      args = new string[2];
      args[0] = "welcome in";
      args[1] = "www.overflow.com";

      //program execution starts from here
      Console.WriteLine("Total Arguments: {0}", args.Length);

      Console.Write("Arguments: ");

      foreach (var arg in args)
        Console.Write(arg + ", ");
    }
  }














  //   if (args == null)
  //   {
  //     Console.WriteLine("args is null"); // Check for null array
  //   }
  //   else
  //   {
  //   args = new string[2];
  //   args[0] = "welcome in";
  //   args[1] = "www.overflow.com";
  //     Console.Write("args length is ");
  //     Console.WriteLine(args.Length); // Write array length
  //     for (int i = 0; i < args.Length; i++) // Loop through array
  //     {
  //       string argument = args[i];
  //       Console.Write("args index ");
  //       Console.Write(i); // Write index
  //       Console.Write(" is [");
  //       Console.Write(argument); // Write string
  //       Console.WriteLine("]");
  //     }
  //   }
  //     public static void Main(string[] args)
  //     {
  //         if(args == null)
  //         {
  //             Console.WriteLine("Argument is NULL.");
  //         }
  //         else
  //         // if (args.Equals("exit", StringComparison.OrdinalIgnoreCase))
  //         {
  //             args = new string[20];
  //             args[0] = "Welcome in";
  //             args[1] = "method parameter & overloading";
  //             args[0] = "";
  //             args[0] = "";

  //     }   
  // }
}
