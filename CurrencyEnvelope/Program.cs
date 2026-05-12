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
            // добавить enum для цикла. если пользлватель нажмет клавишу x то программа завершится, если нажмет любую другую клавишу то программа продолжит работу
            // 3. добавить возможность пользователю вводить свои собственные курсы валют для конвертации
            // 5. добавить обработку ошибок для некорректного ввода (например, если пользователь вводит не число для суммы конвертации)



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

                string workProgram = Console.ReadLine();
                if (workProgram == "x")
                {
                    stopProgram = false;
                }
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