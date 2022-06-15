Console.WriteLine("Welcome to line Comparison Program");
int x1 = Convert.ToInt32(Console.ReadLine()), x2 = Convert.ToInt32(Console.ReadLine()),
    y1 = Convert.ToInt32(Console.ReadLine()), y2 = Convert.ToInt32(Console.ReadLine());
int z1 = x2 - x1;
int z2 = y2 - y1;
double num1 = Math.Pow(z1, 2);
double num2 = Math.Pow(z2, 2);
double distance = Math.Sqrt(num1 + num2);
Console.WriteLine("distance : " +distance);