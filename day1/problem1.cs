using System.Reflection.Emit;

namespace Day1;

public static class Problem1
{
    public static int Solve()
    {
        var input = Day1.Parser.ParseInputIntoPairs();

        Console.WriteLine($"The input contains {input.LeftColumn.Count} lines");


        // Fredrik, do your thang!!
        input.LeftColumn.Sort();
        input.RightColumn.Sort();

        int sum = 0;
        for(int i = 0; i < input.LeftColumn.Count; i++)
        {
            sum += Math.Abs(input.LeftColumn[i]-input.RightColumn[i]);
        }

        return sum;
    }
}