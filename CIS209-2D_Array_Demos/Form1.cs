using System;
using System.Windows.Forms;

namespace CIS209_2D_Array_Demos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcTotals_Click(object sender, EventArgs e)
        {

            string [,] sales = { { tbx1J.Text, tbx1F.Text, tbx1M.Text},
                                { tbx2J.Text, tbx2F.Text, tbx2M.Text}  };

            // Create an int array the same size as the string array
            int[,] intSales = new int[sales.GetLength(0), sales.GetLength(1)];

            clearTotals();

            try
            {
                // Copy all the elements from the string array to the int array
                for (int i = 0; i < sales.GetLength(0); i++)
                    for (int j = 0; j < sales.GetLength(1); j++)
                        intSales[i, j] = int.Parse(sales[i, j]);

                // Calculate and display the sum of the rows
                sumRows(intSales);

                // Calculate and display the sum of the columns
                sumColumns(intSales);

                // Calculate and display the grand total
                int sum = 0;
                foreach (int each in intSales)
                    sum += each;
                lblTotalSales.Text = sum.ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Cell is empty or non-numeric", "Data Entry Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearTotals()
        {
            lblJanSum.Text = "";
            lblFebSum.Text = "";
            lblMarSum.Text = "";
            lblItem1Sum.Text = "";
            lblItem2Sum.Text = "";
            lblTotalSales.Text = "";
        }

        private void sumRows(int[,] sales)
        {
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                int sumRow = 0;

                for (int j = 0; j < sales.GetLength(1); j++)
                    sumRow += sales[i, j];

                // Put the calculated sum in the correct row
                switch (i)
                {
                    case 0:
                        lblItem1Sum.Text = sumRow.ToString();
                        break;
                    case 1:
                        lblItem2Sum.Text = sumRow.ToString();
                        break;
                    default:
                        MessageBox.Show("OOPS");
                        break;
                }
            }
        }

        private void sumColumns(int[,] sales)
        {
            for (int j = 0; j < sales.GetLength(1); j++)
            {
                int sumColumn = 0;

                for (int i = 0; i < sales.GetLength(0); i++)
                    sumColumn += sales[i, j];

                // Put the calculated sum in the correct column
                switch (j)
                {
                    case 0:
                        lblJanSum.Text = sumColumn.ToString();
                        break;
                    case 1:
                        lblFebSum.Text = sumColumn.ToString();
                        break;
                    case 2:
                        lblMarSum.Text = sumColumn.ToString();
                        break;
                    default:
                        MessageBox.Show("OOPS");
                        break;
                }
            }
        }
    }
}
