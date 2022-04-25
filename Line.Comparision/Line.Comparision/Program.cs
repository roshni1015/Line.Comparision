// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Line comparision!");
Console.WriteLine("Please Enter x1 and y1 coordinates :");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter x2 and y2 coordinates :");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double finalResult = Distance(x1, x2, y1, y2);

Console.WriteLine("Distance between {0},{1} and  {2},{3} is {4:F}", x1, y1, x2, y2, finalResult);

static double Distance(double x1, double x2, double y1, double y2)
{
    var temp1 = Math.Pow((x2 - x1), 2);
    var temp2 = Math.Pow((y2 - y1), 2);
    var result = Math.Sqrt(temp1 + temp2);
    return result;
}

