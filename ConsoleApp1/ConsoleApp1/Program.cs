using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {
            List<Player> listOfUsers = new List<Player>();
            Game game = new Game(listOfUsers);
            Random rnd = new Random();
            game.StartGame();
            if (game.whichGame == 1)
            {
                Alias alias = new Alias(game, rnd, listOfUsers);
                alias.StartGameAlias();
        }
    }
}
}
