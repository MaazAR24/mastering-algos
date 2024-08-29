namespace PracticeProject.Problems
{
    internal class StairCase
    {
        public static void Print(int n)
        {
            int counter = 1;
            while (counter <= n) 
            {
                for (int j = 0; j < n - counter; j++)
                {
                    Console.Write(' ');
                }
                for (int i = 0; i < counter; i++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
                counter++;
            }
        }
    }
}
