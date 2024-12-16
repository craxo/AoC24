using Day2;

Console.WriteLine("Advent of Code - 2024!");
Console.WriteLine("Select which day and problem to run!");
Console.WriteLine("Example: 1-2 for day 1, problem 2");
string? dayProblemToRun = Console.ReadLine()?.ToString();

if (dayProblemToRun is null)
{
    Console.WriteLine("No input provided!");
    return;
}
Console.WriteLine($"Executing day: {dayProblemToRun}");

int day = int.Parse(dayProblemToRun.Split('-')[0]);
var problem = int.Parse(dayProblemToRun.Split('-')[1]);

SolveDayAndProblem(day, problem);


void SolveDayAndProblem(int day, int problem)
{

    int result = 0;

    switch (day)
    {
        case 1:
            if (problem == 1)
                result = Day1.Problem1.Solve();
            else
                result = Day1.Problem2.Solve();
            break;
        case 2:
            if (problem == 1)
                result = Day2.Problem1.Solve();
            else
                result = Day2.Problem2.Solve();
            break;
        case 3:
        case 4:
        case 5:
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:
        case 11:
        case 12:
        case 13:
        case 14:
        case 15:
        case 16:
        case 17:
        case 18:
        case 19:
        case 20:
        case 21:
        case 22:
        case 23:
        case 24:
        case 25:
            Console.WriteLine("No solution was implemented for this task yet...");
            break;
        default:
            Console.WriteLine("There are unfortunately only 25 days of christmas...");
            break;
    }

    Console.WriteLine($"Result was: {result}");

}