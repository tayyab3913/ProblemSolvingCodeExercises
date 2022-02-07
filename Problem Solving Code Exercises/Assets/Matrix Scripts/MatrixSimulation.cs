using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixSimulation : MonoBehaviour
{
    void Start()
    {
        Matrix Hussain = new Matrix();
        Matrix matrix1, matrix2;
        matrix1 = new Matrix(4, 2);
        matrix2 = new Matrix(4, 2);
        float[,] tempArray1 =
        {
            {1, 2 },
            {3, 4 },
            {5, 6 },
            {7, 8 }
        };
        float[,] tempArray2 =
        {
            {8, 9 },
            {10, 11 },
            {12, 13 },
            {14, 15 }
        };
        Matrix matrix5 = new Matrix(tempArray1);
        matrix1.SetMatrix(tempArray1);
        //Debug.Log("Row Length: " + matrix1.GetRowLength());
        matrix1.AddCol(new float[] {9, 8, 7, 10 });
        //Debug.Log("Row Length: " + matrix1.GetRowLength());
        //matrix1.SwapCols(0, 1);
        matrix1.PrintMatrix();

        matrix2.SetMatrix(tempArray2);
        matrix2.AddCol(new float[] { 9, 8, 7, 10 });
        matrix2.PrintMatrix();

        Matrix matrix3 = matrix1.AddMatrix(matrix2);
        matrix3.PrintMatrix();
    }
}
