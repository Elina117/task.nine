using System;
namespace task.nine
{
	public class Postmen
	{
        public void printRules()
        {
            Console.WriteLine("participants need to deliver postcards to the addresses they" +
                " have written, but one postcard was lost. " +
                "all postcards contain hints for finding a lost card");
        }

        public void printThings()
        {
            Console.WriteLine("postcards, pens, pencils");
        }

        public void printInjuring(Player player, Teams team)
        {
            Console.WriteLine($"{player.name} from the team {team.title} got lost in the woods and dropped out of the game");
        }
    }
}

