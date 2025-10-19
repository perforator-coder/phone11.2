using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone11._2
{
    internal class phone
    {
        private string brand;
        private int bat;
        private bool error_brand;
        private bool error_bat;


        public string Brand {
            get { return brand; }
            set {
                if (String.IsNullOrWhiteSpace(value) == true)
                {
                    Console.WriteLine("Ошибка: бренд не может быть пустым.");
                    error_brand = true;
                }
                else { 
                    brand = value;
                    error_brand = false;
                }
            }
        }

        public int Bat {
            get { return bat; }
            set {
                if (value < 0 || value > 100) {
                    Console.WriteLine("Ошибка:Значение батареи не в диапозоне.");
                    error_bat = true;
                } else
                {
                    bat = value;
                    error_bat = false;
                }
            
            }
        }


        public void Use() {
            if (error_bat == false && error_brand == false && bat > 0)
            {
                Console.WriteLine($"Телефон {brand}, заряд {bat}.");
                bat -= 10;
            }
            else if (error_brand == false && error_bat == false && bat <= 0) {
                Console.WriteLine("Телефон разряжен!");
            }
        }
    }
}
