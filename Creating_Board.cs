using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    public class Creating_Board
        {

            
          char[] gameBoard = new char[10];

        public void createGameBoard()
            {

                for (int a = 1; a < gameBoard.Length; a++)
                {
                    gameBoard[a] = ' ';
                }

                Console.WriteLine("  " + gameBoard[1] + " | " + gameBoard[2] + " | " + gameBoard[3] + "  ");
                Console.WriteLine("----|---|----");
                Console.WriteLine("  " + gameBoard[4] + " | " + gameBoard[5] + " | " + gameBoard[6] + "  ");
                Console.WriteLine("----|---|----");
                Console.WriteLine("  " + gameBoard[7] + " | " + gameBoard[8] + " | " + gameBoard[9] + "  ");
        }
    }
}


