using System;
using System.Collections;

namespace Ucu.Poo.GameOfLife;

public class Board
{
    private bool[,] board;           //Variable que representa el tablero
    
    public void SetValue(int i, int j, bool value)  //Metodo para cambiar valor de la casilla [i,j]
    {
        board[i, j] = value;
    }
    
    public bool GetValue(int i, int j)              //Metodo para pedir valor
    {
        return board[i,j];
    }

    public int Width()                              //Metodo para pedir ancho
    {
        return board.GetLength(0);
    }
    
    public int Height()                             //Metodo para pedir altura
    {
        return board.GetLength(1);
    }

    public Board(int i, int j)                      //Metodo constructor
    {
        board = new bool[i, j];
    }
}