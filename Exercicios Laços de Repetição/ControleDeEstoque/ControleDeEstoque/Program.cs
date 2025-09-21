int estoque = 0;
int resposta;

Console.WriteLine(@"
█▀▀ █▀▀ █▀█ █▀▀ █▄░█ █▀▀ █ ▄▀█ █▀▄ █▀█ █▀█   █▀▄ █▀▀   █▀▀ █▀ ▀█▀ █▀█ █▀█ █░█ █▀▀
█▄█ ██▄ █▀▄ ██▄ █░▀█ █▄▄ █ █▀█ █▄▀ █▄█ █▀▄   █▄▀ ██▄   ██▄ ▄█ ░█░ █▄█ ▀▀█ █▄█ ██▄ 
");

while (true)
{
    Console.Write("""
        Deseja adicionar um produto ao estoque?
        1 - Sim | 0 - Não
        Resposta: 
        """);

    if (!int.TryParse(Console.ReadLine(), out resposta) || resposta != 0 && resposta != 1)
    {
        Console.WriteLine("Opção inválida! Digite 1 para Sim ou 0 para Não.\n");
        continue;
    }

    if (resposta == 0)
    {
        break;
    }

    Console.Write("Quantidade: ");

    if (!int.TryParse(Console.ReadLine(), out int quantidade) || quantidade < 0)
    {
        Console.Write("Por favor, insira uma quantidade válida (número positivo).\n");
        continue;
    }

    estoque = quantidade + estoque;
    Console.WriteLine($"Estoque atual: {estoque}");
}

Console.WriteLine("\nObrigado por usar nosso sistema de estoque!");