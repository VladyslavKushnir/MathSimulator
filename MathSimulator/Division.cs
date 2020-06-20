using System;
using System.Windows.Forms;

namespace MathSimulator
{   
    public partial class Division : Form
    {
        // об'єкт класу з основними методами
        readonly MainMethods method = new MainMethods();
        // об'єкт класу рандом для випадкових чисел
        readonly Random rnd = new Random();
        // a - ділене
        // b - дільник
        // res - частка
        int a, b, res;
        /// <summary>
        /// Ініціалізація компонентів
        /// </summary>
        public Division()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод завантаження форми
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DivisionLoad(object sender, EventArgs e)
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
        /// Перевірка правильності обчислень
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void СalculationСheck(object sender, EventArgs e)
        {
            if (result.Text != "")
            {
                if (result.Text == res.ToString())
                {   InformationOutput.Text = "Відповідь вірна!";
                    result.Text = "";
                    Generation();
                }
                else 
                {   InformationOutput.Text = "Спробуй ще раз!";
                    result.Text = "";
                };
            }
            else
            {
                InformationOutput.Text = "Заповніть поле";
            }
        }
        /// <summary>
        /// Генерація чисел та розрахунок частки
        /// </summary>
        public void Generation()
        {
            b = rnd.Next(2, 11);
            int temporaryQuotient = rnd.Next(2, 11);
            a = b * temporaryQuotient;
            div_string.Text = a.ToString() + ":" + b.ToString() + "=";
            res = method.Division(a,b);
        }
    }
}
