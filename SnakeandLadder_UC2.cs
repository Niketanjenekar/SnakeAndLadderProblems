using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    internal class SnakeandLadder_UC2
    {
        public static void SnakeLadderProg_Usecaase2()
        {
            Console.WriteLine("The Single Player Snake and Ladder Game has started ");
            Console.WriteLine("Player is at start Position 0");

            Random random = new Random();

            int diceroll = random.Next(1, 6);
            Console.WriteLine("The dice rolls " +  diceroll + " and the Player is at Position " + diceroll);
        }
    }
}
