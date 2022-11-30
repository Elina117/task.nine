using System;

namespace task.nine
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            StreamReader NameGender = new StreamReader("teamRussia");

           //Add players in team's lists

            string[] ListOfPlayers1 = NameGender.ReadLine().Split(",");
            List<Player> playersRussia = new List<Player>();
            for (int i = 0; i < ListOfPlayers1.Length; i++)
            {
                playersRussia.Add(new Player(ListOfPlayers1[i], rnd.Next(11), rnd.Next(11), rnd.Next(11), ListOfPlayers1[i + 1], rnd.Next(11)));
            }


            string[] listOfPlayers2 = NameGender.ReadLine().Split(",");
            List<Player> playersFrance = new List<Player>();
            for (int i = 0; i < listOfPlayers2.Length; i++)
            {
                playersFrance.Add(new Player(listOfPlayers2[i], rnd.Next(11), rnd.Next(11), rnd.Next(11), listOfPlayers2[i + 1], rnd.Next(11)));
            }


            string[] listOfPlayers3 = NameGender.ReadLine().Split(",");
            List<Player> playersJapan = new List<Player>();
            for (int i = 0; i < listOfPlayers3.Length; i++)
            {
                playersJapan.Add(new Player(listOfPlayers3[i], rnd.Next(11), rnd.Next(11), rnd.Next(11), listOfPlayers3[i + 1], rnd.Next(11)));
            }


            string[] listOfPlayers4 = NameGender.ReadLine().Split(",");
            List<Player> playersUkrain = new List<Player>();
            for (int i = 0; i < listOfPlayers4.Length; i++)
            {
                playersUkrain.Add(new Player(listOfPlayers4[i], rnd.Next(11), rnd.Next(11), rnd.Next(11), listOfPlayers4[i + 1], rnd.Next(11)));
            }

            

            //Create teams titles and another components in particular claa "Teams"

            Teams Russia = new Teams(playersRussia, "Brown Beaars", "Petr", 0);
            Teams France = new Teams(playersFrance, "Bagget", "Oliver", 0);
            Teams Japan = new Teams(playersJapan, "Fish time", "Kennadi", 0);
            Teams Ukrain = new Teams(playersUkrain, "Pigglet", "Boris", 0);


            //Starting of performance

            //Add all name of teams in one list

            List<Teams> teams = new List<Teams>() { Russia, France, Japan, Ukrain };

            Console.Write("The host of the show Olivier Gagnan announces the teams that will compete in 6 games: ");

            for (int i = 0; i < teams.Count; i++)
            {
                Console.Write(teams[i]);
            }

            //Now you'll choose the game you want to play
            Console.Write("Now the host of the show gives u a chance to choose game, choose the number:" +
                "1. Beach" +
                "2. Mousetrap" +
                "3. Sea" +
                "4. Fishing" +
                "5. Postmen" +
                "6. Slide");


            int choice = 0;

            switch (choice)
            {
                case 1:
                    {
                        Beach beach = new Beach();
                        beach.printRules();
                        beach.printThings();
                        break;
                    }
                case 2:
                    {
                        Mousetrap mousetrap = new Mousetrap();
                        mousetrap.printRules();
                        mousetrap.printThings();
                        break;
                    }
                case 3:
                    {
                        Sea sea = new Sea();
                        sea.printRules();
                        sea.printThings();
                        break;
                    }
                case 4:
                    {
                        Fishing fishing = new Fishing();
                        fishing.printRules();
                        fishing.printThings();
                        break;
                    }
                case 5:
                    {
                        Postmen postmen = new Postmen();
                        postmen.printRules();
                        postmen.printThings();
                        break;
                    }
                case 6:
                    {
                        Slide slide = new Slide();
                        slide.printRules();
                        slide.printThings();
                        break;
                    }


            }


        }
    }
}

