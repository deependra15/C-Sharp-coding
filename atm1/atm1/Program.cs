using System;
namespace atm1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamnt, amnt;
            int a1, a2, a3, a4, a5, a6, a7;
            int b1, b2, b3, b4, b5, b6, b7;
            string ans;

            Console.WriteLine("Enter amount present in ATM");
            tamnt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter no of '2000' cureency: ");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter no of '500' cureency: ");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter no of '200' cureency: ");
            a3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter no of '100' cureency: ");
            a4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter no of '50' cureency: ");
            a5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter no of '20' cureency: ");
            a6 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter no of '10' cureency: ");
            a7 = Convert.ToInt32(Console.ReadLine());
        level:

            Console.WriteLine("want to withdraw ur money (Y/N)");
            ans = Console.ReadLine();

            switch (ans)
            {
                case "y":
                    Console.WriteLine("Enter amount for withdraw");
                    amnt = Convert.ToInt32(Console.ReadLine());
                   
                        if (amnt <= tamnt)
                        {
                            for (int i = amnt; i >= 10; i = i - 10)
                            {

                            if ((amnt >= 2000) && (a1 > 0))
                            {
                                b1 = (amnt / 2000);
                                a1 = a1 - b1;
                                tamnt = tamnt - (b1 * 2000);
                                amnt = amnt - (b1 * 2000);
                                Console.WriteLine("total 2000 currency is:" + b1 + "  & remaning currency is: " + a1);
                            }
                            else if ((amnt >= 500) && (a2 > 0))
                            {
                                b2 = (amnt / 500);
                                a2 = a2 - b2;
                                tamnt = tamnt - (b2 * 500);
                                amnt = amnt - (b2 * 500);
                                Console.WriteLine("total 500 currency is:" + b2 + "  & remaning currency is: " + a2);
                            }
                            else if ((amnt >= 200) && (a3 > 0))
                            {
                                b3 = (amnt / 200);
                                a3 = a3 - b3;
                                tamnt = tamnt - (b3 * 200);
                                amnt = amnt - (b3 * 200);

                                Console.WriteLine("total 200 currency is:" + b3 + "  & remaning currency is: " + a3);
                            }
                            else if ((amnt >= 100) && (a4 > 0))
                            {
                                b4 = (amnt / 100);
                                a4 = a4 - b4;
                                tamnt = tamnt - (b4 * 100);
                                amnt = amnt - (b4 * 100);

                                Console.WriteLine("total 100 currency is:" + b4 + "  & remaning currency is: " + a4);
                            }
                            else
                            {

                                if ((amnt >= 50) && (a5 > 0))
                                {
                                    b5 = (amnt / 50);
                                    a5 = a5 - b5;
                                    tamnt = tamnt - (b5 * 50);
                                    amnt = amnt - (b5 * 50);

                                    Console.WriteLine("total 50 currency is:" + b5 + "  & remaning currency is: " + a5);
                                }
                                else
                                {
                                    if ((amnt >= 20) && (a6 > 0))
                                    {
                                        b6 = (amnt / 20);
                                        a6 = a6 - b6;
                                        tamnt = tamnt - (b6 * 20);
                                        amnt = amnt - (b6 * 20);

                                        Console.WriteLine("total 20 currency is:" + b6 + "  & remaning currency is: " + a6);
                                    }
                                    else
                                    {
                                        if ((amnt >= 10) && (a7 > 0))
                                        {
                                            b7 = (amnt / 10);
                                            a7 = a7 - b7;
                                            tamnt = tamnt - (b7 * 10);
                                            amnt = amnt - (b7 * 10);

                                            Console.WriteLine("total 10 currency is:" + b7 + "  & remaning currency is: " + a7);
                                            

                                        }
                                        
                                    }
                                }
                            }


                            if (amnt == 0)
                                break;
                        }
                        goto level;

                    } 
                    

                    else
                    {
                        Console.WriteLine("plz enter valid amnount below than " + tamnt);
                    }
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("****************Thanku for visiting******************* ");
                    break;
            }



        }
    }
}
