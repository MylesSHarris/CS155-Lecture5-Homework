using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array1 = new double[10];
            
            array1[0] = 1.5;
            array1[1] = 5.2;
            array1[2] = 3.3;
            array1[3] = 8.0;
            array1[4] = 7.7;
            array1[5] = 4.5;
            array1[6] = 3.5;
            array1[7] = 9.9;
            array1[8] = 0.4;
            array1[9] = 6.3;

            double[] array2 = new double[array1.Length];

            for (int i=0; i<array2.Length; i++)
            {
                array2[i] = array1[i];
            }

            Console.WriteLine("Contents of array1:");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }

            Console.WriteLine("Contents of array2:");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
        }
    }
}
