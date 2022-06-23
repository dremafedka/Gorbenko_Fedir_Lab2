using System;

namespace ConsoleApp1
{
    class Bouquet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================== Set your bouquet ===================");
            Rose rose1 = new Rose(27,"high fresh");
            Console.WriteLine("Choose first flower:");
            Console.WriteLine();
            Console.WriteLine("Number 1:");
            Console.WriteLine();
            rose1.GetInfo();
            Console.WriteLine();
            Rose rose2 = new Rose(33, "medium fresh");
            Console.WriteLine("Number 2:");
            Console.WriteLine();
            rose2.GetInfo();
            Console.WriteLine();

            Console.WriteLine("Enter 1 or 2 to choose first flower");
            Console.WriteLine();

            Flower[] bouquet = new Flower[3];

            
            int status1 = 1;
            while (status1 != 0)
            {
                char choose1 = Console.ReadKey(true).KeyChar;
                switch (choose1)
                {
                    case '1': bouquet[0] = rose1; Console.WriteLine("You have choosen first flower with Number 1"); status1 = 0; break;
                    case '2': bouquet[0] = rose2; Console.WriteLine("You have choosen first flower with Number 2"); status1 = 0; break;
                    default: Console.WriteLine("You haven`t chosen correctly, try again"); break;
                }
            };

            Console.WriteLine();

            Console.WriteLine("Choose second flower:");
            Console.WriteLine();
            Console.WriteLine("Number 1:");
            Tulip tulip1 = new Tulip(24, "medium fresh");
            Console.WriteLine();
            tulip1.GetInfo();
            Console.WriteLine();
            Console.WriteLine("Number 2:");
            Tulip tulip2 = new Tulip(26, "low fresh");
            Console.WriteLine();
            tulip2.GetInfo();
            Console.WriteLine();

            Console.WriteLine("Enter 1 or 2 to choose second flower");

            

            int status2 = 1;
            while (status2 != 0)
            {
                char choose2 = Console.ReadKey(true).KeyChar;
                switch (choose2)
                {
                    case '1': bouquet[1] = tulip1; Console.WriteLine("You have choosen second flower with Number 1"); status2 = 0; break;
                    case '2': bouquet[1] = tulip2; Console.WriteLine("You have choosen second flower with Number 2"); status2 = 0; break;
                    default: Console.WriteLine("You haven`t chosen correctly, try again"); break;
                }
            }

            Console.WriteLine();


            Console.WriteLine("Choose second flower:");
            Console.WriteLine();
            Console.WriteLine("Number 1:");
            Chamomile chamomile1 = new Chamomile(19, "medium fresh");
            Console.WriteLine();
            chamomile1.GetInfo();
            Console.WriteLine();
            Console.WriteLine("Number 2:");
            Chamomile chamomile2 = new Chamomile(17, "high fresh");
            Console.WriteLine();
            chamomile2.GetInfo();
            Console.WriteLine();

            Console.WriteLine("Enter 1 or 2 to choose third flower");

            

            int status3 = 1;
            while (status3 != 0) {
                char choose3 = Console.ReadKey(true).KeyChar;
                switch (choose3)
                {
                    case '1': bouquet[2] = chamomile1; Console.WriteLine("You have choosen third flower with Number 1"); status3 = 0; break;
                    case '2': bouquet[2] = chamomile2; Console.WriteLine("You have choosen third flower with Number 2"); status3 = 0;break;
                    default: Console.WriteLine("You haven`t chosen correctly, try again"); break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Price of your bouqet:");

            int price = 0;
            for (int i = 0; i < bouquet.Length; i++)
            {
               price += bouquet[i].Price;
            }
            Console.WriteLine($"{price} UAH");
            Console.WriteLine("========================================================");

            Console.WriteLine();
            Console.WriteLine("Sorting flowers with a level of fresh");
            Console.WriteLine();

            Console.WriteLine("========================================================");
            Console.WriteLine("Low level of fresh:");
            string low = "low fresh";
            
            for (int i = 0; i < bouquet.Length; i++)
            {
                if (bouquet[i].Fresh == low)
                {
                    Console.WriteLine(bouquet[i].Name);
                }
             
            }
            Console.WriteLine("========================================================");

            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Medium level of fresh:");
            string medium = "medium fresh";

            for (int i = 0; i < bouquet.Length; i++)
            {
                if (bouquet[i].Fresh == medium)
                {
                    Console.WriteLine(bouquet[i].Name);
                }

            }
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("High level of fresh:");
            string high= "high fresh";

            for (int i = 0; i < bouquet.Length; i++)
            {
                if (bouquet[i].Fresh == high)
                {
                    Console.WriteLine(bouquet[i].Name);
                }

            }
            Console.WriteLine("========================================================");
            Console.WriteLine();
            Console.WriteLine("Set range of length to show flowers:");
            Console.Write("First number: "); int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: "); int numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("========================================================");

            for (int i = 0; i < bouquet.Length; i++)
            {
                if (bouquet[i].Length >= numb1 && bouquet[i].Length <= numb2)
                {
                    Console.WriteLine(bouquet[i].Name);
                }
            }
            Console.WriteLine("========================================================");
        }
    }
}
