/*Assignment No : 3


1.Create a class Employee with following attributes 
  Empid
  Name
  dept
  Manager
  Basic Salary
  Exp
  Company Name
  Company Address


  Depending upon Exp, calculate Net Salary
if exp > 10 years , DA = 10 % of basic, HRA = 8.5 % of basic , PF = 6200
if exp > 7 years and less than 10 years , DA = 7 % of basic, HRA = 6.5 % of basic , PF = 4100
if exp > 5 years and less than 7 years, DA = 4.1 % of basic, HRA = 3.8 % of basic , PF = 1800
if exp < 10 years , DA = 1.9 % of basic, HRA = 2.0 % of basic , PF = 1200

Display the details in proper way

 You are supposed to do it for some Employees, count is not known. Which loop you will use? 

  1. Understand how you will make this class and add data members
  2. Create Methods accoringly:
      a.We know name , dept and manager of Employee
      b. We know employee id, name, department of Employee
      c. We know all details about Employee
  3. Print total number of Employees
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb10Assignment
{
    class Employee
    {
        public int employeeId;
        public string name;
        public string department;
        public string manager;
        public double basicSalary;
        public int experience;
        public static string companyName;
        public static string companyAddress;
        double DA, HRA, PF, NetSalary;

        public Employee() { }
        public Employee(string name, string department, string manager)
        {
            this.name = name;
            this.department = department;
            this.manager = manager;
        }
        public Employee(string name, int employeeId, string department)
        {
            this.name = name;
            this.employeeId = employeeId;
            this.department = department;
        }
        public Employee(int employeeId, string name,  string department, string manager, double basicSalary, int experience)
        {
            this.name = name;
            this.employeeId = employeeId;
            this.department = department;
            this.manager = manager;
            this.basicSalary = basicSalary;
            this.experience = experience;
            //this.companyName = companyName;
            //  this.companyAddress = companyAddress;
        }
        public void GetEmployeeDetails()
        {
            Console.WriteLine("Enter Employee ID:");
            employeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Department:");
            department = Console.ReadLine();
            Console.WriteLine("Enter Manager:");
            manager = Console.ReadLine();
            Console.WriteLine("Enter Basic Salary:");
            basicSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Experience:");
            experience = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Company Name:");
            //companyName = Console.ReadLine();
            //Console.WriteLine("Enter Company Address:");
            //companyAddress = Console.ReadLine();
        }
        public void GetEmployeeDetails1()
        {
            Console.WriteLine("Enter Employee ID:");
            employeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Basic Salary:");
            basicSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Experience:");
            experience = Convert.ToInt32(Console.ReadLine());
        }
        public void GetEmployeeDetails2()
        {
            Console.WriteLine("Enter Manager:");
            manager = Console.ReadLine();
            Console.WriteLine("Enter Basic Salary:");
            basicSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Experience:");
            experience = Convert.ToInt32(Console.ReadLine());
        }
        public void GetEmployeeDetails3()
        {
            Console.WriteLine("Enter Manager:");
        }

            public void CalculateSalary()
        {
            if (experience <= 5)
            {
                DA = (1.9 * basicSalary) / 100;
                HRA = (2.0 * basicSalary) / 100;
                PF = 1200;
            }
            else if (experience > 5 && experience <= 7)
            {
                DA = (4.1 * basicSalary) / 100;
                HRA = (3.8 * basicSalary) / 100;
                PF = 1800;
            }
            else if (experience > 7 && experience <= 10)
            {
                DA = (7 * basicSalary) / 100;
                HRA = (6.5 * basicSalary) / 100;
                PF = 4100;
            }
            else if (experience > 10)
            {
                DA = (10 * basicSalary) / 100;
                HRA = (8.5 * basicSalary) / 100;
                PF = 6200;
            }

            NetSalary = (basicSalary + DA + HRA) - PF;
        }


        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID : " + employeeId);
            Console.WriteLine("Employee Name : " + name);
            Console.WriteLine("Departmrnt : " + department);
            Console.WriteLine("Manager : " + manager);
            Console.WriteLine("Basic Salary : " + basicSalary);
            Console.WriteLine("Experince :" + experience);
            //  Console.WriteLine("Company Name :" + companyName);
            // Console.WriteLine("Company Address : " + companyAddress);
            Console.WriteLine("DA : " + DA);
            Console.WriteLine("HRA : " + HRA);
            Console.WriteLine("PF : " + PF);
            Console.WriteLine("Net Salary : " + NetSalary);
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb10Assignment
{
    class EmployeeMain
    {

        static void Main()
        {
            Employee.companyName = "Cognizant";
            Employee.companyAddress = "Chennai";

            Console.WriteLine("Company Name :" + Employee.companyName);
            Console.WriteLine("Company Address : " + Employee.companyAddress);
            Console.WriteLine("Enter number of Employees :");
            int n = Convert.ToInt16(Console.ReadLine());

            Employee employee1 = new Employee(" Sireesha", "accounts", " Saranya");
            employee1.GetEmployeeDetails1();
            employee1.CalculateSalary();
            employee1.DisplayEmployeeDetails();

            Employee employee2 = new Employee("Mahitha", 2, "Hr");
            employee2.GetEmployeeDetails2();
            employee2.CalculateSalary();
            employee2.DisplayEmployeeDetails();

            Employee employee3 = new Employee(3," Mahitha", "accounts", " Saranya", 25000, 6);
            employee3.GetEmployeeDetails3();
            employee3.CalculateSalary();
            employee3.DisplayEmployeeDetails();


            Employee[] employee = new Employee[50];
            for (int i = 0; i < n-3; i++)
            {

                employee[i] = new Employee();
                employee[i].GetEmployeeDetails();
                employee[i].CalculateSalary();
                employee[i].DisplayEmployeeDetails();

            }
        }
    }

}