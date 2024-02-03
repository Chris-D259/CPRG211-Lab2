using System.ComponentModel;

namespace CPRG211___Lab_2
{
    class Program
    {
        static void Main(string[] args)  
        {

            //Declare Full File Path of File in res Folder
            string filepath = "C:\\Users\\Criff\\Downloads\\CPRG211 - Lab 2\\CPRG211 - Lab 2\\res\\employees.txt";
            //Initialize Counting Variables
            double salariedEmployeeCount = 0;
            double wagesEmployeeCount = 0;
            double partTimeEmployeeCount = 0;
            double employeeCount = 0;

            //Initialize Highest Weekly Pay at 0
            double highestWeeklyPay = 0;

            //Initialize Lowest Salary as Large Number
            double lowestSalary = 9999999999999;

            //Initialize Salary Count variable
            double TotalEmployeeSalary = 0;

            //Initialize Strings to hold Highest and Lowest Paid Names 
            string highestWeeklyPayName = "";
            string lowestSalaryName = "";
            

            //Create List of Employees using Employee Class
            List<Employee> employeeList = new List<Employee>();

            //Add Each Line to String Array
            string[] employeeLines = File.ReadAllLines(filepath);

            //For Each String of Employee Line within Array
            foreach(string employeeLine in employeeLines)
            {
                //Split String of Employee Line using delimeter of :
                string[] employeeParts = employeeLine.Split(':');

                //Obtain first char using index 0,0 (first string and first character within that string)
                char firstIdNum = employeeParts[0][0];

                //Convert First Char to Int using ASCII Values
                int firstNum = firstIdNum - '0';

                //Logic to Check ID Number
                if(firstNum <= 4) 
                {
                    //Add Split String to Corresponding Variables
                    Salaried SalariedEmployee = new Salaried(employeeParts[0], employeeParts[1], employeeParts[2], employeeParts[3], long.Parse(employeeParts[4]), employeeParts[5], employeeParts[6], double.Parse(employeeParts[7]));
                    //Add New Salaried Employee to Employee List
                    employeeList.Add(SalariedEmployee);
                    //Increment Salaried Employee Count
                    salariedEmployeeCount++;
                    //Increment Total Employee Count
                    employeeCount++;

                    //Add Salary to Totals
                    TotalEmployeeSalary += SalariedEmployee.GetPay();

                    //Logic to Check for Lowest Salary
                    if(SalariedEmployee.GetPay() < lowestSalary)
                    {
                        //Set the Lowest Salary Variable to the Instance Value
                        lowestSalary = SalariedEmployee.GetPay();
                        //Set the Name to the Instance Value
                        lowestSalaryName = employeeParts[1];

                    }
                }

                else if (firstNum <= 7) 
                {
                    //Add Split String to Corresponding Variables
                    Wages WagesEmployee = new Wages(employeeParts[0], employeeParts[1], employeeParts[2], employeeParts[3], long.Parse(employeeParts[4]), employeeParts[5], employeeParts[6], double.Parse(employeeParts[7]), double.Parse(employeeParts[8]));

                    //Add New Wages Employee to Employee List
                    employeeList.Add(WagesEmployee);

                    //Increment Wages Employee Count
                    wagesEmployeeCount++;
                    //Increment Total Employee Count
                    employeeCount++;
                    //Add Salary to Totals
                    TotalEmployeeSalary += WagesEmployee.GetPay();
                    //Logic to Check for Highest Pay
                    if (WagesEmployee.GetPay() > highestWeeklyPay) 
                    { 
                        //Set Highest Pay to Instance Value
                        highestWeeklyPay = WagesEmployee.GetPay();
                        //Set Name Variable to Instance Value
                        highestWeeklyPayName = employeeParts[1];
                    }
                }

                else if(firstNum <= 9) 
                {
                    //Add Split String to Corresponding Variables
                    PartTime partTimeEmployee = new PartTime(employeeParts[0], employeeParts[1], employeeParts[2], employeeParts[3], long.Parse(employeeParts[4]), employeeParts[5], employeeParts[6], double.Parse(employeeParts[7]), double.Parse(employeeParts[8]));
                    //Add New Wages Employee to Employee List
                    employeeList.Add(partTimeEmployee);
                    //Increment Part Time Employee count 
                    partTimeEmployeeCount++;
                    //Increment Total Employee Count
                    employeeCount++;
                    //Add Salary to Total Salary
                    TotalEmployeeSalary += partTimeEmployee.GetPay();
                }

                //Else Statement to Catch Errors and Alert Programmer
                else
                {
                    Console.WriteLine("Value Not Found");
                }

            }
            //Calculate Average weekly Salary for all employees
            double averageSalary = TotalEmployeeSalary / employeeCount;

            //Calculate Percentage of Salaried Employees
            double percentSalaried = salariedEmployeeCount/ employeeCount*100;

            //Calculate Percentage of Waged Employees
            double percentWaged = wagesEmployeeCount/ employeeCount * 100;

            //Calculate Percentage of Part Time Employees
            double percentPartTime = partTimeEmployeeCount/ employeeCount * 100;

            //Output to Console
            Console.WriteLine($"Average Weekly Pay for all Employees is ${averageSalary:F2}");
            Console.WriteLine($"Highest Weekly Pay for Wage Employees is ${highestWeeklyPay:F2} received by {highestWeeklyPayName}");
            Console.WriteLine($"Lowest Salary for Salaried Employees is ${lowestSalary:F2} received by {lowestSalaryName}");
            Console.WriteLine($"There are {employeeCount} Employees. The Percentage of Employees are as Follows:");
            Console.WriteLine($"Salaried Employees: {percentSalaried:F2}%");
            Console.WriteLine($"Wage Employees: {percentWaged:F2}%");
            Console.WriteLine($"Part Time Employees: {percentPartTime:F2}%");


        }
        }
    }

