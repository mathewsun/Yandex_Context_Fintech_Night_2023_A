using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            str1 = str1.Remove(0, 1);
            str1 = str1.Remove(str1.Length - 1);

            string[] str1Array = str1.Split(',');
            int[] str1ArrayInt = str1Array.Select(x => Convert.ToInt32(x)).ToArray();

            str2 = str2.Remove(0, 1);
            str2 = str2.Remove(str2.Length - 1);

            string[] str2Array = str2.Split(',');
            int[] str2ArrayInt = str2Array.Select(x => Convert.ToInt32(x)).ToArray();

            int str1Position = str1ArrayInt.Length - 1;
            int str2Position = str2ArrayInt.Length - 1;
            int bonus = 0;

            Stack<int> result = new Stack<int>();

            while (str1Position >= 0 || str2Position >= 0 || bonus > 0)
            {
                int sum = bonus;
                sum += (str1Position >= 0) ? str1ArrayInt[str1Position] : 0;
                sum += (str2Position >= 0) ? str2ArrayInt[str2Position] : 0;

                result.Push(sum % 10);
                bonus = sum / 10;
                str1Position--;
                str2Position--;
            }

            Console.WriteLine($"[{String.Join(", ", result)}]");
        }
    }
}