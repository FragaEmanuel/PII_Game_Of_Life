using System;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main()
        {
            //FileReader fileReader = new FileReader();
            //Board pantalla = fileReader.Return();
            Board pantalla = new Board(2,2);
            pantalla.SetValue(1,1,true);
            pantalla.SetValue(1,2,false);
            pantalla.SetValue(2,1,false);
            pantalla.SetValue(2,2,true);
            
            Printer.PrintBoard(pantalla);
            while (true)
            {
                Printer.PrintBoard(pantalla);
                //pantalla = Logic.Avanzar(pantalla);
                //Thread.Sleep(300);
            }
            ////Programa
            /// 1. leer el archivo
            /// 2. iniciar un while donde se actualiza el tablero en base a la logica e imprime continuamente
        }
    }
}
