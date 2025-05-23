using System;
using System.Net.NetworkInformation;

class TicTacToe
{
    static void Main(string[] args)
    {
        const int ROWS = 3;
        const int COLS = 3;
        string[,] grid = new string[ROWS, COLS];
        string[] cellNumbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        int index = 0;
        Console.WriteLine("TicTacToe Board");
        for (int i = 0; i < ROWS; i++)
        {
            for (int j = 0; j < COLS; j++) 
            {
                grid[i, j] = cellNumbers[index];
                Console.Write(grid[i, j] + "_|");
                index++;
            }
            Console.WriteLine();
        }


    }

}