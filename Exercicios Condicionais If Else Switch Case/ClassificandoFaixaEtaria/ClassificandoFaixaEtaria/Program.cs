﻿Console.WriteLine(@"
█▀▀ █░░ ▄▀█ █▀ █▀ █ █▀▀ █ █▀▀ ▄▀█ █▄░█ █▀▄ █▀█   █▀▀ ▄▀█ █ ▀▄▀ ▄▀█   █▀▀ ▀█▀ ▄▀█ █▀█ █ ▄▀█
█▄▄ █▄▄ █▀█ ▄█ ▄█ █ █▀░ █ █▄▄ █▀█ █░▀█ █▄▀ █▄█   █▀░ █▀█ █ █░█ █▀█   ██▄ ░█░ █▀█ █▀▄ █ █▀█");

Console.Write("\nDigite a idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade >= 0 && idade <= 12)
{
    Console.WriteLine("Classificação: infantil");
}
else if (idade >= 13 && idade <= 17)
{
    Console.WriteLine("Classificação: adolescente");
}
else if (idade >= 18 && idade <= 59)
{
    Console.WriteLine("Classificação: adulto");
}
else if (idade >= 60)
{
    Console.WriteLine("Classificação: idoso");
}
else
{
    Console.WriteLine("Idade inválida!");
}
