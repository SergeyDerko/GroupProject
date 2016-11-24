using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There: framer and wolf - 1");
            Console.WriteLine("There: farmer and cabbage - 2");
            Console.WriteLine("There: farmer and goat - 3");
            Console.WriteLine("There: farmer - 4");
            Console.WriteLine("Back: farmer and wolf - 5");
            Console.WriteLine("Back: farmer and cabbage - 6");
            Console.WriteLine("Back: farmer and goat - 7");
            Console.WriteLine("Back: farmer - 8");
            FrStp:
            Console.WriteLine("Please, type your choose numbre 1, 2, 3, 4, 5, 6, 7 and 8 for first step! Good luck :)");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 3)
            {
                Console.WriteLine("Good chose! Your first step is correct");
                SdStp:
                Console.WriteLine("Now we have farmer and goat on bank №2. We need to comeback farmer for new carry to bank №2");
                Console.WriteLine("Please, type your choose numbre 7 or 8 for second step! Good luck :)");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b == 8)
                {
                    Console.WriteLine("Good! Your second step is correct");
                    FdStp: 
                    Console.WriteLine("Now farmer need choose to carry another on bank №2!!!");
                    Console.WriteLine("Please, type your choose numbre 1, 2 and 4 for step 3! Good luck :)");
                    int c = Convert.ToInt32(Console.ReadLine());
                    if (c == 2)
                    {
                        Console.WriteLine("Fantactic! Your step 3 is correct");
                        FoStp:
                        Console.WriteLine("Now we have farmer, goat and cabbage on bank №2. We need to comeback farmer for new carry to bank №1");
                        Console.WriteLine("Please, type your choose numbre 6, 7 and 8 for second step! Good luck :)");
                        int d = Convert.ToInt32(Console.ReadLine());
                        if (d == 7)
                        {
                            Console.WriteLine("Good chose! Your step 4 is correct");
                            FiStp:
                            Console.WriteLine("Now farmer need choose to carry another on bank №2!!!");
                            Console.WriteLine("Please, type your choose numbre 1, 2 and 4 for step 3! Good luck :)");
                            int e = Convert.ToInt32(Console.ReadLine());
                            if (e == 1)
                            {
                                Console.WriteLine("Fantactic! Your step 5 is correct"); 
                                SxStp:
                                Console.WriteLine("Now we have farmer, wolf and cabbage on bank №2. We need to comeback farmer to get goat");
                                Console.WriteLine("Please, type your choose numbre 5, 6 and 8 for second step! Good luck :)");
                                int f = Convert.ToInt32(Console.ReadLine());
                                if (f == 8)
                                {
                                    Console.WriteLine("Good! Your step 6 is correct"); 
                                    SvStp:
                                    Console.WriteLine("Last step :) Go on!!!");
                                    Console.WriteLine("Please, type your choose numbre 3 or 4 for second step! Good luck :)");
                                    int g = Convert.ToInt32(Console.ReadLine());
                                    if (g == 3)
                                    {
                                        Console.WriteLine("Finaly we have all on new side: wolf, cabbeg and goat!");
                                        Console.ReadLine();
                                        return;
                                    }
                                    else
                                    Console.WriteLine("No correct answer, please try again! I believe in you :)");
                                    goto SvStp;

                                }
                                else
                                Console.WriteLine("No correct answer, please try again! I believe in you :)");
                                goto SxStp;
                            }
                            else
                            Console.WriteLine("No correct answer, please try again! I believe in you :)");
                            goto FiStp;

                        }
                        else
                        Console.WriteLine("No correct answer, please try again! I believe in you :)");
                        goto FoStp;

                    }
                    Console.WriteLine("Good! Your second step is correct");
                    Console.WriteLine("Now farmer comeback on bank №1!!!");
                    Console.WriteLine("Please, type your choose numbre 1, 2 and 4 for step 3! Good luck :)");
                    int cV = Convert.ToInt32(Console.ReadLine());
                    if (cV == 1)
                    {
                        Console.WriteLine("Fantactic! Your step 3 is correct");
                        Console.WriteLine("Now we have farmer, wolf and goat on bank №2. We need to comeback farmer for new carry to bank №2 Don't foget a problem about goat and wolf?!");
                        Console.WriteLine("Please, type your choose numbre 5, 7 and 8 for second step! Have fine :)");
                        int dV = Convert.ToInt32(Console.ReadLine());
                        if (dV == 7)
                        {
                            Console.WriteLine("Good chose! Your step 4 is correct");
                            FiStpV:
                            Console.WriteLine("Now farmer need choose to carry another on bank №2!!!");
                            Console.WriteLine("Please, type your choose numbre 1, 2 and 4 for step 3! Good luck :)");
                            int eV = Convert.ToInt32(Console.ReadLine());
                            if (eV == 2)
                            {
                                Console.WriteLine("Fantactic! Your step 5 is correct");
                                SxStpV:
                                Console.WriteLine("Now we have farmer, wolf and cabbage on bank №2. We need to comeback farmer to get goat");
                                Console.WriteLine("Please, type your choose numbre 5, 6 and 8 for second step! Good luck :)");
                                int fV = Convert.ToInt32(Console.ReadLine());
                                if (fV == 8)
                                {
                                    Console.WriteLine("Good! Your step 6 is correct");
                                    SvStpV:
                                    Console.WriteLine("Last step :) Go on!!!");
                                    Console.WriteLine("Please, type your choose numbre 3 or 4 for second step! Good luck :)");
                                    int gV = Convert.ToInt32(Console.ReadLine());
                                    if (gV == 3)
                                    {
                                        Console.WriteLine("Finaly we have all on new side: wolf, cabbeg and goat!");
                                        Console.ReadLine();
                                    }
                                    else
                                        Console.WriteLine("No correct answer, please try again! I believe in you :)");
                                    goto SvStpV;

                                }
                                else
                                    Console.WriteLine("No correct answer, please try again! I believe in you :)");
                                goto SxStpV;
                            }
                            else
                                Console.WriteLine("No correct answer, please try again! I believe in you :)");
                            goto FiStpV;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No correct answer, please try again! I believe in you :)");
                        goto FdStp;
                    }
                }
                else
                {
                    Console.WriteLine("No correct answer, please try again! I believe in you :)");
                    goto SdStp;
                }
            }
            else if (a < 1 && a > 8)
            {
                Console.WriteLine("Sorry but this choose is incorrect :(");
                goto FrStp;
            }
            else
            {
                Console.WriteLine("No correct answer, please try again! I believe in you :)");
                goto FrStp;
                
            }
        }
    }
}
