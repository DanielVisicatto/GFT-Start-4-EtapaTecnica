/*Escreva um programa que receba um valor entre 3 e 999 como
entrada e apresente, quais números nesse intervalo são primos
entre si. (Valor: 2.0 pontos)*/



int x, y, min, max, div;
Console.WriteLine("Informe um número inicial maior que 3 (tres)");
x = int.Parse(Console.ReadLine());
Console.WriteLine("Informe um número final maior que o número inicial e menor que 999");
y = int.Parse(Console.ReadLine());

if (x < y)
{
    min = x;
    max = y;
}
else
{
    min = y;
    max = x;
}





for (int i = 2 + 1; (i < max / 2); i++)
{
    
    if (i %  i == 0)
    {     
        Console.WriteLine(i);
    }

}









//bool isValid = false;
//int inicial = 0, final = 0;


//while (isValid == false)
//{
//    Console.WriteLine("Informe um número inicial maior que 3 (tres)");
//    inicial = int.Parse(Console.ReadLine());

//    Console.WriteLine("Informe um número final maior que o número inicial e menor que 999");
//    final = int.Parse(Console.ReadLine());

//    if (inicial > 3 && final > inicial && final < 999)
//    {
//        for (int i = inicial + 1 ; i <= final; i++)
//        {

//            int div = 0;
//            if(div % i == 0)
//            {
//                div++;
//                Console.WriteLine(i);
//            }

//        }
//        isValid = true;

//    }
//    else 
//    { Console.WriteLine("Numeros fora do intervalo");
//    }

//}
