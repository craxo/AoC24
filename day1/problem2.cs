using System.Linq;

namespace Day1;

public static class Problem2
{
    public static int Solve()
    {
        var input = Day1.Parser.ParseInputIntoPairs();

        Console.WriteLine($"The input contains {input.LeftColumn.Count} lines");


        // Fredrik, do your thang!!
        input.LeftColumn.Sort();
        input.RightColumn.Sort();

        int sum = 0;
        for (int i = 0; i < input.LeftColumn.Count; i++)
        {
            var occurences = input.RightColumn.Where(x => x == input.LeftColumn[i]).ToList();
            sum += input.LeftColumn[i] * occurences.Count;
        }

        return sum;
    }
}