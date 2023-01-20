

using System.Globalization;

Console.WriteLine("Digite 3 valores");
String[] valores = Console.ReadLine().Split(" ");

double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
double C = double.Parse(valores[2], CultureInfo.InvariantCulture);
double perimetro = A + B + C;
double trapezio = ((A + B) * C) / 2;

if (A+B > C && B+C > A && C+A > B)
{
    Console.WriteLine("Perimetro = " + perimetro.ToString("N1", CultureInfo.InvariantCulture));
}
else
{
    Console.WriteLine("Area = " + trapezio.ToString("N1", CultureInfo.InvariantCulture));
}