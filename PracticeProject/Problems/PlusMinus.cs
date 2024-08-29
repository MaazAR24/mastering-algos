namespace PracticeProject.Problems
{
    internal class PlusMinus
    {
        public static void Calculate(List<int> arr) 
        {
            decimal greaterThanZero = 0, equalToZero = 0, lessThanZero = 0, count = arr.Count();

            foreach (var item in arr)
            {
                if (item > 0)
                {
                    greaterThanZero++;
                }
                else if (item < 0)
                {
                    lessThanZero++;
                }
                else 
                {
                    equalToZero++;
                }
            }

            decimal greaterThanZeroRatio = Decimal.Round(greaterThanZero / count, 6);

            Console.WriteLine(greaterThanZeroRatio);
            Console.WriteLine(Decimal.Round(lessThanZero / count, 6));
            Console.WriteLine(Decimal.Round(equalToZero / count, 6));
        }
    }
}
