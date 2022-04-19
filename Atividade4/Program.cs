
bool isValid = false;
int inicial = 0, final = 0;


while (isValid == false)
{
    Console.WriteLine("Informe um número inicial maior que 3 (tres)");
    inicial = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe um número final maior que o número inicial e menor que 999");
    final = int.Parse(Console.ReadLine());

    if (inicial > 3 && final > inicial && final < 999)
    {
        for (int i = inicial + 1; i <= final; i++)
        {

            if (i % 2 != 0 && i % 5 != 0 && i % 9 != 0 && i % 7 != 0 && i % 3 != 0)
            {                
                Console.WriteLine(i);
            }

        }
        isValid = true;

    }
    else
    {
        Console.WriteLine("Numeros fora do intervalo");
    }

}
