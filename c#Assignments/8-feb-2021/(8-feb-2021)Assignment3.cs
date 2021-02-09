using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            // 1.Write a program in C# Sharp to count a total number of duplicate elements in an array using System;
            int[] num = new int[10];
            int count = 0;
            Console.WriteLine("Enter 10 numbers to count a total number of duplicate elements in an array");
            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToInt16(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (num[i] == num[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("The total number of duplicate elements in the array is " + count);


            /*2.WAP to find the eligibility of admission for a professional course based on the following criteria:
             Marks in Maths >= 65
             Marks in Phy >= 55
             Marks in Chem >= 50
            Total in all three subject >= 180
             or
           Total in Math and Phy >= 140


            Test Data :
            Input the marks obtained in Physics :65
            Input the marks obtained in Chemistry :51
            Input the marks obtained in Mathematics :72
            Expected Output :
            The candidate is eligible for admission.*/
            int maths, phy, chem;
            Console.WriteLine("Input the marks obtained in Physics :");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Chemistry :");
            chem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Mathematics :");
            maths = Convert.ToInt32(Console.ReadLine());
            int total_3sub = maths + phy + chem;
            int total_math_phy = maths + phy;

            if ((maths >= 65) && (phy >= 55) && (chem >= 50))
            {
                if ((total_3sub >= 180) || (total_math_phy >= 140))
                    Console.WriteLine("\nThe candidate is eligible for admission.");
            }
            else
                Console.WriteLine("The candidate is not eligible for admission.");

            /*3.Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. The customer id., name and unit consumed by the user should be taken
          * from the keyboard and display the total amount to pay to the customer. The charge are as follow : 

               Unit                                   Charge / unit
               upto 199                            @1.20
               200 and above but less than 400         @1.50
               400 and above but less than 600         @1.80
               600 and above	                        @2.00

             If bill exceeds Rs. 400 then a surcharge of 15 % will be charged and the minimum bill should be of Rs. 100 / -
   
              Test Data:
              1001
              James
              800
              Expected Output :
              Customer IDNO :1001
              Customer Name :James
              unit Consumed: 800
              Amount Charges @Rs. 2.00 per unit : 1600.00
              Surchage Amount : 240.00
              Net Amount Paid By the Customer : 1840.00*/

            double charge = 0;
            double sur_charge = 0;
            double net_Amount = 0;

            Console.WriteLine("Customer INDO :");
            int Cus_ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Customer Name :");
            string Cus_Name = Console.ReadLine();
            Console.WriteLine("Unit Consumed :");
            double Units = Convert.ToInt32(Console.ReadLine());
            if (Units <= 199)
            {
                charge = Units * 1.20;
                Console.WriteLine("Amount charges for @Rs1.20 per unit : {0}", charge);
            }
            else if ((Units >= 200) && (Units < 400))
            {
                charge = Units * 1.50;
                Console.WriteLine("Amount charges for @Rs1.50 per unit : {0}", charge);
            }
            else if ((Units >= 400) && (Units < 600))
            {
                charge = Units * 1.80;
                Console.WriteLine("Amount charges for @Rs1.80 per unit : {0}", charge);
            }
            else if (Units >= 600)
            {
                charge = Units * 2.00;
                Console.WriteLine("Amount charges for @Rs2.00 per unit : {0}", charge);

            }
            else
            {
                Console.WriteLine("Invalid number");
            }

            if (charge > 400)
            {
                sur_charge = (charge * 15 / 100);
            }
            Console.WriteLine("Surcharge Amount :{0}", sur_charge);
            net_Amount = charge + sur_charge;

            if (net_Amount < 100)

                net_Amount = 100;


            Console.WriteLine("Net Amount Paid By the Customer :{0}", net_Amount);

        }
    }
}






