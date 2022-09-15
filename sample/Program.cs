using System;
using System.IO;

namespace program
{
  class prac1
  {

    //Main function of program which excutes all practicals by calling every method
    static void Main(string[] args)
    {
      if(args == null)
      {
        Console.WriteLine("Argument is NULL.");
      }
      // if (args.Equals("exit", StringComparison.OrdinalIgnoreCase))
      {
        //univarsal variables
        string path = @"C:\Users\yevlea\Downloads\test.txt";

        int program = 0;
        Console.WriteLine("Hiii Welcome to Program.");
        Console.WriteLine("1.method parameter & overloading");
        Console.WriteLine("2.output");
        Console.WriteLine("3.datatype");
        Console.WriteLine("4.typecasting");
        Console.WriteLine("5.userInput");
        Console.WriteLine("6.operators");
        Console.WriteLine("7.math");
        Console.WriteLine("8.class");
        Console.WriteLine("9.object");
        Console.WriteLine("10.constructor");
        Console.WriteLine("11.Encapsulation");
        Console.WriteLine("12.Inheritance");
        Console.WriteLine("13.Polymorphism");
        Console.WriteLine("14.Abstract");
        Console.WriteLine("15.Interfaces");
        Console.WriteLine("16.enum");
        Console.WriteLine("17.File Write");
        Console.WriteLine("18.File Read");
        Console.WriteLine("19.Try Catch");
        Console.WriteLine("20.exception");
        Console.WriteLine("Please select program to run?");

        program = Convert.ToInt32(Console.ReadLine());

        switch (program)
        {
          //method parameter & overloading
          case 1:
            // Method parameter
            Console.Write("Write your name?");
            Console.WriteLine("Write hours?");
            hello(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));

            //mwthod overloading
            int num1 = plusMethod(8, 5);
            double num2 = plusMethod(4.3, 10.2);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            break;

          // Output Section - print simple statements 
          case 2:
            output.prac2.second();
            break;

          // Datatype Section - unique data type
          case 3:
            datatype.prac3.datatype();
            break;

          // Typecasting - Conversion of type of variable
          case 4:
            typecasting.prac4.typecasting();
            break;

          // userInput - user gives values
          case 5:
            userInput.prac5.userInput();
            break;

          // Operators - unique operations performed by operators
          case 6:
            operators.prac6.operators();
            break;

          // Math - used for max min sqrt values
          case 7:
            mathematics.prac7.mathematics();
            break;

          // class - exachange data from different classes
          case 8:
            classes.prac8.classes();
            break;

          //object creating
          case 9:
            obj.bike.obj();
            break;

          //Constructor
          case 10:
            car audi = new car();
            Console.WriteLine(audi.color);
            break;

          //Encapsulation
          case 11:
            engi obje = new engi();
            Console.WriteLine("Enter Your Name?");
            obje.streamName = Console.ReadLine();
            Console.WriteLine(obje.streamName);
            break;

          //inheritance
          case 12:
            cars myCar = new cars();
            myCar.voice();
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
            break;

          //polymorphism
          case 13:
            vehical myVehical = new vehical();
            vehical myCars = new cars();
            vehical myCars1 = new cars1();

            myCars1 = (vehical)myVehical;

            myVehical.voice();
            ((vehical)myCars).voice();
            ((vehical)myCars1).voice();

            myCars.voice();
            ((cars)myVehical).voice();
            ((cars)myCars1).voice();

            myCars1.voice();
            ((cars1)myVehical).voice();
            ((cars1)myCars).voice();
            break;

          //Abstarct method
          case 14:
            Obj.Square SQ = new Obj.Square();
            Obj.circle objecto = new Obj.circle();
            objecto.Sos();
            objecto.universal();
            ((Obj.circle)objecto).universal();
            ((Obj.circle)objecto).Sos();
            ((Obj.Square)SQ).universal();
            ((Obj.Square)SQ).Sos();
            // genetics.Americans newHuman = new genetics.Americans();
            // newHuman.Sos();
            // newHuman.humans()
            break;

          //Interfaces
          case 15:
            interfaces.DemoClass myint = new interfaces.DemoClass();
            interfaces.DemoClass1 myint1 = new interfaces.DemoClass1();
            myint.myMethod();
            myint.myOtherMethod();

            myint1.myMethod();
            myint1.myOtherMethod();

            // ((interfaces.DemoClass)myint1).myMethod();
            // ((interfaces.DemoClass)myint1).myOtherMethod();

            // ((interfaces.DemoClass1)myint).myMethod();
            // ((interfaces.DemoClass1)myint).myOtherMethod();



            break;

          //enum - constatnt variables
          case 16:
            int result = (int)rating.Excellent;
            Console.WriteLine(result);

            rating rslt = rating.Ver_Good;
            switch (rslt)
            {
              case rating.Very_Poor:
                Console.Write("Your Performance is So Poor!!");
                break;

              case rating.Good:
                Console.Write("Your Performance is Good!!");
                break;
              case rating.Ver_Good:
                Console.Write("Your Performance is So Good!!");
                break;
              case rating.Excellent:
                Console.Write("Your Performance is Excellent!!");
                break;


            }
            break;

          //write text in file operation
          case 17:
            //variable is declared univarsal
            Console.WriteLine("Enter data in file:");
            string writetxt = Console.ReadLine() + Environment.NewLine;
            File.WriteAllText(path, writetxt);
            break;

          //Read Text from file operation
          case 18:
            //variable is declared univarsal
            string readtxt = File.ReadAllText(path);
            Console.WriteLine(readtxt);
            break;

          //try catch method
          case 19:
            try
            {
              Console.WriteLine("Enter Number 1:");
              int x = int.Parse(Console.ReadLine());
              Console.WriteLine("Enter Number 2:");
              int y = int.Parse(Console.ReadLine());

              int z = x / y;

              Console.WriteLine("The result is " + z + ".");

              // int[] num = { 1, 2, 3, 4, 5, 6 };
              // Console.WriteLine(num[8]);
            }
            catch (DivideByZeroException E_var)
            {
              Console.WriteLine(E_var.Message);
            }
            catch (FormatException E_var1)
            {
              Console.WriteLine("The input entered is not correct");
            }
            Console.WriteLine("<=======End of Program=======>");
            break;

          //exception methods
          case 20:
            int myAge = 0;
            Console.WriteLine("Enter Your Age?");
            myAge = Convert.ToInt32(Console.ReadLine());
            verify.checkAge(myAge);
            break;

          // default program if any invalid input detected
          default:
            Console.WriteLine("<=======Invalid Input=======>");
            break;
        }
      }





    }
    //method parameter
    public static void hello(string h, int m)
    {
      Console.WriteLine(h + " is Coding.....  " + m);
    }

