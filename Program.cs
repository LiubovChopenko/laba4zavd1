using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4zavd1
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
            {
                // Task 1
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                
                int[] array = new int[10];
                Random rand = new Random();

                // Заповнюємо масив випадковими числами в межах [0, 20]:
                Console.WriteLine("Вихідний масив:");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(0, 20);
                    Console.WriteLine($"array[{i}] = {array[i]}");
                }
                // Обчислюємо добуток однозначних елементів:
                int product = 1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= -9 && array[i] <= 9 && array[i] != 0)
                    {
                        product *= array[i];
                    }
                }

                Console.WriteLine("Добуток однозначних елементів: " + product);
                Console.ReadKey();
            }
        }
    }
    }
