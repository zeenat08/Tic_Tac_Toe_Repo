using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class UC2ChoosingLetter
    {
         //declare 1d array of char type

        char[] gameBoard = new char[10];

        char Computerletter;
        char Playerletter;

        //method for creating empty GameBoard
        public void CreateGameBoard()
        {
            for (int a = 1; a < gameBoard.Length; a++)
            {
                gameBoard[a] = ' ';
            }
        }

        //method for choose Letter X or O
        public void selectLetter()
        {
            Console.WriteLine("\nChoose your Letter\nPress 1 For-> 'X'\nPress 2 For -> 'O'\nEnter your Choice -> ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Playerletter = 'X';
                Computerletter = 'O';
                Console.WriteLine("\nPlayer letter -> " + Playerletter);
                Console.WriteLine("Computer letter -> " + Computerletter);
            }
            else if (choice == 2)
            {
                Playerletter = 'O';
                Computerletter = 'X';
                Console.WriteLine("\nPlayer letter -> " + Playerletter);
                Console.WriteLine("Computer letter -> " + Computerletter);
            }
            else
            {
                Console.WriteLine("\n>>>>>>> plz enter 1 or 2 <<<<<<<<<");
            }
        }
    }
}
    
