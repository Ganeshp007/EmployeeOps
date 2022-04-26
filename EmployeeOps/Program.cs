// See https://aka.ms/new-console-template for more information
class Exception
{
    public const int Is_Fulltime = 1;
    public const int Is_Parttime = 2;
    public const int Emp_Rate_Hr = 20;
    public const int Max_Working_Days = 20;
    public const int Max_Working_Hr = 100;
  
    static void Main(String[] agrs)
   
   {
            Console.WriteLine("----- Welcome to Employee Management System -----\n");
            Console.ReadKey();

        int Emp_Hr = 0;
        int Emp_wage = 0;
        int Emp_present_wage=0;
        int Total_Emp_wage = 0;
        int Total_Working_Hr = 0;
        int Total_Working_Days=1;
        while(Total_Working_Hr<=Max_Working_Hr && Total_Working_Days<=Max_Working_Days)
        {
            Random obj = new Random();
            int empcheck = obj.Next(0, 3);

            switch (empcheck)
            {
                case Is_Fulltime:
                    Emp_Hr = 8;
                    break;

                case Is_Parttime:
                    Emp_Hr = 4;
                    break;

                default:
                    Emp_Hr = 0;
                    break;
            }
            Emp_wage = Emp_Rate_Hr * Emp_Hr;
            Emp_present_wage += Emp_wage;
            Total_Working_Hr += Emp_Hr;
            Console.WriteLine("Day:- "+Total_Working_Days+" Total Working Hrs till now:- "+Total_Working_Hr+" Total wages till now :- "+Emp_present_wage);

            Total_Working_Days++;
        }
        Console.WriteLine(Total_Working_Hr);

        Total_Emp_wage = Total_Working_Hr * Emp_Rate_Hr;    
        Console.WriteLine("\nWages of current Empolyee of 100 Hrs in 20 days :- " +Total_Emp_wage);


   }


}