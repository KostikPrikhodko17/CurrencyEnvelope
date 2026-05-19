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
            List<CurrencyInfo> currencyInfo = new List<CurrencyInfo>();

            currencyInfo.Add(new CurrencyInfo { Name = "TRY > RUB", Rate = 1.64 });
            currencyInfo.Add(new CurrencyInfo { Name = "RUB > TRY", Rate = 0.61 });
            currencyInfo.Add(new CurrencyInfo { Name = "USD > RUB", Rate = 74.24 });
            currencyInfo.Add(new CurrencyInfo { Name = "RUB > USD", Rate = 0.013 });
            currencyInfo.Add(new CurrencyInfo { Name = "EUR > RUB", Rate = 87.29 });
            currencyInfo.Add(new CurrencyInfo { Name = "RUB > EUR", Rate = 0.011 });
            currencyInfo.Add(new CurrencyInfo { Name = "TRY > USD", Rate = 0.022 });
            currencyInfo.Add(new CurrencyInfo { Name = "USD > TRY", Rate = 45.43 });
            currencyInfo.Add(new CurrencyInfo { Name = "TRY > EUR", Rate = 0.019 });
            currencyInfo.Add(new CurrencyInfo { Name = "EUR > TRY", Rate = 53.16 });
            currencyInfo.Add(new CurrencyInfo { Name = "USD > EUR", Rate = 0.86 });
            currencyInfo.Add(new CurrencyInfo { Name = "EUR > USD", Rate = 1.17 });


            Console.WriteLine("Конвертация валют.\nЧтобы выйти, введите 'x'.");
            bool openProgram = true;
            do
            {
                Console.WriteLine("\nВыберите валюту для конвертации.");

                for (int i = 0; i < currencyInfo.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {currencyInfo[i].Name}");
                }

                string userChoice = Console.ReadLine();

                if (int.TryParse(userChoice, out int choice) && choice > 0 && choice <= currencyInfo.Count)
                {
                    double correctPrice =ReturnCurrency(currencyInfo, choice);
                    double result = ConvertCurrency(correctPrice);
                    Console.WriteLine($"Результат конвертации {currencyInfo[choice -1].Name} = {result}");
                }
                else if (userChoice.ToLower() == "x")
                {
                    openProgram = false;
                }
                else
                {
                    Console.WriteLine("\nНекоректные данные.");
                }
            }
            while (openProgram);
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
            return sum * priceCurrency;
        }

        static double ReturnCurrency(List<CurrencyInfo> currencyInfo, int userChoice) // получение курса валюты в зависимости от выбора пользователя
        {
            Console.WriteLine("\n" + currencyInfo[userChoice - 1].Name);
            return currencyInfo[userChoice - 1].Rate;
        }
    }
}