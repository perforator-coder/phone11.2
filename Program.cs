using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            phone input_class = new phone("test",50);
            Console.Write("Введите бренд телефона:");
            string input_brand = Console.ReadLine();
            Console.Write("Введите заряд телефона:");
            if (int.TryParse(Console.ReadLine(), out int input_bat) == false) {
                Console.WriteLine("Ошибка: Некорректый ввод.");
                return;
            }
           // input_class.Brand = input_brand;
            //input_class.Bat = input_bat;
            input_class.Use();
            input_class.Use();

        }
    }
}
