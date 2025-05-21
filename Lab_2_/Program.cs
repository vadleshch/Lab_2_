using System;

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
            if (args.Length == 0)
            {
                Console.Error.WriteLine("no arguments");
                return 1;
            }
            string input = args[0];
            Console.WriteLine(reve(input));
            return 0;
        }
    }
}
