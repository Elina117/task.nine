using System;
namespace task.nine
{
	public class Sea
	{
		public void printRules()
		{
			Console.WriteLine("the participants of each team must swim the designated " +
				"distance to the buoy, pick up the pin and pass it to the next participant.");
		}

		public void printThings()
		{
			Console.WriteLine("swimming trunks, skittles, buoy");
		}

		public void printInjuring(Player player, Teams team)
		{
			Console.WriteLine($"{player.name} from the team {team.title} drowned and drowned");
		}
    }
}

