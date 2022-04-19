/*Crie um programa que contenha uma classe Pessoa e uma classeCachorro. A classe Pessoa deverá ter os seguintes
atributos:
nomePessoa, idadePessoa, e pet (que será um objeto Cachorro). A classe Cachorro terá os seguintes atributos:
raca, porte e idade.
O programa deverá receber informações da pessoa e do cachorro eao final deverá imprimir qual seria a idade humana 
do cachorro,e qual a diferença entre sua idade humana e a idade de seu tutor. */
using System.Globalization;
using Atividade3.src.Entities;

Pessoa pessoa = new Pessoa();
Cachorro pet = new Cachorro();

Console.Write("Digite o seu nome: ");
pessoa.NomePessoa = Console.ReadLine();

Console.Write("Digite sua idade: ");
pessoa.IdadePessoa = int.Parse(Console.ReadLine());

Console.Write("Digite o peso do seu pet: ");
double pesoPet = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.Write("Raça: ");
pet.Raça = Console.ReadLine();

if(pesoPet < 10.00)
{
    pet.Porte = "Pequeno";
}
else if(pesoPet >= 10.00 && pesoPet < 22.00)
{
    pet.Porte = "Médio";
}
else
{
    pet.Porte = "Grande";
}

if (pessoa.IdadePessoa == 1)
{
    pet.Idade = 15;
}
else if(pessoa.IdadePessoa == 2)
{
    pet.Idade = 24;
}
else if (pessoa.IdadePessoa == 3)
{
    pet.Idade = 28;
}
else if (pessoa.IdadePessoa == 4)
{
    pet.Idade = 32;
}
else if (pessoa.IdadePessoa == 5)
{
    pet.Idade = 36;
}
else if (pessoa.IdadePessoa == 6 && pet.Porte =="Pequeno")
{
    pet.Idade = 40;
}
else if (pessoa.IdadePessoa == 6 && pet.Porte == "Médio")
{
    pet.Idade = 42;
}
else if (pessoa.IdadePessoa == 6 && pet.Porte == "Grande")
{
    pet.Idade = 45;
}
else if (pessoa.IdadePessoa == 7 && pet.Porte == "Pequeno")
{
    pet.Idade = 44;
}
else if (pessoa.IdadePessoa == 7 && pet.Porte == "Médio")
{
    pet.Idade = 47;
}
else if (pessoa.IdadePessoa == 7 && pet.Porte == "Grande")
{
    pet.Idade = 50;
}
else if (pessoa.IdadePessoa == 8 && pet.Porte == "Pequeno")
{
    pet.Idade = 48;
}
else if (pessoa.IdadePessoa == 8 && pet.Porte == "Médio")
{
    pet.Idade = 51;
}
else if (pessoa.IdadePessoa == 8 && pet.Porte == "Grande")
{
    pet.Idade = 55;
}
else if (pessoa.IdadePessoa == 9 && pet.Porte == "Pequeno")
{
    pet.Idade = 52;
}
else if (pessoa.IdadePessoa == 9 && pet.Porte == "Médio")
{
    pet.Idade = 56;
}
else if (pessoa.IdadePessoa == 9 && pet.Porte == "Grande")
{
    pet.Idade = 61;
}
else if (pessoa.IdadePessoa == 10 && pet.Porte == "Pequeno")
{
    pet.Idade = 56;
}
else if (pessoa.IdadePessoa == 10 && pet.Porte == "Médio")
{
    pet.Idade = 60;
}
else if (pessoa.IdadePessoa == 10 && pet.Porte == "Grande")
{
    pet.Idade = 66;
}
else if (pessoa.IdadePessoa == 11 && pet.Porte == "Pequeno")
{
    pet.Idade = 60;
}
else if (pessoa.IdadePessoa == 11 && pet.Porte == "Médio")
{
    pet.Idade = 65;
}
else if (pessoa.IdadePessoa == 11 && pet.Porte == "Grande")
{
    pet.Idade = 72;
}
else if (pessoa.IdadePessoa == 12 && pet.Porte == "Pequeno")
{
    pet.Idade = 64;
}
else if (pessoa.IdadePessoa == 12 && pet.Porte == "Médio")
{
    pet.Idade = 69;
}
else if (pessoa.IdadePessoa == 12 && pet.Porte == "Grande")
{
    pet.Idade = 77;
}
else if (pessoa.IdadePessoa == 13 && pet.Porte == "Pequeno")
{
    pet.Idade = 68;
}
else if (pessoa.IdadePessoa == 13 && pet.Porte == "Médio")
{
    pet.Idade = 74;
}
else if (pessoa.IdadePessoa == 13 && pet.Porte == "Grande")
{
    pet.Idade = 82;
}
else if (pessoa.IdadePessoa == 14 && pet.Porte == "Pequeno")
{
    pet.Idade = 72;
}
else if (pessoa.IdadePessoa == 14 && pet.Porte == "Médio")
{
    pet.Idade = 78;
}
else if (pessoa.IdadePessoa == 14 && pet.Porte == "Grande")
{
    pet.Idade = 88;
}
else if (pessoa.IdadePessoa == 15 && pet.Porte == "Pequeno")
{
    pet.Idade = 76;
}
else if (pessoa.IdadePessoa == 15 && pet.Porte == "Médio")
{
    pet.Idade = 83;
}
else if (pessoa.IdadePessoa == 15 && pet.Porte == "Grande")
{
    pet.Idade = 93;
}
int diferenca = pet.Idade - pessoa.IdadePessoa;

Console.WriteLine($"{pessoa.NomePessoa} se o seu {pet.Raça} fosse humano, teria {pet.Idade} anos de vida!");
Console.WriteLine($"isso é nada mais nada menos do que {diferenca} anos de diferença para sua idade hoje!");