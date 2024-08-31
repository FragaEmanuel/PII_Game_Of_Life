using Ucu.Poo.GameOfLife;

public class Logic
{
    public static Board Avanzar(Board gameBoard)            //Metodo para generar la siguiente generacion
    {
        Board cloneboard = new Board(gameBoard.Width(),gameBoard.Height());     //Crea un segundo Board para guardar la siguiente generacion
        for (int x = 0; x < gameBoard.Width()-1; x++)           //For que recorre las filas
        {
            for (int y = 0; y < gameBoard.Height()-1; y++)          //For que recorre las columnas
            {
                int aliveNeighbors = 0;         //establece/reincia el número de celulas vecinas
                for (int i = x - 1; i <= x + 1; i++)            //revisa los alrededores de la celula
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i >= 0 && i < gameBoard.Width() && j >= 0 && j < gameBoard.Height() && gameBoard.GetValue(i, j))        //Se fija si tiene vecinos y los suma
                        {
                            aliveNeighbors++;       //Suma si hay vecinos
                        }
                    }
                }

                if (gameBoard.GetValue(x, y))
                {
                    aliveNeighbors--;
                }

                if (gameBoard.GetValue(x, y) && aliveNeighbors < 2)
                {
                    //Celula muere por baja población
                    cloneboard.SetValue(x, y, false);
                }
                else if (gameBoard.GetValue(x, y) && aliveNeighbors > 3)
                {
                    //Celula muere por sobrepoblación
                    cloneboard.SetValue(x,y, false);
                }
                else if (!gameBoard.GetValue(x, y) && aliveNeighbors == 3)
                {
                    //Celula nace por reproducción
                    cloneboard.SetValue(x, y, true);
                }
                else
                {
                    //Celula mantiene el estado que tenía
                     cloneboard.SetValue(x, y, gameBoard.GetValue(x, y));
                }
            }
        }

        gameBoard = cloneboard;         //Remplaza el tablero por el nuevo
        return gameBoard;               //Devuelve el tablero actualizado
    }
}