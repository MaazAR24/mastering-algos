// See https://aka.ms/new-console-template for more information
using PracticeProject.LeetCode;
using PracticeProject.Problems;

//int t = Convert.ToInt32(Console.ReadLine().Trim());

//int n = Convert.ToInt32(Console.ReadLine().Trim());

//List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
var list = new List<List<int>>
{
    new List<int> { 3 },
    new List<int> { 11, 2 ,4 },
    new List<int> { 3, 5, 7 },
    new List<int> { 9, 13, 18 }
};

int[] arr = new int[6];

CountingBits.Count(2);

//Arrays_DS.reverseArray(new List<int> { 2, 3, -4 });
//BigSorting.SortThroughArraySort(new List<string> { "31415926535897932384626433832795", "25", "12", "22", "11" });
//ApplesAndOranges.Print(7, 10, 4, 12, new List<int> { 2, 3, -4 }, new List<int> { 3, -2, -4 });

//LonelyInteger.Calculate(new List<int> { 1, 1, 2, 5, 5 });

//Console.WriteLine(FindMedian.Find(new List<int> { -1, -1, -2, -5, -5 }));

//List_DS.ReverseFirstRow(
//        new List<List<int>>
//        {
//            new List<int> {1, 2, 3, 4},
//            new List<int> {5, 6, 7, 8},
//            new List<int> {9, 10, 11, 12},
//            new List<int> {12, 10, 11, 12},
//            new List<int> {7, 10, 11, 12}
//        }
//    );

//List_DS.PrintZigZagSequence(new List<int> { 2, 3, 5, 1, 4});



abstract class TestAbstract {
    public void Test() {
        Console.WriteLine("Hello");
    }

    public abstract void AbstractMethod();

    bool IsDivisibleOnlyByItselfAndOne(int n)
    {
        var limit = n / 2;
        for (int i = 0; i <= limit; i++)
            if (n % i == 0) { return false; }
        return true;
    }
}

