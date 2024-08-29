namespace PracticeProject.Problems
{
    internal class DiagonalDifference
    {
        public void Calculate(List<List<int>> list) 
        {
            int mainDiagonalSum = 0;
            int antiDiagonalSum = 0;
            int count = list.Count() - 1;
            //for (int i = 0; i <= count; i++)
            //{
            //    for (int j = i; j == i; j++)
            //    {
            //        firstSum += arr[i][j];
            //    }
            //}

            //int secondSum = 0;
            //for (int i = 0; i <= count; i++)
            //{
            //    for (int j = count - i; j == count - i; j++)
            //    {
            //        secondSum += arr[i][j];
            //    }
            //}

            //for (int i = 0; i < list.Count; i++)
            //{
            //    for (int j = 0; j < list[i].Count; j++)
            //    {
            //        if (i == j) // Main diagonal
            //        {
            //            mainDiagonalSum += list[i][j];
            //        }

            //        if (i + j == list.Count - 1) // Anti-diagonal
            //        {
            //            antiDiagonalSum += list[i][j];
            //        }
            //    }
            //}



            Console.WriteLine(mainDiagonalSum + " " +  antiDiagonalSum);

            Console.WriteLine(mainDiagonalSum - antiDiagonalSum);
        }
    }
}
