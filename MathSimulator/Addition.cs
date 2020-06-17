using System;
using System.Windows.Forms;

namespace MathSimulator
{   
    public partial class Addition : Form
    {
        // об'єкт класу з основними методами
        readonly MainMethods method = new MainMethods();
        // об'єкт класу рандом для випадкових чисел
        readonly Random rnd = new Random();
        // a - перший доданок
        // b - другий доданок
        // res - сума
        int a, b, res;
        /// <summary>
        /// Ініціалізація компонентів
        /// </summary>
        public Addition()
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
        /// Генерація доданків та розрахунок суми
        /// </summary>
        public void Generation()
        {
            a = rnd.Next(0, 101);
            b = rnd.Next(0, 101);
            add_string.Text = a.ToString() + "+" + b.ToString() + "=";
            res = method.Addition(a,b);
        }
    }
}
