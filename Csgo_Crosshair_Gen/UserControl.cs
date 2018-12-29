using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csgo_Crosshair_Gen
{
    class UserControl
    {
        public void Dialog()
        {
            Console.WriteLine("\r\nHeltes Roulette \r\n");
            Console.WriteLine("This roulette will pick a random pro csgo player \r\n");
            Console.WriteLine("After the pick go onto the map config generator or crosshair generator by Crashz and Misterio \r\n");
            Console.WriteLine("And find the pro player that you got pick \r\n");
            Console.WriteLine("Are you ready? \r\n");
            Console.WriteLine("Yes or No \r\n");

        }

        public void DisplayPlayers(string player1, string player2, string player3)
        {
            bool endProgram = false;
            while (endProgram == false)
            {
                string userPick = Console.ReadLine().ToLower();

                if (userPick == "yes")
                {
                    Console.Clear();
                    Console.WriteLine("\r\nFirst the crosshair hud viewmodel and rader");
                    Console.WriteLine("you have to play with " + player1 + "s crosshair hud viewmodel and rader \r\n");

                    Console.WriteLine("now the screen res");
                    Console.WriteLine("you have to play with " + player2 + "s res \r\n");

                    Console.WriteLine("now the mouse settings - sens and acceleration");
                    Console.WriteLine("you have to play with " + player3 + "s sens and acceleration \r\n");

                    Console.WriteLine("Good Luck");
                    endProgram = true;
                }
                else
                {
                    Console.WriteLine("not a valid answer try again");
                    Console.WriteLine("Are you ready?");
                    Console.WriteLine("Yes or No");
                    userPick = Console.ReadLine().ToLower();

                }
            }
        }
    }
}
