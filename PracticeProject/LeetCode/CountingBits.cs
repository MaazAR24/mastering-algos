namespace PracticeProject.LeetCode
{
    internal class CountingBits
    {
        public static void Count(int n)
        {
            int[] arr = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                int oddCounter = 0;
                int remainder = i;
                while (remainder != 0)
                {
                    if (remainder % 2 != 0) oddCounter++;

                    remainder = remainder / 2;
                }
                arr[i] = oddCounter;
                Console.WriteLine(arr[n]);
            }
        }
    }
}
