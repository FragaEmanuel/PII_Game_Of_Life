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
                Printer.PrintBoard(pantalla);
                Logic.Avanzar(pantalla);
                Thread.Sleep(3000);
                System.Console.Clear();
            }
        }
    }
}
