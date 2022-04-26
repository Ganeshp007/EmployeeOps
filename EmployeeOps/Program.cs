// See https://aka.ms/new-console-template for more information
class Exception
{
public const int Is_Fulltime = 1;
public const int Is_Parttime = 2;
public const int Emp_Rate_Hr = 20;
public const int Working_Days = 20;

   static void Main(String[] agrs)
   
   {
            Console.WriteLine("----- Welcome to Employee Management System -----\n");
            Console.ReadKey();

        int Emp_Hr = 0;
        int Emp_wage = 0;
        int Total_wages = 0;

        //In this program we are using Switch case instead of if-else
        for (int i = 1; i <= Working_Days; i++)
        {
            Random obj = new Random();
            int empcheck = obj.Next(0, 3); //it will generate 0 and 1 only bcoz its limit is n-1 ie 2-1=1

            switch (empcheck)
            {
                case Is_Fulltime:
                    Emp_Hr = 8;
                    break;

                case Is_Parttime:
                    Emp_Hr = 4;
                    break;

                default:
                    break;
            }
            Emp_wage = Emp_Rate_Hr * Emp_Hr;
            Console.WriteLine("Day "+i+" wages:- "+Emp_wage);
            Total_wages += Emp_wage;
        }
            
        Console.WriteLine("\nWages of current Empolyee for 20 days :- " +Total_wages);


   }


}