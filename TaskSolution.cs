using System;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace App2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Чтение массива из текстового поля
            var input = textBox1.Text.Split(' ').Select(int.Parse).ToArray();

            // Нахождение суммы положительных элементов
            var sumPos = input.Where(x => x > 0).Sum();

            // Нахождение минимального и максимального элементов и их индексов
            var min = input[0];
            var max = input[0];
            var minIndex = 0;
            var maxIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < min)
                {
                    min = input[i];
                    minIndex = i;
                }
                if (input[i] > max)
                {
                    max = input[i];
                    maxIndex = i;
                }
            }

            // Нахождение произведения элементов между минимальным и максимальным элементами
            var startIndex = Math.Min(minIndex, maxIndex) + 1;
            var endIndex = Math.Max(minIndex, maxIndex) - 1;
            var product = 1;
            for (int i = startIndex; i <= endIndex; i++)
            {
                product *= input[i];
            }

            // Вывод результата на форму
            label1.Text = $"Сумма положительных элементов: {sumPos}\nПроизведение элементов между минимальным и максимальным: {product}";
        }
    }
}
