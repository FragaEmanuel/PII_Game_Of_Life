using System;
using System.Text;

namespace Ucu.Poo.GameOfLife
{
    public static class Printer
    {
        public static void PrintBoard(Board board)
        {
            // Obtiene el número de filas y columnas del tablero
            int filas = board.Height(); 
            int columnas = board.Width(); 

            StringBuilder s = new StringBuilder(); // Crea una instancia de StringBuilder para construir la salida en texto

            // Itera sobre cada fila
            for (int x = 0; x < filas-1; x++)
            {
                // Itera sobre cada columna
                for (int y = 0; y < columnas-1; y++)
                {
                    if (board.GetValue(x, y)) // Asegúrate de que GetValue toma (x, y) si la convención es (columna, fila)
                    {
                        s.Append("|X|"); // Representa una célula viva
                    }
                    else
                    {
                        s.Append("___"); // Representa una célula muerta
                    }
                }
                s.Append("\n"); // Añade un salto de línea al final de cada fila
            }

            Console.WriteLine(s.ToString()); // Imprime la cadena construida
        }
    }
}