namespace PracticeProject.Problems
{
    internal class FindMedian
    {
        public static int Find(List<int> arr)
        {
            var array = arr.ToArray();
            Array.Sort(array);
            return array[array.Length / 2];
        }
    }
}
