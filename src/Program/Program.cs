using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main()
        {
            FileReader fileReader = new FileReader();
            Board pantalla = fileReader.Return();
            while (true)
            {
                System.Console.Clear();
                Printer.PrintBoard(pantalla);
                Logic.Avanzar(pantalla);
                Thread.Sleep(300);
                System.Console.Clear();
            }
        }
    }
}
