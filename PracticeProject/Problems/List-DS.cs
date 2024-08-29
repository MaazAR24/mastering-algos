namespace PracticeProject.Problems
{
    internal class List_DS
    {
        public static void ReverseFirstColumn(List<List<int>> list)
        {
            int count = list.Count;
            Console.WriteLine(count / 2);
            for (int i = 0; i < count / 2; i++)
            { 
                var temp = list[i][0];
                list[i][0] = list[count - 1 - i][0];
                list[count - 1 - i][0] = temp;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(list[i][0]);
            }
        }

        public static void ReverseFirstRow(List<List<int>> list)
        {
            var first = list[0];
            first.Reverse();

            for (int i = 0; i < list[0].Count; i++)
            {
                Console.WriteLine(list[0][i]);
            }
        }

        public static void PrintZigZagSequence(List<int> list)
        {
            int k = (list.Count + 1) / 2;

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (i < k - 1 && list[j] < list[i])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }

                    if (i >= k - 1 && list[i] < list[j])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
