using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matrix
{
    private int numOfRows;
    private int numOfCols;
    private int rowLength;
    private int colLength;

    List<List<float>> matrixData;

    void InitializeMatrix()
    {
        matrixData = new List<List<float>>();
    }

    public Matrix()
    {
        InitializeMatrix();
    }

    public Matrix(int rows, int cols)
    {
        numOfRows = rows;
        numOfCols = cols;
        rowLength = numOfCols;
        colLength = numOfRows;
        InitializeMatrix();
        for (int x = 0; x < GetNoOfRows(); x++)
        {
            matrixData.Add(new List<float>());
            for (int y = 0; y < GetNoOfColumns(); y++)
            {
                matrixData[x].Add(0);
                //Debug.Log("Value added at: " + matrixData[x][y]);
            }
        }
        //Debug.Log("Matrix Rows: " + matrixData.Count + " Matrix Cols: " + matrixData[0].Count);
    }

    public Matrix(float[,] array)
    {
        numOfRows = array.GetLength(0);
        numOfCols = array.GetLength(1);
        rowLength = numOfCols;
        colLength = numOfRows;
        InitializeMatrix();
        for (int x = 0; x < array.GetLength(0); x++)
        {
            matrixData.Add(new List<float>());
            for (int y = 0; y < array.GetLength(1); y++)
            {
                matrixData[x].Add(array[x, y]);
            }
        }
    }

    public int GetRowLength()
    {
        return rowLength;
    }

    public int GetColumnLength()
    {
        return colLength;
    }

    public int GetNoOfColumns()
    {
        return numOfCols;
    }

    public int GetNoOfRows()
    {
        return numOfRows;
    }

    public void SetMatrix(float[,] array)
    {
        for (int x = 0; x < array.GetLength(0); x++)
        {
            for (int y = 0; y < array.GetLength(1); y++)
            {
                matrixData[x][y] = array[x, y];
            }
        }
    }

    public void PrintMatrix()
    {
        string matrixToPrint = "";
        for (int x = 0; x < matrixData.Count; x++)
        {
            for (int y = 0; y < matrixData[x].Count; y++)
            {
                matrixToPrint += matrixData[x][y] + "  ";
            }
            matrixToPrint += "\n";
        }
        Debug.Log(matrixToPrint);
    }

    public void SetValue(int row, int col, float value)
    {
        if (col < GetNoOfColumns() && row < GetNoOfRows())
        {
            matrixData[row][col] = value;
        }
        else
        {
            Debug.Log("Index out of bounds");
        }
    }

    public float GetValue(int row, int col)
    {
        if (col < GetNoOfColumns() && row < GetNoOfRows())
        {
            return matrixData[row][col];
        }
        else
        {
            Debug.Log("Index out of bounds");
            return 0;
        }
    }

    public void SetRow(int row, float[] array)
    {
        if (row < GetNoOfRows())
        {
            for (int x = 0; x < array.Length; x++)
            {
                matrixData[row][x] = array[x];
            }
        }
        else
        {
            Debug.Log("Index out of bounds");
        }
    }

    public void AddRow(float[] array)
    {
        matrixData.Add(new List<float>());
        for (int x = 0; x < array.Length; x++)
        {
            matrixData[matrixData.Count][x] = array[x];
        }
        numOfRows++;
        colLength++;
    }

    public void SetCol(int col, float[] array)
    {
        if (col < GetNoOfColumns())
        {
            for (int x = 0; x < array.Length; x++)
            {
                matrixData[x][col] = array[x];
            }
        }
        else
        {
            Debug.Log("Index out of bounds");
        }
    }

    public void AddCol(float[] array)
    {
        for (int x = 0; x < array.Length; x++)
        {
            matrixData[x].Add(array[x]);
        }
        numOfCols++;
        rowLength++;
    }

    public void SwapRows(int row1, int row2)
    {
        if (row1 > GetNoOfColumns() || row2 > GetNoOfRows() || row1 != row2)
        {
            Debug.Log("Index out of bound or row sizes not same");
            return;
        }
        float[] array1 = new float[matrixData[row1].Count];
        float[] array2 = new float[matrixData[row2].Count];
        for (int x = 0; x < matrixData[row1].Count; x++)
        {
            array1[x] = matrixData[row1][x];
        }
        for (int x = 0; x < matrixData[row2].Count; x++)
        {
            array2[x] = matrixData[row2][x];
        }
        for (int x = 0; x < matrixData[row1].Count; x++)
        {
            matrixData[row1][x] = array2[x];
        }
        for (int x = 0; x < matrixData[row2].Count; x++)
        {
            matrixData[row2][x] = array1[x];
        }
    }

    public void SwapCols(int col1, int col2)
    {
        if (col1 > GetNoOfColumns() || col2 > GetNoOfColumns() || col1 != col2)
        {
            Debug.Log("Index out of bound or col sizes not same");
            return;
        }
        float[] array1 = new float[matrixData.Count];
        float[] array2 = new float[matrixData.Count];
        for (int x = 0; x < matrixData.Count; x++)
        {
            array1[x] = matrixData[x][col1];
        }
        for (int x = 0; x < matrixData.Count; x++)
        {
            array2[x] = matrixData[x][col2];
        }
        for (int x = 0; x < matrixData.Count; x++)
        {
            matrixData[x][col1] = array2[x];
        }
        for (int x = 0; x < matrixData.Count; x++)
        {
            matrixData[x][col2] = array1[x];
        }
    }

    public Matrix AddMatrix(Matrix matrixToAdd)
    {
        if (GetRowLength() != matrixToAdd.GetRowLength() || GetColumnLength() != matrixToAdd.GetColumnLength())
        {
            Debug.Log("Matric sizes different");
            return new Matrix();
        }
        Matrix tempMatrix = new Matrix(GetColumnLength(), GetRowLength());
        for (int x = 0; x < GetColumnLength(); x++)
        {
            for (int y = 0; y < GetRowLength(); y++)
            {
                tempMatrix.SetValue(x, y, matrixData[x][y] + matrixToAdd.GetValue(x, y));
            }
        }
        return tempMatrix;
    }

    public Matrix SubtractMatrix(Matrix matrixToAdd)
    {
        if (matrixData.Count != matrixData.Count)
        {
            Debug.Log("Matric sizes different");
            return new Matrix();
        }
        Matrix tempMatrix = new Matrix(matrixData.Count, matrixData[0].Count);
        for (int x = 0; x < matrixData.Count; x++)
        {
            for (int y = 0; y < matrixData[0].Count; y++)
            {
                tempMatrix.SetValue(x, y, matrixData[x][y] - matrixToAdd.GetValue(x, y));
            }
        }
        return tempMatrix;
    }

    public void SetMatrix(float number)
    {
        for (int x = 0; x < GetNoOfRows(); x++)
        {
            matrixData.Add(new List<float>());
            for (int y = 0; y < GetNoOfColumns(); y++)
            {
                matrixData[x][y] = number;
                //Debug.Log("Value added at: " + matrixData[x][y]);
            }
        }
    }

    public void SetRow(int row, float number)
    {
        if (row > GetNoOfRows()) return;
        for (int y = 0; y < GetNoOfColumns(); y++)
        {
            matrixData[row][y] = number;
            //Debug.Log("Value added at: " + matrixData[x][y]);
        }
    }

    public float[] GetRow(int row)
    {
        if (row > GetNoOfRows()) return new float[0];
        float[] tempArray = new float[GetNoOfRows()];
        for (int y = 0; y < GetNoOfColumns(); y++)
        {
            tempArray[y] = matrixData[row][y];
            //Debug.Log("Value added at: " + matrixData[x][y]);
        }
        return tempArray;
    }

    public void SetColumn(int col, float number)
    {
        if (col > GetNoOfColumns()) return;
            for (int y = 0; y < GetNoOfColumns(); y++)
            {
                matrixData[y][col] = number;
                //Debug.Log("Value added at: " + matrixData[x][y]);
            }
    }

    public float[] GetColumn(int col)
    {
        if (col > GetNoOfColumns()) return new float[0];
        float[] tempArray = new float[GetNoOfColumns()];
        for (int y = 0; y < GetNoOfColumns(); y++)
        {
            tempArray[y] = matrixData[y][col];
            //Debug.Log("Value added at: " + matrixData[x][y]);
        }
        return tempArray;
    }
}
