// See https://aka.ms/new-console-template for more information

using calc.Add;

class1 add = new class1();

Console.WriteLine("function 1");
Console.WriteLine("eneter 2 number :");
double x =Convert.ToDouble(Console.ReadLine());
double y =Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"sum: {add.add(x, y)} ");



Console.WriteLine("-------------------");

Console.WriteLine("function2 ");
Console.WriteLine( "enter 3 numbers");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"sum: {add.add(a,b,c)} ");

Console.WriteLine("--------------------");




Console.WriteLine("function3(integers only)");
Console.WriteLine("enter 3 numbers");
double num1 = Convert.ToDouble(Console.ReadLine());
double num2 = Convert.ToDouble(Console.ReadLine());
double num3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"sum: {add.add(num1,num2,num3)} ");





Console.WriteLine("--------------------");




Console.WriteLine("function 4");
Console.WriteLine("enter your salary");
double salary = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter your working hours");
int work_hours=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"sum: {add.salary(salary , work_hours)} ");

