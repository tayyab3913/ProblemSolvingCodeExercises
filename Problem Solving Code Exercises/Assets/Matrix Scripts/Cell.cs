using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell
{
    private int rowNumber;
    private int colNumber;
    private Status status = Status.none;

    public delegate void OnStatusUpdate(Status status);
    public event OnStatusUpdate onStatusUpdate;

    void InitializeCell()
    {
        this.status = Status.none;
        rowNumber = 0;
        colNumber = 0;
    }
    public Cell()
    {
        InitializeCell();
    }

    public Cell(int row, int col)
    {
        this.status = Status.none;
        rowNumber = row;
        colNumber = col;
    }

    public void SetStatus(Status tempStatus)
    {
        this.status = tempStatus;
        Debug.Log((int)tempStatus);
        onStatusUpdate.Invoke(tempStatus);
    }

    public Status GetStatus()
    {
        return status;
    }

    public enum Status { none, cross, circle, win, loose}
}
