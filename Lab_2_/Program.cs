using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_
{
    public class Program
    {
        public static string reve(string str)
        {
            string rts = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rts = rts + str[i];
            }
            return rts;
        }
        public static int Main(string[] args)
        {
            string str = args[0];
            Console.WriteLine(reve(str));
            return 0;
        }
    }
}
