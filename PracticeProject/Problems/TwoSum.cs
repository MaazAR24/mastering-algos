namespace PracticeProject.Problems
{
    internal class TwoSum
    {
        public void CalculateByBruteForce(int[] nums, int target)
        {
            int[] indices = new int[2];
            for (int i = 0; i < nums.Count(); i++)
            {
                for (int j = i + 1; j < nums.Count(); j++)
                {
                    var sum = nums[i] + nums[j];

                    if (sum == target)
                    {
                        indices[0] = nums[i];
                        indices[1] = nums[j];
                    }

                }
            }
            foreach (var item in indices)
            {
                Console.WriteLine(item);
            }
        }

        public int[] CalculateByUsingDictionary(int[] nums, int target)
        {
            var seen = new Dictionary<int, int>();
            for (int i = 0; i < nums.Count(); i++)
            {
                var diff = target - nums[i];
                if (seen.ContainsKey(diff))
                {
                    return new[] { seen[diff], i };
                }
                seen[diff] = i;
            }
            return Array.Empty<int>();
        }
    }
}
