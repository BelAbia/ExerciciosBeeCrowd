
String info = "";
int contador = 0;

for (int i = 0; i <= 3; i++)
{
    do
    {
        info = Console.ReadLine();

        switch (info)
        {
            case " ":
                contador += 0;
                break;
            case "--*":
                contador += 1;
                break;
            case "-*-":
                contador += 2;
                break;
            case "-**":
                contador += 3;
                break;
            case "*--":
                contador += 4;
                break;
            case "*-*":
                contador += 5;
                break;
            case "**-":
                contador += 6;
                break;
            case "***":
                contador += 7;
                break;

        }
    } while (info != "caw caw");
    {
        Console.WriteLine(contador);
        contador = 0;
    }
}
