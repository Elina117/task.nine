using System;
namespace task.nine
{
	public class Mousetrap
	{
		public void printRules()
		{
			Console.WriteLine("Members of one team wear mouse costumes, and the other team " +
				"wears cat costumes. If the cats catch mice within half an hour, then the team of " +
				"cats has won. Cats and masha are determined by drawing lots.");
		}

		public void printThings()
		{
			Console.WriteLine("mouse costume, cat costume, cheese");
		}

		public void printInjuring(Player player, Teams team)
		{
			Console.WriteLine($"{player.name} from the team {team.title}pinched his leg in a mousetrap");
		}
    }
}

