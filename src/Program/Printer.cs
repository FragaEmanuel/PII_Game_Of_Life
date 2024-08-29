using System;
using System.Text;
namespace Ucu.Poo.GameOfLife;

public static class Printer
{
    public static void PrintBoard(bool[,] board)
    {
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);

        StringBuilder s = new StringBuilder();
        for (int y = 0; y < rows; y++)
        {
            for (int x = 0; x < cols; x++)
            {
                if (board[y, x])
                {
                    s.Append("|X|");
                }
                else
                {
                    s.Append("___");
                }
            }
            s.Append("\n");
        }
        Console.WriteLine(s.ToString());
    }
}
