using System;

namespace Example005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя пользователя: ");
            string username = Console.ReadLine();
            if (username.ToLower() == "маша")
            { 
                Console.WriteLine("Ура, наконец-то пришла Маша!");
            }
            else
            {
                Console.WriteLine("Привет, " + username);
            }
        }
    }
}
