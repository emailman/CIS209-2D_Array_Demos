using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string[,] sales = { { tbx1J.Text, tbx1F.Text, tbx1M.Text},
                                { tbx2J.Text, tbx2F.Text, tbx2M.Text}  };
            foreach (string each in sales)
                Console.WriteLine(each);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
