using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static public void Main(String[] args)
        {
            {
                Creating_Board obj = new Creating_Board();
                Console.WriteLine("***************WELCOME TO TIC-TAC-TOE GAME***************");
                obj.createGameBoard();


                UC2ChoosingLetter choosing_Letter = new UC2ChoosingLetter();
                choosing_Letter.CreateGameBoard();
                choosing_Letter.selectLetter();

                

                UC3Showing_Board obj2 = new UC3Showing_Board();
                obj2.CreateGameBoard();
                obj2.selectLetter();
                obj2.showBoard();


            }
        }
    }
}





