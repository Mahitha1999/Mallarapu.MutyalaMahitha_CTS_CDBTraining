using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class second
    {
        static void Main()
        {
            //2. WAP to add three numbers
            Console.WriteLine("Enter three numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sum of three numbers " + a + "," + b + " and " + c + " is " + (a + b + c));

            //3. WAP to print sum and average of 1st 20 natural numbers
            int i;
            int sum =0;
            int avg = 0;
            for(i=0;i<=20;i++)
            {
                sum += i;
            }
            Console.WriteLine("sum of 1st 20 natural numbers is " + sum);
            avg = sum / 20;
            Console.WriteLine("avg of 1st 20 natural numbers is " + avg);


            //4. WAP to print first 50 even numbers
            Console.WriteLine("first 50 even numbers are");
            for(i = 2; i <= 50; i+=2)
                {
                Console.WriteLine("{0}",i);
            }

            //5. WAP to check whether a number is prime or not
            int j;
            Console.WriteLine("Enter any number to check whether it is prime or not");
            int n= Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for (j = 2; j <= n-1; j++)
            {
                if (n % j == 0)
                {
                    Console.WriteLine("\nEntered Number is Not Prime");
                    flag = 1;
                    break;
                }

            }
            if (flag == 0)
            {
                Console.WriteLine("\nEntered Number is Prime");

            }

           


            //6. WAP to print table of entered number
            int m;
            Console.WriteLine("Enter a number to get table");
             m= Convert.ToInt32(Console.ReadLine());
            int t = 0;
            for(i=1;i<=10;i++)
            {
                t = m * i;

                Console.WriteLine("{0} * {1} = {2}", m, i, t);
            }



            //7.WAP to take some numbers from user..
           
           Console.WriteLine("Enter a number to Print");

           int p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entered number is {0}",p);
           
            
            /*7.difference between ToIn16, ToInt32 , ToByte and other methods available
            The Convert.ToInt16() method returns the 16-bit integer e.g. short, the Convert.ToInt32() returns 32-bit integers e.g. int and the Convert.ToInt64() returns the 64-bit integer e.g. long. */

            /*8. What is System in the program. What are Console and Convert? What are Write, WriteLine , ReadLine and ToByte
            system  : system is a namespace, namespace is logical collection of related classes
            Console : Console is a class which is present in the namespace
            Write, WriteLine :The most common method to output something in C# is WriteLine() and Write().
                        The difference is that WriteLine() prints the output on a new line each time, while Write() prints on the same line
            Convert : this is used to convert one data type to other data type
            ReadLine : it is a input statement to take values
            ToByte : it is used to conver data into bytes */


            /*9. Is it mandatory to have a class in the project
              Yes, C# application must have at least one class with Main method, so that execution can begin from it.*/


            /*10. Why is static added to Main() method?
              A main method is static since it is available to run when the C# program starts. It is the entry point of the program and runs without even creating an instance of the class.*/


        }
    }
}
