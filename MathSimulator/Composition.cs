﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace MathSimulator
{   
    public partial class Composition : Form
    {
        // об'єкт класу з основними методами
        readonly MainMethods method = new MainMethods();
        // об'єкт класу рандом для випадкових чисел
        readonly Random rnd = new Random();
        // a - десятки
        // b - одиниці
        // num - число
        int a, b, num;
        /// <summary>
        /// Ініціалізація компонентів
        /// </summary>
        public Composition()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод завантаження форми
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompositionLoad(object sender, EventArgs e)
        {
            Generation();
            InformationOutput.Text = "";
            Next.Enabled = false;
            Next.Enabled = true;
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
        /// Очищення та кнопка "Далі"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Next_Click(object sender, EventArgs e)
        {
            Generation();
            dozens.Text = "";
            units.Text = "";
            UI_clear();
            InformationOutput.Text = "";
            Next.Enabled = false;
            Check.Enabled = true;

        }
        /// <summary>
        /// Кнопка перевірки результати
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check_Click(object sender, EventArgs e)
        {
            if (dozens.Text != "" && units.Text != "")
            {
                if (dozens.Text == a.ToString() && units.Text == b.ToString())
                {
                    InformationOutput.ForeColor = Color.FromArgb(0, 192, 0);
                    InformationOutput.Text = "Відповідь вірна!";
                    UI(a, b);
                    Next.Enabled = true;
                    Check.Enabled = false;
                   

                }
                else
                {
                    InformationOutput.ForeColor = Color.FromArgb(0, 0, 192);
                    InformationOutput.Text = "Спробуй ще раз!";
                    dozens.Text = "";
                    units.Text = "";
                    Next.Enabled = false;

                };
            }
            else
            {
                InformationOutput.ForeColor = Color.FromArgb(0, 0, 192);
                InformationOutput.Text = "Заповніть поля";
                Next.Enabled = false;
            }
        }
        /// <summary>
        /// Генерація чисел та розрахунок частки
        /// </summary>
        public void Generation()
        {
            num = rnd.Next(10, 79);
            div_string.Text = num.ToString();
            a = ((num % 100)/10)*10;
            b = (num % 10);
           
        }
        /// <summary>
        /// Відображення складу числа
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        void UI(int a, int b) 
        {
            switch (a)
            {
                case 10:
                    d1.Visible = true;
                    d2.Visible = false;
                    d3.Visible = false;
                    d4.Visible = false;
                    d5.Visible = false;
                    d6.Visible = false;
                    d7.Visible = false;
                    break;
                case 20:
                    d1.Visible = true;
                    d2.Visible = true;
                    d3.Visible = false;
                    d4.Visible = false;
                    d5.Visible = false;
                    d6.Visible = false;
                    d7.Visible = false;
                    break;
                case 30:
                    d1.Visible = true;
                    d2.Visible = true;
                    d3.Visible = true;
                    d4.Visible = false;
                    d5.Visible = false;
                    d6.Visible = false;
                    d7.Visible = false;
                    break;
                case 40:
                    d1.Visible = true;
                    d2.Visible = true;
                    d3.Visible = true;
                    d4.Visible = true;
                    d5.Visible = false;
                    d6.Visible = false;
                    d7.Visible = false;
                    break;
                case 50:
                    d1.Visible = true;
                    d2.Visible = true;
                    d3.Visible = true;
                    d4.Visible = true;
                    d5.Visible = true;
                    d6.Visible = false;
                    d7.Visible = false;
                    break;
                case 60:
                    d1.Visible = true;
                    d2.Visible = true;
                    d3.Visible = true;
                    d4.Visible = true;
                    d5.Visible = true;
                    d6.Visible = true;
                    d7.Visible = false;
                    break;
                case 70:
                    d1.Visible = true;
                    d2.Visible = true;
                    d3.Visible = true;
                    d4.Visible = true;
                    d5.Visible = true;
                    d6.Visible = true;
                    d7.Visible = true;
                    break;
            }
            switch (b)
            {
                case 0:
                    un.Visible = false;
                    u1.Visible = false;
                    u2.Visible = false;
                    u3.Visible = false;
                    u4.Visible = false;
                    u5.Visible = false;
                    u6.Visible = false;
                    u7.Visible = false;
                    u8.Visible = false;
                    u9.Visible = false;
                    break;
                case 1:
                    un.Visible = true;
                    u1.Visible = true;
                    u2.Visible = false;
                    u3.Visible = false;
                    u4.Visible = false;
                    u5.Visible = false;
                    u6.Visible = false;
                    u7.Visible = false;
                    u8.Visible = false;
                    u9.Visible = false;
                    break;
                case 2:
                    un.Visible = true;
                    u1.Visible = true;
                    u2.Visible = true;
                    u3.Visible = false;
                    u4.Visible = false;
                    u5.Visible = false;
                    u6.Visible = false;
                    u7.Visible = false;
                    u8.Visible = false;
                    u9.Visible = false;
                    break;
                case 3:
                    un.Visible = true;
                    u1.Visible = true;
                    u2.Visible = true;
                    u3.Visible = true;
                    u4.Visible = false;
                    u5.Visible = false;
                    u6.Visible = false;
                    u7.Visible = false;
                    u8.Visible = false;
                    u9.Visible = false;
                    break;
                case 4:
                    un.Visible = true;
                    u1.Visible = true;
                    u2.Visible = true;
                    u3.Visible = true;
                    u4.Visible = true;
                    u5.Visible = false;
                    u6.Visible = false;
                    u7.Visible = false;
                    u8.Visible = false;
                    u9.Visible = false;
                    break;
                case 5:
                    un.Visible = true;
                    u1.Visible = true;
                    u2.Visible = true;
                    u3.Visible = true;
                    u4.Visible = true;
                    u5.Visible = true;
                    u6.Visible = false;
                    u7.Visible = false;
                    u8.Visible = false;
                    u9.Visible = false;
                    break;
                case 6:
                    un.Visible = true;
                    u1.Visible = true;
                    u2.Visible = true;
                    u3.Visible = true;
                    u4.Visible = true;
                    u5.Visible = true;
                    u6.Visible = true;
                    u7.Visible = false;
                    u8.Visible = false;
                    u9.Visible = false;
                    break;
                case 7:
                    un.Visible = true;
                    u1.Visible = true;
                    u2.Visible = true;
                    u3.Visible = true;
                    u4.Visible = true;
                    u5.Visible = true;
                    u6.Visible = true;
                    u7.Visible = true;
                    u8.Visible = false;
                    u9.Visible = false;
                    break;
                case 8:
                    un.Visible = true;
                    u1.Visible = true;
                    u2.Visible = true;
                    u3.Visible = true;
                    u4.Visible = true;
                    u5.Visible = true;
                    u6.Visible = true;
                    u7.Visible = true;
                    u8.Visible = true;
                    u9.Visible = false;
                    break;
                case 9:
                    un.Visible = true;
                    u1.Visible = true;
                    u2.Visible = true;
                    u3.Visible = true;
                    u4.Visible = true;
                    u5.Visible = true;
                    u6.Visible = true;
                    u7.Visible = true;
                    u8.Visible = true;
                    u9.Visible = true;
                    break;
            }

        }
        /// <summary>
        /// Очищення
        /// </summary>
        void UI_clear()
        {
            d1.Visible = false;
            d2.Visible = false;
            d3.Visible = false;
            d4.Visible = false;
            d5.Visible = false;
            d6.Visible = false;
            d7.Visible = false;
            un.Visible = false;
            u1.Visible = false;
            u2.Visible = false;
            u3.Visible = false;
            u4.Visible = false;
            u5.Visible = false;
            u6.Visible = false;
            u7.Visible = false;
            u8.Visible = false;
            u9.Visible = false;

        }
    }
}
