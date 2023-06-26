using System;

namespace ConsoleFinancialAccounting
{
    class Program
    {
        static void Main(string[] args)
        {
            bool activeApp = true;
            double expences = 0;
            double earnings = 0;
            double balance = 0;
            while (activeApp)
            {
                Console.WriteLine("Оберiть операцiю: \n 1 - Внести витрату \n2 - Переглянути витрати \n3 - Внести дохiд \n4 - Переглянути доходи \n5 - Переглянути загальний баланс \n exit - Закрити програму");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    // форматни кейси шоб легше читались (так як 1)
                    case "1": 
                        EnterExpence(ref expences, ref balance); 
                        break;
                    case "2": 
                        Console.WriteLine($"Cума витрат: {expences}");
                        break;
                    case "3": 
                        EnterEarning(ref earnings, ref balance); 
                        break;
                    case "4": 
                        Console.WriteLine($"Cума доходiв: {earnings}");
                        break;
                    case "5": 
                        Console.WriteLine($"Баланс: {balance}");
                        break;
                    case "exit": activeApp = false; break;
                    default: Console.WriteLine("Ви не обрали операцiю"); break;
                }

                void EnterExpence(ref double allExpences, ref double fullBalance)
                {
                    //наступпні 2 строки повторюються на 51-52 лініях, оптимізуй це
                    Console.WriteLine("Введiть суму:");
                    double newExpence = Convert.ToDouble(Console.ReadLine());
                    allExpences += newExpence;
                    fullBalance -= newExpence;
                }
            }
        }
    }
}
