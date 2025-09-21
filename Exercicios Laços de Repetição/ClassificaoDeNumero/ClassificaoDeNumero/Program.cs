List<int> notas = new List<int> { 4, 7, 5, 9, 6 };

foreach (int nota in notas)
{
    if (nota > 5)
    {
        Console.WriteLine($"Nota {nota} - Aprovado");
    }
    else
    {
        Console.WriteLine($"Nota {nota} - Reprovado");
    }
}
