
bool isValid = false;
int inicial = 0, final = 0, count = 0;


while (isValid == false)
{
    Console.WriteLine("Informe um número inicial maior ou igual a 3 (tres)");
    inicial = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe um número final maior que o número inicial e menor que 999");
    final = int.Parse(Console.ReadLine());

    if (inicial >= 3 && final > inicial && final < 999)
    {

        for (int i = inicial; i <= final; i++)
        {
            count = 0;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    count = 1;
                    break;
                }
            }
            if (count == 0)
            {
                Console.Write($"{i} ");
            }
        }
        isValid = true;
    }
    else
    {
        Console.WriteLine("Numeros fora do intervalo");
    }

}
