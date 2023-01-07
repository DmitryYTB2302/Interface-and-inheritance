using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лабораторная_7_по_методичке
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int znach, max, min, max1, min1; 
            znach = Convert.ToInt32(numericUpDown1.Text);
            min = Convert.ToInt32(numericUpDown2.Text);
            max = Convert.ToInt32(numericUpDown3.Text);
            int lenghtm = Convert.ToInt32(numericUpDown4.Text);
            min1 = Convert.ToInt32(numericUpDown5.Text);
            max1 = Convert.ToInt32(numericUpDown6.Text);
            int lenght0 = Convert.ToInt32(numericUpDown7.Text);
            int lenght1 = Convert.ToInt32(numericUpDown8.Text);
            if (lenghtm < 1) 
            {
                textBox14.Text += "Массив не может не иметь значений";
                return;
            }
            if (lenght0 < 1) 
            { 
                textBox14.Text += "Матрица не может иметь меньше одной строки";
                return;
            }
            if (lenght1 < 1)
            {
                textBox14.Text += "Матрица не может иметь меньше одного столбца";
                return;
            }
            textBox14.Text += "Невозможно создать объкт абстрактного класса 'Переменная'" + Environment.NewLine;
            mass Ro = new mass();
            int[] arr1 = new int[lenghtm];
            Random rand = new Random();
            for (int i = 0; i < lenghtm; i++) { arr1[i] = rand.Next(max, min); }
            textBox14.Text += "Массив" + Environment.NewLine;
            textBox14.Text += "Сумма " + Ro.Plus(arr1) + Environment.NewLine;
            textBox14.Text += "Произведение " + Ro.Umn(arr1) + Environment.NewLine;
            textBox14.Text += "Сортировка";
            arr1 = Ro.Sort(arr1);
            foreach (int i in arr1) { textBox14.Text += " " + Convert.ToString(i); }
            textBox14.Text += Environment.NewLine + Environment.NewLine;

            matr Ran = new matr();
            int[,] arr2 = new int[lenght0, lenght1];
            for (int i = 0; i < arr2.GetLength(1); i++)
            {
                for (int j = 0; j < arr2.GetLength(0); j++)
                {
                    arr2[j, i] = rand.Next(max, min);
                }
            }
            textBox14.Text += "Исходный массив:";
            for (int i = 0; i < arr2.GetLength(1); i++)
            {
                textBox14.Text += Environment.NewLine;
                for (int j = 0; j < arr2.GetLength(0); j++)
                {
                    textBox14.Text += " " + Convert.ToString(arr2[i, j]);
                }
            }
            textBox14.Text += Environment.NewLine;
            textBox14.Text += Environment.NewLine;
            int[,] arrMultiply = new int[arr2.GetLength(1), arr2.GetLength(0)];
            arrMultiply = Ran.Umn(arr2, arr2);
            textBox14.Text += "Умножение матрицы: ";
            for (int i = 0; i < arrMultiply.GetLength(1); i++)
            {
                textBox14.Text += Environment.NewLine;
                for (int j = 0; j < arrMultiply.GetLength(0); j++)
                {
                    textBox14.Text += "\n " + Convert.ToString(arrMultiply[i, j]);
                }
            }
            textBox14.Text += Environment.NewLine;
            textBox14.Text += Environment.NewLine;
            /*textBox14.Text += "Матрица" + Environment.NewLine;
            textBox14.Text += "Сумма " + Ran.Plus(arr2) + Environment.NewLine;
            textBox14.Text += "Произведение " + Ran.Umn(arr2) + Environment.NewLine;*/
            int[,] arrSum = new int[arr2.GetLength(1), arr2.GetLength(0)];
            arrSum = Ran.Plus(arr2, arr2);
            textBox14.Text += "Сложение матриц: ";
            for (int i = 0; i < arrSum.GetLength(1); i++)
            {
                textBox14.Text += Environment.NewLine;
                for (int j = 0; j < arrSum.GetLength(0); j++)
                {
                    textBox14.Text += "\n " + Convert.ToString(arrSum[i, j]);
                }
            }
            textBox14.Text += Environment.NewLine;
            textBox14.Text += Environment.NewLine;
            textBox14.Text += "Сортировка: ";
            arr2 = Ran.Sort(arr2);
            for (int i = 0; i < arr2.GetLength(1); i++)
            {
                textBox14.Text += Environment.NewLine;
                for (int j = 0; j < arr2.GetLength(0); j++)
                {
                    textBox14.Text += " " + Convert.ToString(arr2[i,j]);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox14.Clear();
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
