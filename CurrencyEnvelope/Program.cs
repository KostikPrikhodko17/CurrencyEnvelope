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
            // 4. добаваиь цикл для повторного использования программы без перезапуска
            // 5. добавить обработку ошибок для некорректного ввода (например, если пользователь вводит не число для суммы конвертации)
            // 6. Улучшить switch-case для обработки выбора валюты, чтобы можно было легко добавлять новые валюты в будущем (например, использовать словарь для хранения курсов валют и их названий)
            // 7. В отображение результата добавить какую валюту пользователь получил после конвертации, а не только сумму



            string[] currency = { "1. TRY < > RUB", "2. USD < > RUB" };
            double[] priceCurrency = { 1.64, 0.61 };


            Console.WriteLine("Конвертация валют.");
            Console.WriteLine("\nВыберите валюту для конвертации.");

            for (int i = 0; i <= currency.Length - 1; i++)
            {
                Console.WriteLine(currency[i]);
            }

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    double correctPrice = ReturnCurrency(currency, userChoice, priceCurrency);
                    double result = ConvertCurrency(correctPrice);
                    Console.WriteLine($"Результат конвертации: {result}");
                    break;
            }
        }

        static double ConvertCurrency(double priceCurrency) // расчет конвертации валюты
        {
            Console.Write("Введите сумму для конвертации: ");
            double sumConvert = Convert.ToDouble(Console.ReadLine());
            return sumConvert * priceCurrency;
        }

        static double ReturnCurrency(string[] curruncy, string userChoice, double[] priceCurrency) // определение направления конвертации и возврат правильного курса валюты
        {
            double correctPrice;
            Console.WriteLine("\n" + curruncy[int.Parse(userChoice) - 1]);
            Console.Write("Выберите направление конвертации: > < : ");
            string choice = Console.ReadLine();
            if (choice == ">")
            {
                correctPrice = priceCurrency[int.Parse(userChoice) - 1];
            }
            else
            {
                correctPrice = priceCurrency[int.Parse(userChoice)];
            }
            return correctPrice;
        }
    }
}