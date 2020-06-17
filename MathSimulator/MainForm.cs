using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathSimulator
{
    public partial class MainForm : Form
    {
        readonly Addition add = new Addition();
        readonly Difference dif = new Difference();
        readonly Multiplication mul = new Multiplication();
        readonly Division div = new Division();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            
            
        }

        private void AdditionOfNumber(object sender, EventArgs e)
        {
            add.ShowDialog();
        }

        private void b_Diff_Click(object sender, EventArgs e)
        {
            dif.ShowDialog();
        }

        private void b_Mul_Click(object sender, EventArgs e)
        {
            mul.ShowDialog();
        }

        private void b_Div_Click(object sender, EventArgs e)
        {
            div.ShowDialog();
        }
    }
}
