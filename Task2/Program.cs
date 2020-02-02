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
            const double rubleToUsdRate = 65.03, rubleToEuroRate = 72.08, rubleToDkkRate = 100.80, usdToRubleRate = 62.84, euroToRubleRate = 69.63, dkkToRubleRate = 88.2;

            Converter conversion = new Converter(rubleToUsdRate, rubleToEuroRate, rubleToDkkRate)
            {
                UsdToRubleRate = usdToRubleRate,
                EuroToRubleRate = euroToRubleRate,
                DkkToRubleRate = dkkToRubleRate,
            };

            conversion.SetTheAmountOfMoney();

            do
            {
                conversion.ConvertsCurrency();
            }
            while (Double.Parse(Console.ReadLine()) == 1);

            Console.ReadKey();
        }
    }
}
