// See https://aka.ms/new-console-template for more information

int Is_Fulltime = 1;
Random obj=new Random();
int empcheck=obj.Next(0,2);//it will generate 0 and 1 only bcoz its limit is n-1 ie 2-1=1

Console.WriteLine("----- Welcome to Employee Management System -----\n");
Console.ReadKey();

if(empcheck == Is_Fulltime)
{
    Console.WriteLine("Employee is Present");
}
else
{
    Console.WriteLine("Employee is Absent");
}

