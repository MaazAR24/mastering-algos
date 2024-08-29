namespace PracticeProject.Problems
{
    internal class LonelyInteger
    {
        public static int Calculate(List<int> a) 
        {
            var dictionary = new Dictionary<int, int>();

            foreach (int i in a)
            {
                if (dictionary.ContainsKey(i))
                    dictionary[i]++;
                else
                    dictionary[i] = 1;
            }

            return dictionary.Where(e => e.Value == 1).First().Key;
        }
    }
}
