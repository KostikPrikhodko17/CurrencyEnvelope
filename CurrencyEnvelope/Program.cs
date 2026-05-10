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
            // 3. добавить возможность пользователю вводить свои собственные курсы валют для конвертации
            // 1. Добавить доп массиив с номерами валют и улучшить ыцith case с помощью when Contains()
            // 5. добавить обработку ошибок для некорректного ввода (например, если пользователь вводит не число для суммы конвертации)
            // 6. Улучшить switch-case для обработки выбора валюты, чтобы можно было легко добавлять новые валюты в будущем (например, использовать словарь для хранения курсов валют и их названий)
            // 7. В отображение результата добавить какую валюту пользователь получил после конвертации, а не только сумму



            string[] currency = { "1. TRY > RUB", "2. RUB > TRY", "3. USD > RUB", "4. RUB > USD" };
            double[] priceCurrency = { 1.64, 0.61, 74.24, 0.013 };


            Console.WriteLine("Конвертация валют.");
            Console.WriteLine("\nВыберите валюту для конвертации.");

            foreach (string item in currency)
            {
                Console.WriteLine(item);
            }

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                case "2":
                case "3":
                case "4":
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

        static double ReturnCurrency(string[] curruncy, string userChoice, double[] priceCurrency) // получение курса валюты в зависимости от выбора пользователя
        {
            Console.WriteLine("\n" + curruncy[int.Parse(userChoice) - 1]);
            return priceCurrency[int.Parse(userChoice) - 1];
        }
    }
}