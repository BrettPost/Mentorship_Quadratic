// See https://aka.ms/new-console-template for more information

double a, b, c;
double disc, deno, x1, x2;

if (args.Length != 3)
{
    Console.WriteLine("Need 3 Numbers");
}

a = Convert.ToDouble(args[0]);
b = Convert.ToDouble(args[1]);
c = Convert.ToDouble(args[2]);

Console.WriteLine("(" + a + ")x^2+(" + b + ")x+(" + c + ")=0");

double part1 = b * -1;
double part2 = Math.Sqrt((b * b) - (4 * a * c));
double part3 = a * 2;
double result1 = (part1 + part2) / part3;
double result2 = (part1 - part2) / part3;

Console.WriteLine("Result with addition: " + result1);
Console.WriteLine("Result with subtraction: " + result2);
