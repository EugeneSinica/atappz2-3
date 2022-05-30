using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Game
    {
        enum Games
        {
            alias = 1,
            mafia = 2,
            monopoly = 3,
        }
        enum Guess
        {
            correct = 1,
            uncorrect = 2
        }
        public int _numberPlayers;
        public int whichGame;
        private List<Player> listOfUsers;
    

        public Game(List<Player> ListOfUsers)
        {
            listOfUsers = ListOfUsers;
        }
        public void StartGame()
        {
            Console.Write("input numbers of players: ");
            while (true)
            {
                 _numberPlayers = Convert.ToInt32(Console.ReadLine());

                if (_numberPlayers >= 2)
                {
                    break;
                }
                Console.WriteLine("numbers should be more than 1  `min 2`");

            }
            //create list for players


            //  add the players
            for (int i = 1; i < _numberPlayers + 1; i++)
            {
                Console.Write("input " + i + " player: ");
                string player = Console.ReadLine();

                listOfUsers.Add(new Player(player));

            }

            void WriteGame(Games game)
            {
                Console.Write($"{game} ");
            }
            // choose game
            int myEnumMemberCount = Enum.GetNames(typeof(Games)).Length;
            for (int i = 1; i < myEnumMemberCount + 1; i++)
            {

                WriteGame((Games)i);
                Console.WriteLine("- " + i);
            }
            //select game
            while (true)
            {
                Console.Write("Select game: ");
                whichGame = Convert.ToInt32(Console.ReadLine());
                if (whichGame == 1 || whichGame == 2 || whichGame == 3)
                {
                    Console.WriteLine();
                    break;
                }
                Console.WriteLine("incorrect select");
            }
        }
    }
}

