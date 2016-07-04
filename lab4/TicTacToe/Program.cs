using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame game = new TicTacToeGame();
            bool turn = false;
            char check;
            while (true)
            {
                Console.Clear();
                game.DisplayBoard();
                Console.WriteLine("Select a specific cell by is number");
                char player;
                if (!turn)
                {
                    Console.WriteLine("it's O turn");
                    player = 'O';
                }
                else
                {
                    Console.WriteLine("it's X turn");
                    player = 'X';
                }
                
                string s=Console.ReadLine();
                int i;
                if (!(int.TryParse(s, out i))|| i<1 || i>9)
                {
                    Console.WriteLine("Wrong input, Enter number between 1-9");
                    continue;
                }

                check = game.Move(i, player);

                if (check == 'W')
                {
                    Console.WriteLine("Try another cell, only nambered cells are empty");
                    continue;
                }

                if (check == 'C')
                {
                    turn = !turn;
                    continue;
                }

                break;
            }
            Console.WriteLine();
            game.DisplayBoard();
            if (check=='O')
                Console.WriteLine("O WIN");
            else if (check == 'X')
                Console.WriteLine("X WIN");
                 else
                Console.WriteLine("It's a draw");

        }
    }
}
