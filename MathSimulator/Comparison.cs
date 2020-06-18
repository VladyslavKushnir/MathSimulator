using System;
using System.Drawing;
using System.Windows.Forms;

namespace MathSimulator
{   
    public partial class Comparison : Form
    {
        // об'єкт класу з основними методами
        readonly MainMethods method = new MainMethods();
        // об'єкт класу рандом для випадкових чисел
        readonly Random rnd = new Random();
        // a - зменшуване
        // b - від'ємне
        // res - різниця
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
        private void AdditionLoad(object sender, EventArgs e)
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

        private void more_Click(object sender, EventArgs e)
        {
            user = 0;
            Check();
        }

        private void equally_Click(object sender, EventArgs e)
        {
            user = 2;
            Check();
        }

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

        private void less_Click(object sender, EventArgs e)
        {
            user = 1;
            Check();
        }

        void Check() 
        {
            if (res == user)
            {
                InformationOutput.Text = "Відповідь вірна!";
                Generation();
                
            }
            else
            {
                InformationOutput.Text = "Спробуй ще раз!";
            }
        }
       
        /// <summary>
        /// Генерація чисел
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
