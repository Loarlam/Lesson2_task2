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
        public double Ruble { set { ruble = value; } }
        public double Dollar { set { dollar = value; } }
        public double Euro { set { euro = value; } }
        public double Krone { set { krone = value; } }
        public byte AnswerFromProgramcs { set { answerFromProgramcs = value; } }

        public void ConvertsCurrency()
        {
            byte answerFromCase;
            switch (answerFromProgramcs)
            {
                //добавить вовзращаемое значение в консоль
                case 1:
                    Console.Write("\n1 - рубль в доллар\n2 - рубль в евро\n3 - рубль в крону\n\nМой ответ = ");
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
                    Console.Write("\n1 - доллар в рубль\n2 - евро в рубль\n3 - крона в рубль\n\nМой ответ = ");
                    answerFromCase = Byte.Parse(Console.ReadLine());
                    if (answerFromCase == 1)
                    {
                        ruble += dollar * usdToRubleRate;
                        dollar = 0;
                    }         
                    else if (answerFromCase == 2)
                    {
                        ruble += euro / euroToRubleRate;
                        euro = 0;
                    }                        
                    else
                    {
                        ruble += krone / dkkToRubleRate;
                        krone = 0;
                    }                        
                    break;
                default:
                    break;
            }
        }
    }
}
