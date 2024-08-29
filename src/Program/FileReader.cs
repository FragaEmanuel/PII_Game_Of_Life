using System.IO;

namespace Ucu.Poo.GameOfLife;

public class FileReader
{
    string url = @"..\..\assets";

    public Board Return()
    {
    string content = File.ReadAllText(url);
    string[] contentLines = content.Split('\n');
    Board board = new Board[contentLines.Length, contentLines[0].Length];
        
    for (int i=0; i< contentLines.Length; i++)
    {
        for (int j=0; j< contentLines[0].Length; j++)
        {
            if(board[i]=='1')
            {
                board[i,j]=true;
            }
        }
    }
    }     
}   