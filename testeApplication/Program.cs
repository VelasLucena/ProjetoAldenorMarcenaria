using System.Net;

var valores = new List<int>() { 1, 2, 4, 5, 8, 26, 23 };
int soma = 0;
foreach (int number in valores)
{
    if (number % 2 == 0)
        soma = soma + number;
}
Console.WriteLine("A soma dos números pares é: " +soma.ToString());

