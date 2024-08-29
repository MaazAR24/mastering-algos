namespace PracticeProject.Problems
{
    internal class MiniMaxSum
    {
        public static void Print(List<int> arr)
        {
            int sum = 0;
            int count = arr.Count();

            int lowest = arr[0];
            int highest = arr[0];
            for (int i = 0; i < count; i++)
            {
                if (arr[i] < lowest)
                    lowest = arr[i];
                if (arr[i] > highest)
                    highest = arr[i];
                sum += arr[i];
            }

            Console.WriteLine(lowest + " " + highest);

            var dic = new Dictionary<int, int>();

            var key = dic.Where(e => e.Value == 1).First().Key;

            dic[key]++;
        }
    }
}
