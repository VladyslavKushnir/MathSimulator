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
        Addition add = new Addition();
        Difference dif = new Difference();
       
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
    }
}
