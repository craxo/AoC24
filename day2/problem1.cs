namespace Day2;

public enum Trend
{
    UNITIALIZED,
    DECREASING,
    STABLE,
    INCREASING,
}

public static class Problem1
{
    public static int Solve()
    {
        int safeLevels = 0;
        var input = Day2.Parser.ParseInputIntoPairs();

        Console.WriteLine($"The input contains {input.Levels.Count} lines");

        foreach (var level in input.Levels)
        {
            Trend trendPointer = Trend.UNITIALIZED;
            Trend previousPointer = Trend.UNITIALIZED;
            var reports = level.Reports;
            level.IsSafe = true;
            foreach (var (currentReport, nextReport) in reports.Zip(reports.Skip(1)))
            {
                if (Math.Abs(currentReport-nextReport) > 3)
                {
                    level.IsSafe = false;
                    break;
                }

                if (currentReport < nextReport)
                {
                    trendPointer = Trend.INCREASING;
                }
                else if (currentReport > nextReport)
                {
                    trendPointer = Trend.DECREASING;
                }
                else
                {
                    trendPointer = Trend.STABLE;
                    level.IsSafe = false;
                    break;
                }

                if (previousPointer == Trend.UNITIALIZED)
                    previousPointer = trendPointer;
                else if (previousPointer != trendPointer)
                {
                    level.IsSafe = false;
                    break;
                }
            }

            if (level.IsSafe == true)
                safeLevels++;
        }

        Console.WriteLine($"There were {safeLevels} safe level");
        return safeLevels;
    }
}