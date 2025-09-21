int vidas = 5;
Random aleatorio = new Random();

Console.WriteLine(@"
░░█ █▀█ █▀▀ █▀█   █▀▄ ▄▀█ █▀   █░█ █ █▀▄ ▄▀█ █▀
█▄█ █▄█ █▄█ █▄█   █▄▀ █▀█ ▄█   ▀▄▀ █ █▄▀ █▀█ ▄█");
Console.WriteLine("========================================================");
Console.WriteLine("\nVocê começa com 5 vidas.");
Console.WriteLine("Acerte o número secreto de 1 a 3 para ganhar 1 vida.");
Console.WriteLine("Se errar, perde 1 vida.");
Console.WriteLine("Digite 'sair' a qualquer momento para encerrar.\n");
Console.WriteLine("========================================================\n");

while (vidas > 0)
{
    Console.Write($"Vidas: {vidas} | Tente adivinhar (1 a 3): ");
    string entrada = Console.ReadLine();

    if (entrada.ToLower() == "Sair")
    {
        Console.WriteLine("\nJogo encerrado pelo jogador.");
        break;
    }

    if (!int.TryParse(entrada, out int tentativa))
    {
        Console.WriteLine("Digite apenas números ou 'sair'\n");
        continue;
    }

    int numeroSecreto = aleatorio.Next(1, 4);

    if (tentativa == numeroSecreto)
    {
        vidas++;
        Console.WriteLine("Acertou! Você ganhou 1 vida\n");
    }
    else
    {
        vidas--;
        Console.WriteLine($"Errou! O número era {numeroSecreto}. Você perdeu 1 vida.\n");
    }
}

if (vidas == 0)
{
    Console.WriteLine("Fim de jogo! Suas vidas acabaram.");
}