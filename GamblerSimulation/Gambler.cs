using System;
using System.Collections.Generic;
using System.Text;

namespace GamblerSimulation
{
    public class Gambler
    {
        public const int stake = 100;
        public int bet = 1;

        public static void GamblerWinOrLoose()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == 1)
            {
                Console.WriteLine("Gambler win the bet $1");
            }
            else
            {
                Console.WriteLine("Gambler loose the bet $1");
            }
        }
    }
}
