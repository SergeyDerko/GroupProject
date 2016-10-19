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
                Console.WriteLine("Press any key.");
                while (Console.ReadKey().Key != ConsoleKey.Escape)
                {
                    if (string.IsNullOrEmpty(args.ToString()))
                    {
                        throw new ArgumentNullException(nameof(args));
                    }

                    foreach (var arg in args)
                    {
                        var tArg = "";
                        var str = arg;
                        str = str.Replace(" ", string.Empty);
                        var temp = str.ToCharArray();
                        foreach (var t in temp)
                        {
                            tArg += t.ToString();
                            if (Regex.IsMatch(t.ToString(), @"(\d+)"))
                            {   
                                if (pattern.Contains(@"\d+") || !pattern.Contains(@"([*/+-])"))
                                {
                                    pattern = @"(\d+)";
                                }
                                else
                                {
                                    pattern += @"(\d+)";
                                }
                            }
                            if (Regex.IsMatch(tArg, @"(\d+)([*/+-])(\d+)"))
                            {
                                var res = GetResult(pattern, tArg);
                                tArg = res.ToString();
                                pattern = @"(\d+)";
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
                    Console.WriteLine("If you want close program press Esc. / Для закрытия программы нажмите Esc");
                }
                Console.Clear();
            }
            catch (FormatException ex)
            {
                Console.Write("Format exception: " + ex);
                Console.ReadKey();
            }
        }

        private static int GetResult(string pattern, string arg)
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



