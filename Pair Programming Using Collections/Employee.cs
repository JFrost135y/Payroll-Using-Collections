using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming_Using_Collections
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public double RateofPay { get; set; }
        public double HoursWorked { get; set; }

        public Employee(int EmpID, string EmpName, double ROPay, double Hours)
        {
            EmployeeID = EmpID;
            EmployeeName = EmpName;
            RateofPay = ROPay;
            HoursWorked = Hours;
        }
        public static double RegularPayTotal = 0;
        public static double OverTimeTotal = 0;
        public static double Grandtotal = 0;


        public double calculateRegPay()
        {
            if (HoursWorked <= 40)
            {
                double RegPay = (HoursWorked * RateofPay);
                return RegPay;
            }
            else
            {
                double RegPay = (40 * RateofPay);
                return RegPay;
            }
        }
        public double calculateOvertime()
        {
            if (HoursWorked > 40)
            {
                
                double Overtime = (HoursWorked - 40) * (RateofPay * 1.5);
                return Overtime;
            }
            else
            {
                double Overtime = 0;
                return Overtime;
            }
        }


        public double calculatepay(double RateofPay, double HoursWorked)
        {
            
            

                if (HoursWorked <= 40)
                {
                    double RegPay = RateofPay * HoursWorked;
                    //Console.WriteLine($"\nEmployee Worked: {HoursWorked} and needs to get paid {RegPay:C}");
                    Grandtotal += RegPay;
                    RegularPayTotal += RegPay;
                    return RegPay;

                }

                else
                {
                    //calculating Employees who worked more than 40 hours
                    double OverPay = (calculateOvertime() + (40 * RateofPay));
                    //Console.WriteLine($"\nEmployee Worked: {HoursWorked} and needs to get paid {OverPay:C}");
                    OverTimeTotal += calculateOvertime();
                    RegularPayTotal += calculateRegPay();
                    Grandtotal += OverPay;
                    
                    return OverPay;
                }
               
            
        }

    }
}
