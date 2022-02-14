using System;

namespace HomeWork_02._15._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            int average = 0;
            int[] arr = { 70, 65, 100, 90, 30, 95, 40 };
            foreach (int num in arr)
            {
                sum += num;
                count++;
            }
            average = sum / count;
            Console.WriteLine(average);

        }
    }
}
