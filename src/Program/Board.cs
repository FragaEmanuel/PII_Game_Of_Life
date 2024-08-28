using System;
using System.Collections;

namespace Ucu.Poo.GameOfLife;

public class Board
{
    private bool[,] board; //variable que representa el tablero
    
    public void SetValue(int i, int j, bool value) //añadir valor
    {
        board[i, j] = value;
    }
    
    public bool GetValue(int i, int j)              //pedir valor
    {
        return board[i,j];
    }

    public int Width()                              //metodo ancho
    {
        return board.GetLength(0);
    }
    
    public int Height()                             //metodo ancho
    {
        return board.GetLength(1);
    }

    public Board(int i, int j)                      //metodo constructor
    {
        board = new bool[i, j];
    }
}