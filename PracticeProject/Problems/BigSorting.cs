namespace PracticeProject.Problems
{
    internal class BigSorting
    {
        public static void SelectionSort(List<string> unsorted) 
        {
            for (int i = 0; i < unsorted.Count; i++) 
            {
                for (int j = i + 1; j < unsorted.Count; j++)
                {
                    if (unsorted[j].Length < unsorted[i].Length) {
                        var temp = unsorted[i];
                        unsorted[i] = unsorted[j];
                        unsorted[j] = temp;
                    }
                }
            }

            foreach (var item in unsorted)
            {
                Console.WriteLine(item);
            }
        }

        public static void SortThroughArraySort(List<string> unsorted) 
        {
            var arr = unsorted.ToArray();
            Array.Sort(arr, (left, right) => {
                if (left.Length != right.Length)
                    return left.Length - right.Length;
                else
                    return string.CompareOrdinal(left, right);
            });

            foreach(var item in arr)
                Console.WriteLine(item);
        }

        //public static void SortThroughHashtable(List<string> unsorted)
        //{
        //    var cache = new Dictionary<int, List<string>>();

        //    foreach (var item in unsorted)
        //    {
        //        var len = item.Length;
        //        if (!cache.ContainsKey(len))
        //        {
        //            cache[len] = new List<string> { item };
        //        }
        //        var nums = cache[len];
        //        nums.Add(item);
        //    }

        //    var sorted = new List<string>();

        //    var sizes = cache.Select(x => x.Key).ToArray();
        //    Array.Sort(sizes);

        //    foreach (var item in sizes)
        //    {
        //        var numbers = cache[item].ToArray();
        //        var sortedNumbers = Array.Sort(numbers);
        //    }
        //}
    }
}
