using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercies
{
    public abstract class Employee
    {
        protected string firstName;
        protected string lastName;
        protected string SSN;

        public string getFirstName()
        {
            return firstName;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string getSSN()
        {
            return SSN;
        }

        public void setSSN(string SSN)
        {
            this.SSN = SSN;
        }

        public Employee(string firstName, string lastName, string SSN)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.SSN = SSN;
        }

        public abstract double Earnings();

        public override string ToString()
        {
            return "Employee: " + firstName + " " + lastName +
                   ", Social security number: " + SSN;
        }
    }

    public class SalariedEmployee : Employee
    {
        private double weeklySalary;

        public double getWeeklySalary()
        {
            return weeklySalary;
        }

        public void setWeeklySalary(double weeklySalary)
        {
            this.weeklySalary = weeklySalary;
        }

        public SalariedEmployee(string firstName, string lastName, double weeklySalary)
            : base(firstName, lastName, "")
        {
            this.weeklySalary = weeklySalary;
        }

        public override double Earnings()
        {
            return weeklySalary;
        }

        public override string ToString()
        {
            return "Salaried employee: " + firstName + " " + lastName +
                   ", Social security number: " + SSN +
                   ", Weekly salary: " + weeklySalary;
        }
    }

    public class HourlyEmployee : Employee
    {
        private double wage;
        private double hours;

        public double getWage()
        {
            return wage;
        }

        public void setWage(double wage)
        {
            this.wage = wage;
        }

        public double getHours()
        {
            return hours;
        }

        public void setHours(double hours)
        {
            this.hours = hours;
        }

        public HourlyEmployee(string firstName, string lastName, double hours, double wage)
            : base(firstName, lastName, "")
        {
            this.hours = hours;
            this.wage = wage;
        }

        public override double Earnings()
        {
            if (hours <= 40)
                return hours * wage;
            else
                return 40 * wage + (hours - 40) * wage * 1.5;
        }

        public override string ToString()
        {
            return "Hourly employee: " + firstName + " " + lastName +
                   ", Social security number: " + SSN +
                   ", Hours worked: " + hours +
                   ", Hourly wage: " + wage;
        }
    }

    public class CommissionEmployee : Employee
    {
        protected double commissionRate;
        protected double grossSales;

        public double getCommissionRate()
        {
            return commissionRate;
        }

        public void setCommissionRate(double commissionRate)
        {
            this.commissionRate = commissionRate;
        }

        public double getGrossSales()
        {
            return grossSales;
        }

        public void setGrossSales(double grossSales)
        {
            this.grossSales = grossSales;
        }

        public CommissionEmployee(string firstName, string lastName, double grossSales, double commissionRate)
            : base(firstName, lastName, "")
        {
            this.grossSales = grossSales;
            this.commissionRate = commissionRate;
        }

        public override double Earnings()
        {
            return commissionRate * grossSales;
        }

        public override string ToString()
        {
            return "Commission employee: " + firstName + " " + lastName +
                   ", Social security number: " + SSN +
                   ", Gross sales: " + grossSales +
                   ", Commission rate: " + commissionRate;
        }
    }

    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        private double baseSalary;

        public double getBaseSalary()
        {
            return baseSalary;
        }

        public void setBaseSalary(double baseSalary)
        {
            this.baseSalary = baseSalary;
        }

        public BasePlusCommissionEmployee(
            string firstName,
            string lastName,
            double grossSales,
            double commissionRate,
            double baseSalary)
            : base(firstName, lastName, grossSales, commissionRate)
        {
            this.baseSalary = baseSalary;
        }

        public override double Earnings()
        {
            return commissionRate * grossSales + baseSalary;
        }

        public override string ToString()
        {
            return "Base salaried commission employee: " +
                   firstName + " " + lastName +
                   ", Social security number: " + SSN +
                   ", Gross sales: " + grossSales +
                   ", Commission rate: " + commissionRate +
                   ", Base salary: " + baseSalary;
        }
    }
}
