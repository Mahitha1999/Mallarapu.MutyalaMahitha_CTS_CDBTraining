using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondproject
{
    class Class1
    {

        static void Main()
        {
            //1. Print sum and average of elements of an Array
            int[] num = new int[5];
            int sum = 0;
            float avg;
            Console.WriteLine("Enter Numbers 5 numbers");
            for (int i = 0; i < 5; i++)
            {
                num[i] = Convert.ToInt16(Console.ReadLine());
                sum += num[i];
            }

            avg = (float)sum / 10;
            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Average is " + avg);




            // 2.WAP to display sum of 3 by 3 matrices
            int[,] num1 = new int[3, 3];
            int sum1 = 0;

            Console.WriteLine("Enter Numbers to display sum of 3 by 3 matrices ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    num1[i, j] = Convert.ToInt16(Console.ReadLine());
                    sum1 = sum1 + num1[i, j];
                }
            }
            Console.WriteLine("Numbers are");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(num1[i, j] + "\t");
                }
                Console.WriteLine();

            }
            Console.WriteLine(" sum of 3 by 3 matrics is " + sum1);



            //3. WAP to find the maximum element of an integer Array
            int[] arr = new int[6];
            int max = arr[0];
            int a;
            Console.WriteLine("Enter numbers in array to get the maximum element of an integer Array ");
            for (a = 0; a <arr.Length-1; a++)
            {
                arr[a] = Convert.ToInt32(Console.ReadLine());
               
            }
            for (a = 1; a <= arr.Length-1; a++)
            {
                if (max < arr[a])
                {
                    max = arr[a];
                }
            }
           
            Console.WriteLine("Maximum element in array is {0} ", max);



            //4. WAP to print column wise sum of elements of 2 D Array
            int[] csum = new int[2];
            Console.WriteLine("Enter Numbers to print column wise sum of elements of 2D Array ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    num1[i, j] = Convert.ToInt16(Console.ReadLine());

                }
            }
            Console.WriteLine("Entered 2D array is ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(num1[i, j] + "\t");
                }
                Console.WriteLine();

            }
            Console.WriteLine("Sum of columns of the 2D matrix are");
            for (int i = 0; i < 2; i++)
            {
                csum[i] = 0;
                for (int j = 0; j < 2; j++)
                    csum[i] = csum[i] + num1[j, i];
            }

            for (int j = 0; j < 2; j++)
            {
                Console.Write("{0}   ", csum[j]);
            }



            //5. WAP to print row wise sum of elements of 2 D Array
            Console.WriteLine("\n");
            int[] rsum = new int[2];
            Console.WriteLine("Sum of rows of the 2D matrix are");
            for (int i = 0; i < 2; i++)
            {
                rsum[i] = 0;
                for (int j = 0; j < 2; j++)
                    rsum[i] = rsum[i] + num1[i, j];
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write("{0}    ", num1[i, j]);
                Console.Write("{0}    ", rsum[i]);
                Console.Write("\n");
            }


        }
    }


}
