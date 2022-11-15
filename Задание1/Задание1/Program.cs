using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Дополнительное задание 1
namespace Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количесвто элементов массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Random random = new Random();
            for(int i = 0; i < n; i++)
            {
                array[i] = random.Next(100);
            }

            Console.Write("Ввдите чмсло: ");
            int number = int.Parse(Console.ReadLine());
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        if (array[i] + array[j] == number)
                        {
                            Console.Write($"{number} ");
                            k++;
                        }

                    }
                }
            }

            if (k == 0)
                Console.WriteLine("Не одна сумма чисел массива не равна заданному числу");

            Console.ReadKey();
        }
    }
}
