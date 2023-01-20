

using System.Globalization;

Console.WriteLine("Digite 3 numeros: ");
string[] valor = Console.ReadLine().Split(" ");

double A = double.Parse(valor[0], CultureInfo.InvariantCulture);
double B = double.Parse(valor[1], CultureInfo.InvariantCulture);
double C = double.Parse(valor[2], CultureInfo. InvariantCulture);
double pi = 3.14159;

double triangulo = (A * C) / 2;
double circulo = Math.Pow(C, 2) * pi;
double trapezio = ((A + B) * C) / 2;
double quadrado = Math.Pow(B,2);
double retangulo = (A * B);


Console.WriteLine(("TRIANGULO: " + triangulo.ToString("N3", CultureInfo.InvariantCulture)));
Console.WriteLine("CIRCULO: " + circulo.ToString("N3", CultureInfo.InvariantCulture));
Console.WriteLine("TRAPEZIO: " + trapezio.ToString("N3", CultureInfo.InvariantCulture));
Console.WriteLine("QUADRADO: " + quadrado.ToString("N3", CultureInfo.InvariantCulture));
Console.WriteLine("RETANUGLO: " + retangulo.ToString("N3", CultureInfo.InvariantCulture));







