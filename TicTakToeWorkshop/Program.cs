using System;

namespace TicTakToeWorkshop
{
    class Program
    {
		static void Main(string[] args)
		{
			char[] creatBoard()
			{
				char board[] = new char[10];
				for (int i = 1; i < board.length; i++)
				{
					board[i] = ' ';
				}
				return board;
			}


			Console.WriteLine("Tic Tak Toe Game");//Welcome message
			TicTacToeWorkshop boardobj = new TicTacToeWorkshop();//object creation
			boardobj.creatBoard();
			Console.WriteLine("Tic Tak Toe Game");
		}
    }
}
