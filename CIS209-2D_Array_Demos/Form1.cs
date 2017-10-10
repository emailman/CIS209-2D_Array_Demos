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

            int[,] intSales = new int[sales.GetLength(0), sales.GetLength(1)];

            int sumJanuary = 0;
            int sumFebruary = 0;
            int sumMarch = 0;

            for (int i = 0; i < sales.GetLength(0); i++)
            {
                int sumRow = 0;

                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    intSales[i, j] = int.Parse(sales[i, j]);
                    sumRow += intSales[i, j];
                    switch (j)
                    {
                        
                        case 0:
                            sumJanuary += intSales[i, j];
                            break;
                        case 1:
                            sumFebruary += intSales[i, j];
                            break;
                        case 2:
                            sumMarch += intSales[i, j];
                            break;
                        default:
                            MessageBox.Show("OOPS");
                            break;
                    } 
                }

                switch(i)
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
            lblJanSum.Text = sumJanuary.ToString();
            lblFebSum.Text = sumFebruary.ToString();
            lblMarSum.Text = sumMarch.ToString();

            int sum = 0;
            foreach (int each in intSales)
                sum += each;
            lblTotalSales.Text = sum.ToString();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
