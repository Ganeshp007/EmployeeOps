// See https://aka.ms/new-console-template for more information
class Exception
{
public const int Is_Fulltime = 1;
public const int Is_Parttime = 2;
public const int Emp_Rate_Hr = 20;

   static void Main(String[] agrs)
   
   {

            int Emp_Hr = 0;
            int Emp_wage = 0;
            Random obj = new Random();
            int empcheck = obj.Next(0, 3); //it will generate 0 and 1 only bcoz its limit is n-1 ie 2-1=1

            Console.WriteLine("----- Welcome to Employee Management System -----\n");
            Console.ReadKey();

            //In this program we are using Switch case instead of if-else

            switch (empcheck)
             {
                case Is_Fulltime:
                    Console.WriteLine("Employee is Fulltime");
                    Emp_Hr = 8;
                    break;

                case Is_Parttime:
                    Console.WriteLine("Employee is Parttime");
                    Emp_Hr = 4;
                    break;

                default:
                    Console.WriteLine("Employee is Absent");
                    break;
             }
            Emp_wage = Emp_Rate_Hr * Emp_Hr;
            Console.WriteLine("\nDailywage of current Empolyee is :- " + Emp_wage);


   }


}