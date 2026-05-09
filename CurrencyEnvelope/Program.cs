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
            // 2 добавить больше валют
            // 3 добавить возможность конвертации в обе стороны (например, 1. TRY <> RUB и 1. RUB <> TRY)
            // 4. добаваиь цикл для повторного использования программы без перезапуска
            // 5. добавить обработку ошибок для некорректного ввода (например, если пользователь вводит не число для суммы конвертации)
            // 6. Улучшить switch-case для обработки выбора валюты, чтобы можно было легко добавлять новые валюты в будущем (например, использовать словарь для хранения курсов валют и их названий)



            string currency = "1. TRY <> RUB";

            Console.WriteLine("Конвертация валют.");
            Console.WriteLine("Доступные валюты для конвертации.\n" + currency);
            Console.Write("\nВыберите валюту для конвертации: ");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    double liraInRub = 1.64;
                    double result = ConvertCurrency(liraInRub);
                    Console.WriteLine($"Результат конвертации: {result} RUB");
                    break;
            }
        }

        static double ConvertCurrency(double priceCurrency)
        {
            Console.Write("Введите сумму для конвертации: ");
            double sumConvert = Convert.ToDouble(Console.ReadLine());
            return sumConvert * priceCurrency;
        }
    }
}