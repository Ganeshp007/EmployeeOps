// See https://aka.ms/new-console-template for more information

int Is_Fulltime = 1;
int Emp_Rate_Hr = 20;
int Emp_Hr = 0;
int Emp_wage = 0;   
Random obj=new Random();
int empcheck=obj.Next(0,2); //it will generate 0 and 1 only bcoz its limit is n-1 ie 2-1=1

Console.WriteLine("----- Welcome to Employee Management System -----\n");
Console.ReadKey();

if(empcheck == Is_Fulltime)
{
    Console.WriteLine("Employee is Present");
    Emp_Hr = 8;
}
else
{
    Console.WriteLine("Employee is Absent");
}

Emp_wage = Emp_Rate_Hr * Emp_Hr;
Console.WriteLine("\nDailywage of current Empolyee is :- "+Emp_wage);

