Console.WriteLine(@"
█▀▀ █░░ ▄▀█ █▀ █▀ █ █▀▀ █ █▀▀ ▄▀█ █▀▀ ▄▀█ █▀█   █▄░█ █▀█ ▀█▀ ▄▀█   ▄▀█ █░░ █░█ █▄░█ █▀█
█▄▄ █▄▄ █▀█ ▄█ ▄█ █ █▀░ █ █▄▄ █▀█ █▄▄ █▀█ █▄█   █░▀█ █▄█ ░█░ █▀█   █▀█ █▄▄ █▄█ █░▀█ █▄█");

Console.Write("\nInforme a nota final do aluno: ");
decimal nota = decimal.Parse(Console.ReadLine());

if (nota >= 9)
{
    Console.WriteLine("O aluno recebeu a nota A.");
}
else if (nota >= 7)
{
    Console.WriteLine("O aluno recebeu a nota B.");
}
else if (nota >= 5)
{
    Console.WriteLine("O aluno recebeu a nota C.");
}
else
{
    Console.WriteLine("O aluno recebeu a nota D.");
}
