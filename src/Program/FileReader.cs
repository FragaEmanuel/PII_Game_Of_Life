using System.IO;

namespace Ucu.Poo.GameOfLife;

public class FileReader
{
    string url = @"..\..\..\..\Library\board.txt";          //Ruta del archivo a cargar

    public Board Return()           //Metodo para cargar el archivo
    {
        string content = File.ReadAllText(url);             //Crea un string con el contenido del archivo
        string[] contentLines = content.Split('\n');            //Lo divide en renglones
        Board board = new Board(contentLines.Length, contentLines[0].Length);           //Crea un objeto Board del tamaño del archivo

        for (int i = 0; i < contentLines.Length-1; i++)         //For que recorre las filas
        {
            for (int j = 0; j < contentLines[0].Length-1; j++)      //For que recorre las columnas
            {
                if (contentLines[i][j] == '1')                  //Revisa el contenido de la casilla y lo traduce a board
                {
                    board.SetValue(i,j,true);                   
                }
                else
                {
                    board.SetValue(i,j,false);
                }
            }
        }

        return board;                       //devuelve el tablero con los valores booleanos cargados
    }
}