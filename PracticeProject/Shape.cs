namespace PracticeProject
{
    public abstract class Shape
    {
        public virtual void Display() {
            Console.WriteLine("Square");
        }
    }

    public class Rectangle : Shape
    {
        public override void Display()
        {
            Console.WriteLine("Rectangle");
        }

        public void Test() { 
        
        }
    }

    public class CalculateArea
    {
        public void Display() {
            Shape shape = new Rectangle();
            shape.Display();
        }
    }



}