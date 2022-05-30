using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Alias
    {
        public string[] words = new string[] { "apple", "friends", "university", "city", "ukraine", "africa", "defend", "pocket", "toy", "light", "weather", "depend", "mouse", "river" };

        private Game game;
        private Random rnd;
        private List<Player> listOfUsers;
        public int whoWin = 0;


        public Alias(Game Game, Random Rnd, List<Player> ListOfUsers)
        {
            game = Game;
            rnd = Rnd;
            listOfUsers = ListOfUsers;
        }
        public void StartGameAlias()
        {
            while (true)
            {

                for (int i = 0; i < game._numberPlayers; i++)
                {

                    if (listOfUsers[i].checkRules == false)
                    {
                        listOfUsers[i].LookRules();
                    }
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine("player: " + listOfUsers[i].namePlayer);
                        Console.WriteLine("word: " + words[rnd.Next(0, words.Length)]);
                        Console.WriteLine("1 - if response correct, 2 - can't guess response");
                        int response = Convert.ToInt32(Console.ReadLine());
                        if (response == 1) { listOfUsers[i].correctResponse += 1; }
                        if (response == 2) { listOfUsers[i].incorrectResponse += 1; }
                    }
                  
                    Console.WriteLine("result: correct: " + listOfUsers[i].correctResponse + ", incorrect: " + listOfUsers[i].incorrectResponse);
                    Console.WriteLine("if u wanna continue press Enter...");
                    Console.ReadLine();

                }
                for (int i = 0; i < game._numberPlayers; i++)
                {
                    if (listOfUsers[i].correctResponse > whoWin)
                    {
                        whoWin = i;
                    }

                }
                Console.Clear();
                Console.WriteLine("Win... " + listOfUsers[whoWin].namePlayer + ", correct response: " + listOfUsers[whoWin].correctResponse);
                break;
            }
        }

    }
}
