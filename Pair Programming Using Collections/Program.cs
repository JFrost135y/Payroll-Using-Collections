using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pair_Programming_Using_Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(223445, "John Landry", 15.00, 35.5));
            employees.Add(new Employee(223476, "Angela Rush", 15.00, 32.25));
            employees.Add(new Employee(223487, "Bill Marsh", 16.50, 45.5));
            employees.Add(new Employee(223504, "Peggy Simon", 16.75, 50));
            employees.Add(new Employee(223512, "Carl Yost", 15.75, 40));
            employees.Add(new Employee(223519, "Joe Miles", 15.00, 40));
            employees.Add(new Employee(223525, "Joan Jeffries", 14.25, 25.75));
            employees.Add(new Employee(223536, "George Mills", 13.65, 38));
            employees.Add(new Employee(223542, "Gary Cooper", 15.35, 37.25));
            employees.Add(new Employee(223558, "Mary Millicent", 15.75, 40));

            

            Console.WriteLine($"EmployeeID:     Employee Name:        Rate of Pay:     Hours Worked:            Regular Pay:           Overtime Pay:         Pay Total:");

            foreach (var item in employees)
            {
               
                Console.WriteLine
                    (
                    $"{item.EmployeeID,10 }"           +          
                    $"{item.EmployeeName, 18}"         +    
                    $"{item.RateofPay, 18:C}"          +     
                    $"{item.HoursWorked, 22}"          +   
                    $"{item.calculateRegPay(), 20:C}"  + 
                    $"{item.calculateOvertime(), 23:C}"+ 
                    $"{item.calculatepay(item.RateofPay, item.HoursWorked),22:C}"
                    );
                
            }
            Console.WriteLine($"\nRegular pay total:{Employee.RegularPayTotal:C}\n");
            Console.WriteLine($"\nOvertime total:{Employee.OverTimeTotal:C}\n");
            Console.WriteLine($"\nGrandtotal:{Employee.Grandtotal:C}\n");
        }


   
  
    }
}
