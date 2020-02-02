using System;

namespace Task2
{
    class Converter
    {
        //курс продажи
        readonly double rubleToUsdRate, rubleToEuroRate, rubleToDkkRate;

        //Курс покупки
        double usdToRubleRate, euroToRubleRate, dkkToRubleRate;

        //переменные для определения тяжести кошелька пользователя
        double ruble, dollar, euro, krone;

        //Пользовательский конструктор с тремя аргументами, содержащими курсы валют
        public Converter(double rubleToUsdRate, double rubleToEuroRate, double rubleToDkkRate)
        {
            this.rubleToUsdRate = rubleToUsdRate;
            this.rubleToEuroRate = rubleToEuroRate;
            this.rubleToDkkRate = rubleToDkkRate;
        }

        public double UsdToRubleRate { set { usdToRubleRate = value; } }
        public double EuroToRubleRate { set { euroToRubleRate = value; } }
        public double DkkToRubleRate { set { dkkToRubleRate = value; } }

        //Получаем леенду и курс валют
        void GetLegentAndCashRate()
        {
            Console.WriteLine("Легенда");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("■ - курс валют");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("■ - наличка в кошельке");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("■ - конвертация");
            Console.ResetColor();

            Console.WriteLine("\nКурс (покупка / продажа):");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("доллар\t{0} / {1}\nевро\t{2} / {3}\nкрона\t{4} / {5}\n", usdToRubleRate, rubleToUsdRate, euroToRubleRate, rubleToEuroRate, dkkToRubleRate, rubleToDkkRate);
            Console.ResetColor();
        }

        //Устанавливаем количество налички в кошельке
        public void SetTheAmountOfMoney()
        {
            GetLegentAndCashRate();

            Console.WriteLine("В кошельке было:");
            Console.ForegroundColor = ConsoleColor.Magenta;
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
            Console.ResetColor();
        }

        //Определяет конечное количество денег в кошельке
        void DetermineTheAmountOfMoney()
        {
            Console.WriteLine("\nВ кошельке стало:");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("рублей = {0}\nдолларов = {1}\nевро = {2}\nкрон = {3}", ruble, dollar, euro, krone); ;
            Console.ResetColor();
        }

        //Спрашивает: стоит ли повторить конвертацию (рубль в ... / ... в рубль)
        void RepeatConversation()
        {
            Console.WriteLine("\nПовторим конвертацию денег");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1 - да\n2 - нет");
            Console.ResetColor();
            Console.Write("Мой ответ = ");
        }

        //Производит конвертацию валюты (рубль в .../... в рубль)
        public void ConvertsCurrency()
        {
            byte answerFromProgramcs, answerFromCase;

            Console.WriteLine("\nВыберите перевод:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1 - рубль в ...\n2 - ... в рубль");
            Console.ResetColor();
            Console.Write("Мой ответ = ");
            answerFromProgramcs = Byte.Parse(Console.ReadLine());
            switch (answerFromProgramcs)
            {
                case 1:
                    Console.WriteLine("\nРубль в ...");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("1 - ... доллар\n2 - ... евро\n3 - ... крону");
                    Console.ResetColor();
                    Console.Write("Мой ответ = ");
                    answerFromCase = Byte.Parse(Console.ReadLine());
                    if (answerFromCase == 1)
                    {
                        dollar += ruble / rubleToUsdRate;
                        ruble = 0;
                    }
                    else if (answerFromCase == 2)
                    {
                        euro += ruble / rubleToEuroRate;
                        ruble = 0;
                    }
                    else
                    {
                        krone += ruble / rubleToDkkRate;
                        ruble = 0;
                    }
                    break;
                case 2:
                    Console.WriteLine("\n... в рубль");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("1 - доллар ...\n2 - евро ...\n3 - крона ...");
                    Console.ResetColor();
                    Console.Write("Мой ответ = ");
                    answerFromCase = Byte.Parse(Console.ReadLine());
                    if (answerFromCase == 1)
                    {
                        ruble += dollar * usdToRubleRate;
                        dollar = 0;
                    }
                    else if (answerFromCase == 2)
                    {
                        ruble += euro * euroToRubleRate;
                        euro = 0;
                    }
                    else
                    {
                        ruble += krone * dkkToRubleRate;
                        krone = 0;
                    }
                    break;
                default:
                    break;
            }
            DetermineTheAmountOfMoney();
            RepeatConversation();
        }
    }
}
