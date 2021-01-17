using System;

class SalaryCalculatorTest
{
    static void Main()
    {
        SalaryCalculator salaryCalculator1 = new SalaryCalculator();
        SalaryCalculator salaryCalculator2 = new SalaryCalculator();
        SalaryCalculator salaryCalculator3 = new SalaryCalculator();

        Console.Write("Please enter the name of the 1st employee: ");
        string salaryCalculator1theEmployeetheName = Console.ReadLine();
        salaryCalculator1.SetEmployeeName(salaryCalculator1theEmployeetheName);

        Console.Write($"Please enter the hourly wage of {salaryCalculator1.GetEmployeeName()}: ");
        decimal salaryCalculator1theHourlyPay = decimal.Parse(Console.ReadLine());
        salaryCalculator1.SetHourlyPay(salaryCalculator1theHourlyPay);

        Console.Write($"Please enter the hours worked by {salaryCalculator1.GetEmployeeName()}: ");
        int salaryCalculator1theHoursWorked = int.Parse(Console.ReadLine());
        salaryCalculator1.SetHoursWorked(salaryCalculator1theHoursWorked);

        Console.Write("\n\nPlease enter the name of the 2nd employee: ");
        string salaryCalculator2theEmployeetheName = Console.ReadLine();
        salaryCalculator2.SetEmployeeName(salaryCalculator2theEmployeetheName);

        Console.Write($"Please enter the hourly wage of {salaryCalculator2.GetEmployeeName()}: ");
        decimal salaryCalculator2theHourlyPay = decimal.Parse(Console.ReadLine());
        salaryCalculator2.SetHourlyPay(salaryCalculator2theHourlyPay);

        Console.Write($"Please enter the hours worked by {salaryCalculator2.GetEmployeeName()}: ");
        int salaryCalculator2theHoursWorked = int.Parse(Console.ReadLine());
        salaryCalculator2.SetHoursWorked(salaryCalculator2theHoursWorked);

        Console.Write("\n\nPlease enter the name of the 3rd employee: ");
        string salaryCalculator3theEmployeetheName = Console.ReadLine();
        salaryCalculator3.SetEmployeeName(salaryCalculator3theEmployeetheName);

        Console.Write($"Please enter the hourly wage of {salaryCalculator3.GetEmployeeName()}: ");
        decimal salaryCalculator3theHourlyPay = decimal.Parse(Console.ReadLine());
        salaryCalculator3.SetHourlyPay(salaryCalculator3theHourlyPay);

        Console.Write($"Please enter the hours worked by {salaryCalculator3.GetEmployeeName()}: ");
        int salaryCalculator3theHoursWorked = int.Parse(Console.ReadLine());
        salaryCalculator3.SetHoursWorked(salaryCalculator3theHoursWorked);

        Console.Write("\n\n");

        PrintSalary(salaryCalculator1);
        
        PrintSalary(salaryCalculator2);
        
        PrintSalary(salaryCalculator3);
                
    }   

    static void PrintSalary(SalaryCalculator all)
    {

        Console.Write($"{all.employeeName} has worked {all.hoursWorked} hours on the relevant week.");
        Console.WriteLine($"The hourly pay of {all.employeeName} is {all.hourlyPay}.");
        Console.WriteLine($"He/she has {all.ExcessHours()} hour(s) overtime.");
        Console.WriteLine($"The total pay for the week of {all.employeeName} is {(all.OverTime() + all.NormalHours()) * all.hourlyPay}.\n");
        
    }
}

