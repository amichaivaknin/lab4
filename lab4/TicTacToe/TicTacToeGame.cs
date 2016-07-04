using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToeGame
    {
        char[,] board = new char[3,3] {  {'1', '2', '3'},
                                         {'4', '5', '6'},
                                         {'7', '8','9'}};

        private int cnt=9;

        public void DisplayBoard()
        {
            for (int i = 0; i < 3; i++)
            { 
                Console.Write("|");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i,j]+"|");
                }
                Console.WriteLine();
                Console.WriteLine("|_|_|_|");
            }
        }

        public char Move(int k, char p)
        {
            int i = (k - 1)/3;
            int j = (k - 1)%3;

            if (board[i, j] == 'X' || board[i, j] == 'O')
            {
                return 'W';
            }

            board[i, j] = p;
            cnt--;
            p = CheckWin();
            return p;
        }

        private char CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return board[i, 0];//rows

                if (board[0, i] == board[1,i] && board[1, i] == board[2, i])
                    return board[0, i];//columns
            }

            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return board[0, 0];//diagonal1

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return board[0, 2];//diagonal2

            if (cnt == 0)
                return 'T';//draw

            return 'C';
        }

}
}