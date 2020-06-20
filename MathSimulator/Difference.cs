using System;
using System.Windows.Forms;

namespace MathSimulator
{   
    public partial class Difference : Form
    {
        // об'єкт класу з основними методами
        readonly MainMethods method = new MainMethods();
        // об'єкт класу рандом для випадкових чисел
        readonly Random rnd = new Random();
        // a - зменшуване
        // b - від'ємне
        // res - різниця
        int a, b, res;
        /// <summary>
        /// Ініціалізація компонентів
        /// </summary>
        public Difference()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод завантаження форми
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DifferenceLoad(object sender, EventArgs e)
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
        /// Генерація чисел та розрахунок різниці
        /// </summary>
        public void Generation()
        {
            a = rnd.Next(50, 101);
            b = rnd.Next(0, 49);
            diff_string.Text = a.ToString() + "-" + b.ToString() + "=";
            res = method.Difference(a,b);
        }
    }
}
