using System.IO;

namespace Ucu.Poo.GameOfLife;

public class FileReader
{
    string url = @"..\..\assets";

    public Board Return()
    {
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
        bool[,] archivo = new bool[contentLines.Length, contentLines[0].Length];
        Board board = new Board(contentLines.Length, contentLines[0].Length);

        for (int i = 0; i < contentLines.Length; i++)
        {
            for (int j = 0; j < contentLines[0].Length; j++)
            {
                if ((archivo(i,j)) == '1')
                {
                    board.SetValue(i,j,true);
                }
                else
                {
                    board.SetValue(i,j,false);
                }
            }
        }

        return board;
    }
}