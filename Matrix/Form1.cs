using MatrixLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatrixWork matrixWork = new MatrixWork(Convert.ToInt32(numericUpDownRowCount.Value), Convert.ToInt32(numericUpDown2ColCount.Value));
            matrixWork.FillMatrix();
            DataGridWork dataGridWork = new DataGridWork(DataGridViewMatrix);
            dataGridWork.Fill(matrixWork);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            MatrixWork matrixWork = new MatrixWork(Convert.ToInt32(numericUpDownRowCount.Value), Convert.ToInt32(numericUpDown2ColCount.Value));
            matrixWork.FillMatrix();
            DataGridWork dataGridWork = new DataGridWork(DataGridViewMatrix);
            dataGridWork.UpdateMatrix(matrixWork);
            labelPosetiveCount.Text = MatrixWork.PositiveCount(matrixWork).ToString();
            labelSameMaxElement.Text = MatrixWork.GetSameMaxElement(matrixWork).ToString();
            labelCountStringsWithoutNull.Text = MatrixWork.CountStringsWithoutNull(matrixWork).ToString();
            labelColmnsNoNull.Text = MatrixWork.CountColumnsNoNull(matrixWork).ToString();
            labelLongestSeriesElementsString.Text = MatrixWork.LongestSeriesElementsString(matrixWork).ToString();
            labelProductNonNullStrings.Text = MatrixWork.ProductNonNullStrings(matrixWork).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
