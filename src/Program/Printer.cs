namespace Ucu.Poo.GameOfLife;

using System; // Importa el espacio de nombres System, que contiene clases básicas como Console.
using System.Text; // Importa el espacio de nombres System.Text, que contiene la clase StringBuilder.
    public static class Printer // Declara una clase estática llamada Printer.
    {
        public static void PrintBoard(Board board) // Declara un método público y estático llamado PrintBoard que toma una matriz bidimensional de booleanos como parámetro.
        {
            int filas = board.Width(); // Obtiene el número de filas de la matriz y lo almacena en la variable rows.
            int columnas = board.Height(); // Obtiene el número de columnas de la matriz y lo almacena en la variable cols.

            StringBuilder s = new StringBuilder(); // Crea una nueva instancia de StringBuilder para construir la cadena de salida.
            for (int y = 0; y < filas; y++) // Itera sobre cada fila de la matriz.
            {
                for (int x = 0; x < columnas; x++) // Itera sobre cada columna de la matriz.
                {
                    if (board.GetValue(y,x)) // Si la célula en la posición (y, x) está viva (true).
                    {
                        s.Append("|X|"); // Añade "|X|" a la cadena de salida para representar una célula viva.
                    }
                    else // Si la célula en la posición (y, x) está muerta (false).
                    {
                        s.Append("___"); // Añade "___" a la cadena de salida para representar una célula muerta.
                    }
                }
                s.Append("\n"); // Añade un salto de línea al final de cada fila.
            }
            Console.WriteLine(s.ToString()); // Imprime la cadena de salida construida en la consola.
        }
    }
