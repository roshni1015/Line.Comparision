// See https://aka.ms/new-console-template for more information
using Line.Comparision;

Console.WriteLine("Welcome to Line comparision!");
Console.WriteLine("Please Enter x1 and y1 coordinates :");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter x2 and y2 coordinates :");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
Lengthoflines length = new();
EqualsMethods equal = new();
ComparetoMethods compare = new();
double finalResult = length.Distance(x1, x2, y1, y2);

Console.WriteLine("Distance between {0},{1} and  {2},{3} is {4:F}", x1, y1, x2, y2, finalResult);


Console.WriteLine("Please Enter p and q coordinates ");
double p = Convert.ToDouble(Console.ReadLine());
double q = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter x2 and y2 coordinates ");
double r = Convert.ToDouble(Console.ReadLine());
double s = Convert.ToDouble(Console.ReadLine());
double finalResult2 = length.Distance(p, r, q, s);
Console.WriteLine("Distance between {0},{1} and {2},{3} is {4:F}", p, q, r, s, finalResult2);
equal.equalsmethods( finalResult,  finalResult2);
compare.comparetomethods(finalResult, finalResult2);
