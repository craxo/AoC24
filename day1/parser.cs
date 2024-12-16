namespace Day1;

public static class Parser
{
   public static Input ParseInputIntoPairs()
   {
      Input input = new Input();
      StreamReader reader = new("/workspaces/AoC24/day1/input.txt");
      string text = reader.ReadToEnd();

      foreach(var line in text.Split('\n'))
      {
         int leftColumn = 0;
         int rightColumn = 0;
         string delimiter = "   ";

         leftColumn = int.Parse(line.Split(delimiter)[0]);
         rightColumn = int.Parse(line.Split(delimiter)[1]);

         input.LeftColumn.Add(leftColumn);
         input.RightColumn.Add(rightColumn);
      }

      return input;
   }
}


public class Input
{
   public List<int> LeftColumn = new();
   public List<int> RightColumn = new();
}

