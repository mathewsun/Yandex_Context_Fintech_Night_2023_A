using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine().Trim();
            string str2 = Console.ReadLine().Trim();

            str1 = str1.Remove(0, 1);
            str1 = str1.Remove(str1.Length - 1);
            str1 = str1.Replace(",", string.Empty);
            int str1Int = Int32.Parse(str1);

            str2 = str2.Remove(0, 1);
            str2 = str2.Remove(str2.Length - 1);
            str2 = str2.Replace(",", string.Empty);
            int str2Int = Int32.Parse(str2);

            int result = str1Int + str2Int;

            string resultStr = result.ToString();

            string output = "[";

            foreach (char item in resultStr)
            {
                output = output + item + ",";
            }

            output = output.Remove(output.Length - 1);

            output = output + "]";


            Console.WriteLine(output); ;
        }
    }
}