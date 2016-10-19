using System;
using System.Text.RegularExpressions;

namespace _10_Calc_Modul
{
    internal class Calculator
    {
        public void Calc(string[] args)
        {
            var pattern = @"";
            try
            {
                while (Console.ReadKey().Key != ConsoleKey.Escape)
                {
                    if (string.IsNullOrEmpty(args.ToString()))
                    {
                        throw new ArgumentNullException(nameof(args));
                    }
                    foreach (var arg in args)
                    {
                        var tArg = "";
                        var temp = arg.ToCharArray();
                        foreach (var t in temp)
                        {
                            tArg += t.ToString();
                            if (Regex.IsMatch(t.ToString(), @"(\d+)"))
                            {
                                if (Regex.IsMatch(tArg, @"(\d+)\s+([*/+-])\s+(\d+)"))
                                {
                                    pattern = @"(\d+)\s+([*/+-])\s+(\d+)";
                                }
                                else if (pattern.Contains(@"\d+") || !pattern.Contains(@"([*/+-])"))
                                {
                                    pattern = @"(\d+)";
                                }
                                else
                                {
                                    pattern += @"(\d+)";
                                }
                            }
                            if (Regex.IsMatch(tArg, @"(\d+)\s+([*/+-])\s+(\d+)\s+"))
                            {
                                var res = NewMethod(pattern, tArg);
                                tArg = res.ToString();
                                Console.ReadKey();
                                pattern = @"(\d+)";
                            }
                            else if (Regex.IsMatch(t.ToString(), @"\s+"))
                            {
                                pattern += @"\s+";
                            }
                            else if (Regex.IsMatch(t.ToString(), @"([*/+-])"))
                            {
                                pattern += @"([*/+-])";
                            }
                            else if (Regex.IsMatch(t.ToString(), @"[=]"))
                            {
                                pattern += @"[=]";
                                break;
                            }
                        }
                    }
                    pattern = @"";
                    //Console.ReadKey();
                    Console.WriteLine("If you want close program press Esc.");
                }
            }
            catch (FormatException ex)
            {
                Console.Write("Format exception: " + ex);
                Console.ReadKey();
            }
        }

        private static int NewMethod(string pattern, string arg)
        {

            var result = 0;
            foreach (Match c in Regex.Matches(arg, pattern))
            {
                var value1 = int.Parse(c.Groups[1].Value);
                var value2 = int.Parse(c.Groups[3].Value);
                var action = c.Groups[2];
                switch (action.Value)
                {
                    case "*":
                        {
                            Console.WriteLine("{0}" + "=" + "{1}", c.Value, value1 * value2);
                            result = value1 * value2;
                            break;
                        }
                    case "/":
                        {
                            Console.WriteLine("{0}" + "=" + " {1:N2}", c.Value, value1 / value2);
                            result = value1 / value2;
                            break;
                        }
                    case "+":
                        {
                            Console.WriteLine("{0} " + "=" + " {1}", c.Value, value1 + value2);
                            result = value1 + value2;
                            break;
                        }
                    case "-":
                        {
                            Console.WriteLine("{0} " + "=" + " {1}", c.Value, value1 - value2);
                            result = value1 - value2;
                            break;
                        }
                }
            }
            return result;
        }
    }
}



