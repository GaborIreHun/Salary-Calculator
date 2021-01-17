
class SalaryCalculator
{

    public int hoursWorked;

    public string employeeName;

    public decimal hourlyPay;

    public int normalHours;

    public int excessHours;

    public decimal overTime;

    double increment = 1.5;

    


    public void SetHoursWorked(int salaryCalculatorHoursWorked)
    {
        hoursWorked = salaryCalculatorHoursWorked;
    }

    public int GetHoursWorked()
    {
        return hoursWorked;
    }

    public void SetEmployeeName(string salaryCalculatorEmployeeName)
    {
        employeeName = salaryCalculatorEmployeeName;
    }

    public string GetEmployeeName()
    {
        return employeeName;
    }

    public void SetHourlyPay(decimal salaryCalculatorHourlyPay)
    {
        hourlyPay = salaryCalculatorHourlyPay;
    }

    public decimal GetHourlyPay()
    {
        return hourlyPay;
    }

    public int ExcessHours()
    {
        if(hoursWorked > 40)
        {
            excessHours = hoursWorked - 40;
            return excessHours;
        }
        else
        {
            excessHours = 0;
            return excessHours;
        }
        
    }

    public decimal OverTime()
    {
        overTime = excessHours * (decimal)increment;
        return overTime;
    }

    public int NormalHours()
    {
        if (hoursWorked > 40)
        {
            normalHours = hoursWorked - excessHours;
            return normalHours;
        }
        else
        {
            normalHours = hoursWorked;
            return normalHours;
        }
            
    }

}

