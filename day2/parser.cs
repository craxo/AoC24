namespace Day2;

public static class Parser
{
   public static Input ParseInputIntoPairs()
   {
      Input input = new Input();
      StreamReader reader = new("/workspaces/AoC24/day2/input.txt");
      string text = reader.ReadToEnd();

      foreach(var level in text.Split('\n'))
      {
         char delimiter = ' ';
         Day2.Level levelToPopulate = new();
         
         foreach (var report in level.Split(delimiter))
         {
            levelToPopulate.Reports.Add(int.Parse(report));
         }
         input.Levels.Add(levelToPopulate);
      }
      return input;
   }
}


public class Input
{
   public List<Level> Levels = [];
}

public class Level
{
   public List<int> Reports = [];
   public bool IsSafe = false;
}

