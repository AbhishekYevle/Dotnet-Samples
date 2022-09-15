namespace Obj
{
  abstract class Shapes
  {
    public abstract void universal();
    public void Sos()
    {
      Console.WriteLine("Some object which can be identified by their curves is called as SHAPES!!!");
    }
  }

  class circle : Shapes
  {
    public override void universal()
    {
      Console.WriteLine("This is Circle=>O.");
    }

  }

  class Square : Shapes
  {
    public override void universal()
    {
      Console.WriteLine("This is Square => [].");
    }

  }
}

