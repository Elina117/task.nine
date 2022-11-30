using System;
namespace task.nine
{
	public class Beach : Interface1
    {
        public void printRules()
		{
			Console.WriteLine("The task of the participants is to collect as many stones and " +
				"shells on the beach as possible, if the total number of these items is greater " +
				"than that of other teams, then the judge awards + 1 point. The game involves 5 people from the team.");
			Console.WriteLine("violations: injuring fellow students");
		}
		public void printThings()
		{
			Console.WriteLine("swimming trunks, nets, gloves, hats");
		}
		public void printInjuring(Player player, Teams team)
		{
			Console.WriteLine($"{player.name} from the team {team.title} fell and twisted his leg");
		}
	}
}

