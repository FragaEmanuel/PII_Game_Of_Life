using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main()              //inicia el programa
        {
            FileReader fileReader = new FileReader();       //crea un objeto de la clase FileReader
            Board pantalla = fileReader.Return();           //invoca el metodo para carga el archivo board.txt
            while (true)
            {
                System.Console.Clear();                     //limpia la consola
                Printer.PrintBoard(pantalla);               //imprime el tablero
                pantalla = Logic.Avanzar(pantalla);         //cambia el tablero a la sigiente generacion
                Thread.Sleep(300);          //delay de 300 milisegundos
            }
        }
    }
}
