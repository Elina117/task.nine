using System;
namespace task.nine
{
	public class Slide
	{
        public void printRules()
        {
            Console.WriteLine("the participants take turns climbing the rock and " +
                "pressing the buttons indicating that a certain level of" +
                " the mountain has been reached.");
        }

        public void printThings()
        {
            Console.WriteLine("helmet, gloves, boots, safety rope");
        }

        public void printInjuring(Player player, Teams team)
        {
            Console.WriteLine($"{player.name} from the team {team.title} fell down the mountain and crashed");
        }
    }
}

