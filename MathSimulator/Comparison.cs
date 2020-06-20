using System;
using System.Drawing;
using System.Windows.Forms;

namespace MathSimulator
{
    /// <summary>
    /// Клас - Comparison - порівняння чисел
    /// </summary>
    public partial class Comparison : Form
    {
        // об'єкт класу з основними методами
        readonly MainMethods method = new MainMethods();
        // об'єкт класу рандом для випадкових чисел
        readonly Random rnd = new Random();
        // a - число 1
        // b - число 2
        // res - результат
        // user - вибір користувача
        int a, b, res, user;
        /// <summary>
        /// Ініціалізація компонентів
        /// </summary>
        public Comparison()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод завантаження форми
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComparisonLoad(object sender, EventArgs e)
        {
            Generation();
            InformationOutput.Text = "";
        }
        /// <summary>
        /// Метод очищення інформаційного повідомлення
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearInformation(object sender, EventArgs e)
        {
            InformationOutput.Text = "";
        }
        /// <summary>
        /// Якщо А більше Б
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void more_Click(object sender, EventArgs e)
        {
            user = 0;
            Check();
        }
        /// <summary>
        /// Якщо А дорівнює Б
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equally_Click(object sender, EventArgs e)
        {
            user = 2;
            Check();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void more_MouseMove(object sender, MouseEventArgs e)
        {
            label_res.Text = ">";
        }
        private void more_MouseLeave(object sender, EventArgs e)
        {
            label_res.Text = "";
        }
        private void equally_MouseHover(object sender, EventArgs e)
        {
            label_res.Text = "=";
        }
        private void equally_MouseLeave(object sender, EventArgs e)
        {
            label_res.Text = "";
        }
        private void less_MouseHover(object sender, EventArgs e)
        {
            label_res.Text = "<";
        }
        private void less_MouseLeave(object sender, EventArgs e)
        {
            label_res.Text = "";
        }
        /// <summary>
        /// Якщо А менше Б
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void less_Click(object sender, EventArgs e)
        {
            user = 1;
            Check();
        }
        /// <summary>
        /// Перевірка правильності порівняння
        /// </summary>
        void Check() 
        {
            if (res == user)
            {
                InformationOutput.ForeColor = Color.FromArgb(0, 192, 0);
                InformationOutput.Text = "Відповідь вірна!";
                Generation();
                
            }
            else
            {
                InformationOutput.ForeColor = Color.FromArgb(0, 0, 192);
                InformationOutput.Text = "Спробуй ще раз!";
            }
        }
        /// <summary>
        /// Генерація чисел та їх порівняння
        /// </summary>
        public void Generation()
        {
            a = rnd.Next(0, 101);
            b = rnd.Next(0, 101);
            diff_string.Text = a.ToString() + "  \t   \t   \t  " + b.ToString();
            res = method.Comparsion(a,b);
        }
    }
}
