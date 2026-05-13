using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyEnvelope
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Добавить enum для валют и использовать его вместо строковых значений для выбора валюты
            // 3. добавить возможность пользователю вводить свои собственные курсы валют для конвертации



            string[] currency = { "TRY > RUB", "RUB > TRY", "USD > RUB", "RUB > USD", "EUR > RUB", "RUB > EUR" }; 
            string[] idCurruncy = { "1", "2", "3", "4", "5", "6" };
            double[] priceCurrency = { 1.64, 0.61, 74.24, 0.013, 87.29, 0.011 }; 


            Console.WriteLine("Конвертация валют.\nЧтобы выйти, введите 'x'.");
            bool stopProgram = true;
            while (stopProgram)
            {
                Console.WriteLine("\nВыберите валюту для конвертации.");

                for (int i = 0; i < idCurruncy.Length; i++)
                {
                    Console.WriteLine(idCurruncy[i] + " - " + currency[i]);
                }

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case string when idCurruncy.Contains(userChoice):
                        double correctPrice = ReturnCurrency(currency, userChoice, priceCurrency);
                        double result = ConvertCurrency(correctPrice);
                        Console.WriteLine($"Результат конвертации: {currency[int.Parse(userChoice) - 1]} = {result}");
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор валюты.");
                        break;
                }

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.X)
                {
                    stopProgram = false;
                }
            }
            
        }

        static double ConvertCurrency(double priceCurrency) // расчет конвертации валюты
        {
            Console.Write("Введите сумму для конвертации: ");
            string convertSum = Console.ReadLine();
            if (!double.TryParse(convertSum, out double sum) || sum <= 0)
            {
                Console.WriteLine("\nНекоректные данные.");
                return 0;
            }
            return double.Parse(convertSum) * priceCurrency;
        }

        static double ReturnCurrency(string[] curruncy, string userChoice, double[] priceCurrency) // получение курса валюты в зависимости от выбора пользователя
        {
            Console.WriteLine("\n" + curruncy[int.Parse(userChoice) - 1]);
            return priceCurrency[int.Parse(userChoice) - 1];
        }
    }
}