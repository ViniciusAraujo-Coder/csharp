List<double> notas = new List<double>
        {
    8.5,
    6.2,
    9.1,
    5.8,
    7.4
        };

foreach (double nota in notas)
{
    if (nota >= 7.0)
    {
        Console.WriteLine($"O aluno com a nota {nota} está indo muito bem!");
    }
    else
    {
        Console.WriteLine($"O aluno com a nota {nota} está abaixo da média!");
    }
}