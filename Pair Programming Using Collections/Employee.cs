using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming_Using_Collections
{
    public class Employee
    {
        // Employee properties
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public double RateofPay { get; set; }
        public double HoursWorked { get; set; }

        // This constructor takes every property value as a parameter
        public Employee(int EmpID, string EmpName, double ROPay, double Hours)
        {
            EmployeeID = EmpID;
            EmployeeName = EmpName;
            RateofPay = ROPay;
            HoursWorked = Hours;
        }

        // Declare total pay variables
        public static double RegularPayTotal = 0;
        public static double OverTimeTotal = 0;
        public static double Grandtotal = 0;

        // Returns total of an employee's regular pay
        public double CalculateRegPay()
        {
            double regPay = 0;
            if (HoursWorked <= 40)
            {
                regPay = (HoursWorked * RateofPay);
                return regPay;
            }
            else
            {
                regPay = (40 * RateofPay);
                return regPay;
            }
        }

        // Returns total of
        public double CalculateOvertime()
        {
            double overtime = 0;
            if (HoursWorked > 40)
            {
                overtime = (HoursWorked - 40) * (RateofPay * 1.5);
                return overtime;
            }
            else
            {
                return overtime;
            }
        }

        public double CalculatePay(double RateofPay, double HoursWorked)
        {
            if (HoursWorked <= 40)
            {
                double RegPay = RateofPay * HoursWorked;
                Grandtotal += RegPay;
                RegularPayTotal += RegPay;
                return RegPay;

            }
            else
            {
                //calculating Employees who worked more than 40 hours
                double OverPay = (CalculateOvertime() + (40 * RateofPay));
                OverTimeTotal += CalculateOvertime();
                RegularPayTotal += CalculateRegPay();
                Grandtotal += OverPay;
                return OverPay;
            }
        }

    }
}