    // method overloading
    public static int plusMethod(int x, int y)
    {
      return x + y;
    }

    // method overloading - multiple methods have same name as lomg as the type of parameter or numbers are diffrent 
    public static double plusMethod(double x, double y)
    {
      return x + y;
    }
  }
  //Constructor parameter
  class car
  {
    public string color;

    public car()
    {
      color = "Purple";
    }

  }
  // encapsulation
  class engi
  {
    private string Stream; //field
    public string streamName //property
    {
      get { return Stream; }
      set { Stream = value; }
    }
  }

  //inheritance - polymorphism
  class vehical //base class parent
  {
    public string brand = "toyota";
    public virtual void voice()
    {
      Console.WriteLine("frrrrrrrrr.......... frrrrrrrrrrrrrrr..............!!");
    }
  }

  class cars : vehical //derived class child
  {
    public string modelName = "Supra";
    public override void voice()
    {

      Console.WriteLine("Hmmmmmmmmmmmmm.............hmmmmmmmmmmmmmmm.........!");
    }
  }

  class cars1 : vehical //derived class child
  {
    public string modelName = "Fortuner";
    public override void voice()
    {
      Console.WriteLine("brrrrmmmmmmmmmmmmm.............brrrrrrmmmmmmmmmmmmmmm.........!");
    }
  }


}


//Interfaces 
namespace interfaces
{
  interface ifirstinterface
  {
    void myMethod();
  }

  interface isecondinterface
  {
    void myOtherMethod();
  }

  class DemoClass : ifirstinterface, isecondinterface
  {
    public void myMethod()
    {
      Console.WriteLine("This is first inetrface method.");
    }
    public void myOtherMethod()
    {
      Console.WriteLine("This is my second method.");
    }

  }
  class DemoClass1 : ifirstinterface, isecondinterface
  {
    public void myMethod()
    {
      Console.WriteLine("This is first duplicate inetrface method.");
    }
    public void myOtherMethod()
    {
      Console.WriteLine("This is my second duplicate method.");
    }
  }
}