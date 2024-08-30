using System;
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
                pantalla = Logic.Avanzar(pantalla);
                Thread.Sleep(300);
            }
            ////Programa
            /// 1. leer el archivo
            /// 2. iniciar un while donde se actualiza el tablero en base a la logica e imprime continuamente
        }
    }
}
