using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void f()
        {
            try
            {
                //Заполнение массива
                Console.WriteLine("Введите размерность массива: ");
                Console.Write("n = ");
                int n = Convert.ToInt32(Console.ReadLine());
                int m = n;
                if (n <= 0 || m <= 0)
                {
                    Console.WriteLine("Размер массива не может быть равен 0");
                }
                else
                {
                    int[][] arr = new int[n][];
                    Console.WriteLine("Введите числа: ");
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = new int[n];
                        string[] a = Console.ReadLine().Split(' ');
                        for (int j = 0; j < m; j++)
                        {

                            arr[i][j] = Convert.ToInt32(a[j]);
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

                    Console.WriteLine("Вывод результата");
                    for (int i=0; i < m; i++)
                    {
                            Console.Write(sum[i] + "  ");

                    }
                }
            }
            catch { Console.WriteLine("Некорректный ввод данных!!!"); }
        }

            static void Main(string[] args)
            {
                f();
            Console.ReadKey();

            }
        } } 

