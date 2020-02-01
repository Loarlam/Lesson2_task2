using System;
using System.Collections.Generic;
using System.Text;

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

        byte answerFromProgramcs;

        public Converter(double rubleToUsdRate, double rubleToEuroRate, double rubleToDkkRate)
        {
            this.rubleToUsdRate = rubleToUsdRate;
            this.rubleToEuroRate = rubleToEuroRate;
            this.rubleToDkkRate = rubleToDkkRate;
        }

        public double UsdToRubleRate { set { usdToRubleRate = value; } }
        public double EuroToRubleRate { set { euroToRubleRate = value; } }
        public double DkkToRubleRate { set { dkkToRubleRate = value; } }
        public byte AnswerFromProgramcs { set { answerFromProgramcs = value; } }

        //Определяем тяжесть кошелька пользователя
        //public void DetermineTheAmountOfMoney()
        //{
        //    Console.WriteLine("Раскройте бумажник и укажите количество:");
        //    for (int i = 0; i < 4; i++)
        //    {
        //        switch (i)
        //        {
        //            case 0:
        //                Console.Write("рублей = ");
        //                ruble = Double.Parse(Console.ReadLine());
        //                break;
        //            case 1:
        //                Console.Write("долларов = ");
        //                dollar = Double.Parse(Console.ReadLine());
        //                break;
        //            case 2:
        //                Console.Write("евро = ");
        //                euro = Double.Parse(Console.ReadLine());
        //                break;
        //            case 3:
        //                Console.Write("датских крон = ");
        //                krone = Double.Parse(Console.ReadLine());
        //                break;
        //        }
        //    }
        //    ConvertsCurrency();
        //}

        //public void ConvertsCurrency()
        //{
        //    byte myAnswerOne, myAnswerTwo = 0;
        //    Console.Write("\nВыберите перевод: \n1 - рубль в ...\n2 - ... в рубль\n\nМой ответ = ");
        //    myAnswerOne = Byte.Parse(Console.ReadLine());
        //    switch (myAnswerOne)
        //    {
        //        case 1:
        //            Console.Write("\n1 - рубль в доллар\n2 - рубль в евро\n3 - рубль в крону\n\nМой ответ = ");
        //            myAnswerTwo = Byte.Parse(Console.ReadLine());
        //            if (myAnswerTwo == 1)
        //                dollar += ruble / rubleToUsdRate;
        //            else if (myAnswerTwo == 2)
        //                euro += ruble / rubleToEuroRate;
        //            else
        //                krone += ruble / rubleToDkkRate;
        //            break;
        //        case 2:
        //            Console.Write("\n1 - доллар в рубль\n2 - евро в рубль\n3 - крона в рубль\n\nМой ответ = ");
        //            myAnswerTwo = Byte.Parse(Console.ReadLine());
        //            if (myAnswerTwo == 1)
        //                ruble += dollar * rubleToUsdRate;
        //            else if (myAnswerTwo == 2)
        //                ruble += euro / rubleToEuroRate;
        //            else
        //                ruble += krone / rubleToDkkRate;
        //            break;
        //        default:
        //            break;
        //    }
        //}
    }
}
