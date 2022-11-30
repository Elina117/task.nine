using System;
namespace task.nine
{
	public class Fishing : Interface1
    {
        public void printRules()
        {
            Console.WriteLine("Participants must make their own fishing rods and catch" +
                " as many fish as possibleParticipants must make their own fishing rods " +
                "and catch as many fish as possible");
        }

        public void printThings()
        {
            Console.WriteLine("fishing line, hook, worms, stick");
        }

        public void printInjuring(Player player, Teams team)
        {
            Console.WriteLine($"{player.name} scratched his finger from the team" +
                $" {team.title} and dropped out of the game");
        }
    }
}

