using Ucu.Poo.GameOfLife;
using System;

public class Logic
{
    public Board Avanzar(Board gameBoard)
    {
        int boardWidth = gameBoard.Width();
        int boardHeight = gameBoard.Height();

        Board cloneboard = new Board(boardWidth,boardHeight);
        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0;
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && gameBoard.GetValue(i, j))
                        {
                            aliveNeighbors++;
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

        gameBoard = cloneboard;
        return gameBoard;
    }
}