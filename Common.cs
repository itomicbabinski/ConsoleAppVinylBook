using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVinylBook
{
    internal class Common
    {
        public static bool DEV = false;



        internal static bool ReadBool(string mesage, string trueValue)
        {
            Console.Write(mesage + ": ");
            return Console.ReadLine().Trim().ToLower() == trueValue;
        }

        internal static DateTime ReadDate(string mesage, bool beforeToDayControl)
        {
            DateTime d;

            while (true)
            {
                try
                {
                    Console.WriteLine("Format unosa je yyyy-MM-dd, for today's date {0}",
                        DateTime.Now.ToString("yyyy-MM-dd"));
                    if (beforeToDayControl)
                    {
                        Console.WriteLine("The entered date must not be earlier than today's date!");
                    }
                    Console.Write(mesage + ": ");
                    d = DateTime.Parse(Console.ReadLine());
                    if (beforeToDayControl && d < DateTime.Now)
                    {
                        throw new Exception();
                    }
                    return d;
                }
                catch
                {
                    Console.WriteLine("Error Date entry");
                }
            }
        }

        internal static float ReadDecimalNumber(string mesage, int min, float max)
        {
            float b;
            while (true)
            {
                try
                {
                    Console.Write(mesage + ": ");
                    b = float.Parse(Console.ReadLine());
                    if (b < min || b > max)
                    {
                        throw new Exception();
                    }
                    return b;
                }
                catch
                {
                    Console.WriteLine("The decimal number must be in the range {0} & {1}", min, max);
                }
            }
        }

        internal static string ReadString(string mesage, int max, bool mandatory)
        {
            string s;
            while (true)
            {
                Console.Write(mesage + ": ");
                s = Console.ReadLine().Trim();
                if ((mandatory && s.Length == 0) || s.Length > max)
                {
                    Console.WriteLine("Mandatory entry, maximum allowed {0} strings", max);
                    continue;
                }
                return s;
            }
        }

        internal static string ReadString(string old, string mesage, int max, bool mandatory)
        {
            string s;
            while (true)
            {
                Console.Write(mesage + " (" + old + "): ");
                s = Console.ReadLine().Trim();
                if (s.Length == 0)
                {
                    return old;
                }
                if ((mandatory && s.Length == 0) || s.Length > max)
                {
                    Console.WriteLine("Mandatory entry, maximum allowed {0} strings", max);
                    continue;
                }
                return s;
            }
        }

            internal static int ReadNumberRespond(string mesage, int min, int max)
        {
            int b;
            while (true)
            {
                try
                {
                    Console.Write(mesage + ": ");
                    b = int.Parse(Console.ReadLine());
                    if (b < min || b > max)
                    {
                        throw new Exception();
                    }
                    return b;
                }
                catch
                {
                    Console.WriteLine("Incorrect input!!! Input must be in the range {0} to {1}", min, max);
                }
            }
        }
    }
}
