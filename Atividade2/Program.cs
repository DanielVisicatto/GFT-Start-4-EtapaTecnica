/*Escreva um programa que contenha uma interface chamada
calculosGerais. Essa interface deve conter um único método
chamado calculoDeArea. Crie também quatro classes que deverão
implementar a interface calculosGerais. As classes serão
Triangulo, Retangulo, Quadrado e Trapezio. O programa deverá
imprimir a área de cada uma das figuras geométricas
apresentadas abaixo (valor 3,0 pontos).*/

using Atividade2.src.Entities.Interface;
using Atividade2.src.Entities;
using System.Globalization;

Quadrado quadrado = new Quadrado();
Retangulo retangulo = new Retangulo();
Triangulo triangulo = new Triangulo();
Trapezio trapezio = new Trapezio();
Console.WriteLine("Digite o tamanho do lado do quadrado");
quadrado.Lado = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura do retangulo");
retangulo.Altura = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a base do retangulo");
retangulo.Base = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a base do triangulo");
triangulo.Base = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura do triangulo");
triangulo.Altura = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a base menor do trapézio");
trapezio.BaseMenor = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a base maior do trapézio");
trapezio.BaseMaior = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura do trapézio");
trapezio.Altura = double.Parse(Console.ReadLine());



Console.WriteLine($"Area do quadrado:{quadrado.CalculoDeArea().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Area do retangulo:{retangulo.CalculoDeArea().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Area do triangulo:{triangulo.CalculoDeArea().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Area do trapézio:{trapezio.CalculoDeArea().ToString("F2", CultureInfo.InvariantCulture)}");
