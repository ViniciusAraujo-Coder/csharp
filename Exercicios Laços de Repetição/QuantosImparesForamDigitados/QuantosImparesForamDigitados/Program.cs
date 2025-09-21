List<int> numeros = new List<int>();

for (int i = 0; i < 10; i++)
{
    Console.Write("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());
    numeros.Add(numero);
}

int qtdImpares = 0;

foreach (int numero in numeros)
{
    if (numero % 2 != 0)
    {
        qtdImpares++;
    }
}

Console.WriteLine($"Você digitou {qtdImpares} números ímpares.");