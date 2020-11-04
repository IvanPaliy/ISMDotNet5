using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixLibrary
{
    public class MatrixWork
    {
        protected int[,] Matrix1;

        public MatrixWork (int rowCount, int colCount)
        {
            Matrix1 = new int[rowCount, colCount];
        }
        public void FillMatrix(int minValue = -100, int maxValue = 100)
        {
            Random rnd = new Random();
            for (int i = 0; i < Matrix1.GetLength(0); i++)
                for (int j = 0; j < Matrix1.GetLength(1); j++)
                    Matrix1[i, j] = rnd.Next(minValue, maxValue);
        }
        public int[,] GetMatrix()
        {
            return Matrix1;
        }
        public static int PositiveCount(MatrixWork Matrix1)
        {
            int[,] matr = Matrix1.GetMatrix();
            int positiveCount = 0;
            for (int i = 0; i < matr.GetLength(0); i++)
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (matr[i, j] > 0)
                    {
                        positiveCount++;
                    }
                }
            return positiveCount;
        }
        public static int GetSameMaxElement(MatrixWork Matrix1)

        {
            int[,] matr = Matrix1.GetMatrix();
            int counter;
            int result = int.MinValue;
            for (int y = 0; y < matr.GetLength(0); y++)
            { 
                for(int x = 0; x < matr.GetLength(1); x++)
                {
                    counter = 0;
                    for(int k = 0; k < matr.GetLength(1); k++)
                    {
                        if(k == x)
                            continue;
                        if (matr[y, x] == matr[y, k])
                            counter++;
                    }
                    for(int k = 0; k < matr.GetLength(0); k++)
                    {
                        if (k == x)
                            continue;
                        if (matr[y, x] == matr[k, x])
                            counter++;
                    }
                    if (counter > 0)
                        if (matr[y, x] > result)
                            result = matr[y, x];
                }
            }
            return result;
        }
        public static int CountStringsWithoutNull(MatrixWork Matrix1)
        {
            int[,] matr = Matrix1.GetMatrix();
            int stringsWithoutNull = matr.GetLength(0);
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (matr[i, j] == 0)
                    {
                        stringsWithoutNull--;
                        break;
                    }
                }    
            }
            return stringsWithoutNull;

        }
        public static int CountColumnsNoNull(MatrixWork Matrix1)
        {
            int[,] matr = Matrix1.GetMatrix();
            int nullcol = 0;
            for(int j = 0; j < matr.GetLength(1); j++)
            {
                for (int i = 0; i < matr.GetLength(0); i++)
                {
                    if (matr[i, j] == 0)
                    {
                        nullcol ++;
                        break;
                    }
                }
            }
            return nullcol;

        }
        public static int LongestSeriesElementsString(MatrixWork Matrix1)
        {
            int[,] matr = Matrix1.GetMatrix();
            int lineNum = -1;
            int maxCount = 0;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                int count = 0;
                for (int j = 0; j < matr.GetLength(1) - 1; j++)
                {
                    if (matr[i, j] != matr[i, j + 1])
                        continue;
                    count++;
                }
                if (maxCount >= count) continue;
                maxCount = count;
                lineNum = i;
            }
            return lineNum;

        }
        public static int ProductNonNullStrings(MatrixWork Matrix1)
        {
            int[,] matr = Matrix1.GetMatrix();
            int p = 1, temp = 1;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (matr[i, j] >= 0)
                    {
                        temp *= matr[i, j];
                    }
                    else
                    {
                        temp = 1;
                        break;
                    }
                }
                p *= temp;
            }
            return p;
        }
        
    }
}
