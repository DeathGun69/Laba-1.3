using System;

namespace laba
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "zxcvbnm";
            string str2;

            Console.Write("Введите пароль: ");
            str2 = Console.ReadLine();

            int result = String.Compare(str1, str2);
            if (result!=0)
            {
                Console.WriteLine("Строки отличаются");
            }
            else
            {
                Console.WriteLine("Строки идентичны");
            }
            
        }
    }
}
