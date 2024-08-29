namespace PracticeProject.Problems
{
    internal class ApplesAndOranges
    {
        public static void Print(int s, int t, int a, int b, List<int> apples, List<int> oranges) 
        {
            int applesCount = 0;
            int orangesCount = 0;

            foreach (int app in apples)
            {
                var pointA = app + a;
                if (pointA >= s && pointA <= t)
                    applesCount += 1;
            }

            foreach (int or in oranges)
            {
                var pointB = or + b;
                if (pointB >= s && pointB <= t)
                    orangesCount += 1;
            }
            Console.WriteLine(applesCount);
            Console.WriteLine(orangesCount);
        }
    }
}
