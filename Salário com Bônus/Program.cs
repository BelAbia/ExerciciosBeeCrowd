using System.Globalization;

String nome;
double salarioFixo = 0;
double vendasPorMes = 0;

Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Digite seu salário fixo mensal: ");
salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Digite a quantidade de vendas mensal(em dinheiro): ");
vendasPorMes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double comissao = vendasPorMes * 0.15;

double total = (vendasPorMes * 0.15) + salarioFixo;

Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));









