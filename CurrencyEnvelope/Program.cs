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

            // 3. добавить возможность пользователю вводить свои собственные курсы валют для конвертации

            string[] currency =
            {
                 "TRY > RUB",
                "RUB > TRY",
                "USD > RUB",
                "RUB > USD",
                "EUR > RUB",
                "RUB > EUR",
                "TRY > USD",
                "USD > TRY",
                "TRY > EUR",
                "EUR > TRY",
                "USD > EUR",
                "EUR > USD"
            };
              
            string[] idCurruncy = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };

            double[] priceCurrency =
            { 
                1.64, // TRY > RUB
                0.61,    // RUB > TRY
                74.24,   // USD > RUB
                0.013,   // RUB > USD
                87.29,   // EUR > RUB
                0.011,   // RUB > EUR
                0.022,   // TRY > USD
                45.43,   // USD > TRY
               0.019,   // TRY > EUR
                53.16,   // EUR > TRY
                0.86,    // USD > EUR
                1.17     // EUR > USD
            };

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