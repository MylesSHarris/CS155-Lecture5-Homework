using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            Reverse(numbers);
            PrintNumbers(numbers);
        }

        static void Reverse(int[] array)
        {
            for(int i=0; i<array.Length/2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
        }
        static int[] GenerateNumbers()
        {
            return new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        }
        static void PrintNumbers(int[] array)
        {
            for (int i=0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
