namespace PracticeProject
{
    public class Point
    {
        private double _x, _y;

        public static Point NewCartesionPoint(double x, double y) { 
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public override string ToString() { 
            return _x.ToString() + ", " + _y.ToString();
        }
        private Point(double a, double b)
        {
            _x = a;
            _y = b;
        }
    }
}
