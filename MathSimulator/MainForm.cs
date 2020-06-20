using System;
using System.Windows.Forms;

namespace MathSimulator
{
    public partial class MainForm : Form
    {
        // об'єкт класу Addition
        readonly Addition add = new Addition();
        // об'єкт класу Difference
        readonly Difference dif = new Difference();
        // об'єкт класу Multiplication 
        readonly Multiplication mul = new Multiplication();
        // об'єкт класу Division
        readonly Division div = new Division();
        // об'єкт класу Comparison
        readonly Comparison comp = new Comparison();
        // об'єкт класу Composition
        readonly Composition compos = new Composition();
        /// <summary>
        /// Ініціалізація компонентів
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Відкрити форму з додаванням чисел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdditionOfNumber(object sender, EventArgs e)
        {
            add.ShowDialog();
        }
        /// <summary>
        /// Відкрити форму з ріщницею чисел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_Diff_Click(object sender, EventArgs e)
        {
            dif.ShowDialog();
        }
        /// <summary>
        /// Відкрити форму з добутком чисел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_Mul_Click(object sender, EventArgs e)
        {
            mul.ShowDialog();
        }
        /// <summary>
        /// Відкрити форму з часткою чисел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_Div_Click(object sender, EventArgs e)
        {
            div.ShowDialog();
        }
        /// <summary>
        /// Відкрити форму з порівнянням чисел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_Comp_Click(object sender, EventArgs e)
        {
            comp.ShowDialog();
        }
        /// <summary>
        /// Відкрити форму з складом чисел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_Compos_Click(object sender, EventArgs e)
        {
            compos.ShowDialog();
        }
    }
}
