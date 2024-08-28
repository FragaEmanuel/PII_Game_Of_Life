using System.IO;

namespace Ucu.Poo.GameOfLife;

public class FileReader
{
    string url = @"..\..\assets";
    string content = File.ReadAllText(url);
    string[] contentLines = content.Split('\n');
    private Board board = new Board[contentLines.Length, contentLines[0].Length];
    int height = board.Height;
    int width = board.Width;
        for (int i=0; i< width; i++)
     {
        for (int j=0; j< board.Height; j++)
        {
            if(board[i]=='1')
            {
                board[i,j]=true;
            }
        }
    }
}