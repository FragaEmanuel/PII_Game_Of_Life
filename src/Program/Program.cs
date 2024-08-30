using System;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader fileReader = new FileReader(); // Crea una instancia de FileReader.
            bool[,] board = fileReader.Return(); // Lee el archivo y obtiene la matriz de booleanos.

            while (true)
            {
                Console.Clear();
                Printer.PrintBoard(board); // Imprime el tablero en la consola.
                board = GameLogic.ProcessNextGeneration(board); // Calcula la siguiente generación del tablero.
                Thread.Sleep(300); // Pausa para ver el cambio.
            }
        }
    }
}
