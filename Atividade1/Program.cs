/* Escreva um programa que receba a data de nascimento de duas
pessoas e imprima quantos dias vividos a pessoa mais velha tem
em relação a mais nova (valor 2,0 pontos).*/
using System.Globalization;

Console.WriteLine("Digite a primeira data (DD/MM/YYYY)");
DateTime nascimento1 = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda data (DD/MM/YYYY)");
DateTime nascimento2 = DateTime.Parse(Console.ReadLine());
if (nascimento2 > nascimento1)
{
    
    TimeSpan diferenca1 = nascimento2.Subtract(nascimento1);
    Console.WriteLine($"Diferença de {diferenca1.TotalDays} dias)");
}
else
{
    TimeSpan diferenca2 = nascimento1.Subtract(nascimento2);
    Console.WriteLine($"Diferença de {diferenca2.TotalDays} dias");
}
