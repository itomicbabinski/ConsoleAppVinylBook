using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVinylBook
{
    internal class Common
    {




        internal static int ReadNumberRespond(string message, int min, int max)
        {
            int b;
            while (true)
            {
                try
                {
                    Console.Write(message + ": ");
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
