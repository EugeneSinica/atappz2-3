using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Player
    {
        public bool checkRules = false;
        public int numberPlayer;
        public string namePlayer;
        public int correctResponse;
        public int incorrectResponse;

        public Player (string NamePlayer) {
            namePlayer = NamePlayer;
        }

        public void LookRules ()
        {
            Console.Clear();
            Console.WriteLine("                                                    Rules       ");
            Console.WriteLine("Divided into two or more teams (minimum 2 people each), you begin to guess the explanations of both your player\n" +
                " and someone else's. Each guessed word is one move forward on the playing field. The limitation is\n " +
                "only an hourglass that rushes all players.\n");
            checkRules = true;
        }


    }
}
