

int A = 0,B = 0, C = 0, D = 0;

for (int i = 0; i <= 3; i++)
{
    if (i == 0)
    {
        A = int.Parse(Console.ReadLine());
    }
    else if (i == 1)
    {
        B = int.Parse(Console.ReadLine());
    }
    else if(i == 2)
    {
        C = int.Parse(Console.ReadLine());
    } 
    else if (i == 3)
    {
        D = int.Parse(Console.ReadLine());
    }

}

   var DIFERENCA = ((A * B) - (C * D));

    Console.WriteLine("DIFERENÇA = " + DIFERENCA);

