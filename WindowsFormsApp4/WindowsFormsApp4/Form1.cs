using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Заполнение массива
                int n = Convert.ToInt32(textBox1.Text);
                int m = n;
                if (n <= 0 || m <= 0)
                {
                    MessageBox.Show("Размер массива не может быть равен 0");
                }
                else
                {
                    int[][] arr = new int[n][];
                    string[] a = textBox3.Text.Split('\n');
                    if (a.Length > n) MessageBox.Show("Вы ввели больше числе, чем необходиом, данные будут обрезаны!!!");
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = new int[n];
                        string[] b = a[i].Split(' ');
                        if (b.Length > m) MessageBox.Show("Вы ввели больше числе, чем необходиом, данные будут обрезаны!!!");
                        for (int j = 0; j < m; j++)
                        {
                            arr[i][j] = Convert.ToInt32(b[j]);
                        }
                    }


                    // Подсчет суммы
                    int[] sum = new int[m];
                    for (int j = 0; j < m; j++)
                    {
                        int summer = 0;
                        for (int i = 0; i < n; i++)
                        {
                            if (arr[i][j] < 0) summer += arr[i][j];
                        }
                        sum[j] = summer;
                    }

                    for (int i = 0; i < m; i++)
                    {
                        textBox4.Text += sum[i] + "  ";

                    }
                }
            }
            catch { MessageBox.Show("Некорректный ввод данных!!!"); }
        }
    }
    }

