

using System.Globalization;

Console.WriteLine("Digite 3 valores: ");
string[] valor = Console.ReadLine().Split(' ');

double A = double.Parse(valor[0], CultureInfo.InvariantCulture);
double B = double.Parse(valor[1], CultureInfo.InvariantCulture);
double C = double.Parse(valor[2], CultureInfo.InvariantCulture);
double delta = (Math.Pow(B, 2) - (4 * A * C));
double R1 = (-B + (Math.Sqrt(delta))) / (2 * A);
double R2 = (-B - (Math.Sqrt(delta))) / (2 * A);

if (A == 0 || delta < 0)
{
    Console.WriteLine("Impossivel calcular");
}
else
{
    Console.WriteLine("R1 = " + R1.ToString("N5", CultureInfo.InvariantCulture));
    Console.WriteLine("R2 = " + R2.ToString("N5", CultureInfo.InvariantCulture));

}

