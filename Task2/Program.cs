/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс Converter. 
В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к рублю - public Converter(double usd, double eur, double dkk).  
Написать программу, которая будет выполнять конвертацию из рубля в одну из указанных валют, также программа должна производить конвертацию из указанных валют в рубль. 
*/
using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double ruble, dollar, euro, krone;
            const double rubleToUsdRate = 65.03, rubleToEuroRate = 72.08, rubleToDkkRate = 100.80, usdToRubleRate = 62.84, euroToRubleRate = 69.63, dkkToRubleRate = 88.2;
            byte myAnswerOne, myAnswerTwo = 0;
            
            Console.WriteLine("Курс (покупка / продажа):\nдоллар\t{0} / {1}\nевро\t{2} / {3}\nкрона\t{4} / {5}\n", usdToRubleRate, rubleToUsdRate, euroToRubleRate, rubleToEuroRate, dkkToRubleRate, rubleToDkkRate);

            DetermineTheAmountOfMoney();
            
            Converter conversion = new Converter(rubleToUsdRate, rubleToEuroRate, rubleToDkkRate);
            conversion.UsdToRubleRate = usdToRubleRate;
            conversion.EuroToRubleRate = euroToRubleRate;
            conversion.DkkToRubleRate = dkkToRubleRate;

            //секция if
            Console.Write("\nВыберите перевод: \n1 - рубль в ...\n2 - ... в рубль\n\nМой ответ = ");
            myAnswerOne = Byte.Parse(Console.ReadLine());

            void DetermineTheAmountOfMoney()
            {
                Console.WriteLine("Раскройте бумажник и укажите количество:");
                for (int i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Console.Write("рублей = ");
                            ruble = Double.Parse(Console.ReadLine());
                            break;
                        case 1:
                            Console.Write("долларов = ");
                            dollar = Double.Parse(Console.ReadLine());
                            break;
                        case 2:
                            Console.Write("евро = ");
                            euro = Double.Parse(Console.ReadLine());
                            break;
                        case 3:
                            Console.Write("датских крон = ");
                            krone = Double.Parse(Console.ReadLine());
                            break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
