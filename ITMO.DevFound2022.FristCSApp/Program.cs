using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.DevFound2022.FristCSApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat = "no";
            do
            {
                ToDo();

                Console.WriteLine("Продолжать?");
                repeat = Console.ReadLine();
            
            }
            while (repeat != "no");

            Console.WriteLine("Пока!");
        }

        static void ToDo()
        {
            Console.WriteLine("Введи строку: ");
            string result = Console.ReadLine();

            Console.WriteLine(result == "ivan");

            //if (result == "ivan")
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}

            Console.WriteLine("имя = " + result);
        }
    }
}