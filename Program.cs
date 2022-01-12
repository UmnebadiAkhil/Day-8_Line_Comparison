// See https://aka.ms/new-console-template for more information
using LineComparisonProblem;

Console.WriteLine("\n Hello, World!");
Console.WriteLine("\n Welcome to Line Comparison Computation Program on Master Branch");

Console.WriteLine("Enter X1 value :-");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y1 value :-");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter X2 value :-");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y2 value :-");
int Y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n ---------------------------------------------------------------\n ");

bool flag = true;
while (flag)
{
    Console.WriteLine("Enter the program number which is to be executed \n 1.UC-1, \n 2.UC-2, \n 3.UC-3, \n 4.UC-4, \n 5.Exit");
    int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        LineComparisonProblem.UC1 uc1 = new LineComparisonProblem.UC1();
        uc1.LengthOfLine(X1, X2, Y1, Y2);
        break;
    case 2:
        UC_2 uc2 = new UC_2();
        uc2.Equals(X2, X1, Y1, Y2);
        break;
    case 3:
        UC_3 uc_3 = new UC_3();
        uc_3.Comparision(X1, X2, Y1, Y2);
        break;
    case 4:
        UC_4 uc_4 = new UC_4();
        uc_4.Comparision1(X1, X2, Y1, Y2);
        break;
    case 5:
        flag = false;
        break;
}
}