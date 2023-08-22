// See https://aka.ms/new-console-template for more information

using ConceitosBasicos;

int num1 = 20;
int num2 = 11, result;

Somador soma;
soma = new Somador();

result = soma.Soma(num1, num2);

Conversor conversor = new Conversor();

Console.WriteLine($"A soma dos números{num1}+{num2} é {result}");

double metros= 1.76;
Console.WriteLine("A medida {0} metros corresponde a {1}",metros,Conversor.MetrosMilimetros(1.76));

