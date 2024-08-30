using System.IO;

namespace Ucu.Poo.GameOfLife;

public class FileReader
{
    string url = @"..\..\..\..\Library\board.txt";

    public Board Return()
    {
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
        Board board = new Board(contentLines.Length, contentLines[0].Length);

        for (int i = 0; i < contentLines.Length-1; i++)
        {
            for (int j = 0; j < contentLines[0].Length-1; j++)
            {
                if (contentLines[i][j] == '1') 
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