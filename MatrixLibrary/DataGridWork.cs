using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixLibrary
{
    public class DataGridWork
    {
        protected DataGridView DataGrid;
        public DataGridWork(DataGridView dataGrid)
        {
            DataGrid = dataGrid;
        }
        public void Initialize(int rowCount, int colCount)
        {
            DataGrid.RowCount = rowCount;
            DataGrid.ColumnCount = colCount;
            for (int i = 0; i < DataGrid.ColumnCount; i++)
                DataGrid.Columns[i].Width = 50;
        }
        public void NumerateRowAndColumns()
        {
            for (int i = 0; i < DataGrid.ColumnCount; i++)
                DataGrid.Columns[i].HeaderText = i.ToString();
            for (int j = 0; j < DataGrid.RowCount; j++)
                DataGrid.Rows[j].HeaderCell.Value = j.ToString();
            DataGrid.RowHeadersWidth = 60;

        }
        public void Fill(MatrixWork matrix)
        {
            int[,] Matrix1 = matrix.GetMatrix();
            Initialize(Matrix1.GetLength(0), Matrix1.GetLength(1));
            NumerateRowAndColumns();
            for (int i = 0; i < Matrix1.GetLength(0); i++) 
                for (int j = 0; j < Matrix1.GetLength(1); j++)
            DataGrid[j, i].Value = Matrix1[i, j];

        }
        public void UpdateMatrix(MatrixWork matrix)
        {
            int[,] matr = matrix.GetMatrix();
            for (int i = 0; i < matr.GetLength(0); i++)
                for (int j = 0; j < matr.GetLength(1); j++)
                    matr[j, i] = int.Parse(DataGrid[i, j].Value.ToString());
        }
    }
}
