Random random = new Random();

int numeroAleatorio = random.Next(1, 11);
int resposta;

Console.WriteLine("================================================================");
Console.WriteLine(@"
▄▀█ █▀▄ █░█ █ █▄░█ █░█ █▀▀   █▀█   █▄░█ █░█ █▀▄▀█ █▀▀ █▀█ █▀█
█▀█ █▄▀ ▀▄▀ █ █░▀█ █▀█ ██▄   █▄█   █░▀█ █▄█ █░▀░█ ██▄ █▀▄ █▄█");
Console.WriteLine("\n================================================================");

do
{
    Console.Write("\nTente adivinhar o número entre 1 e 10: ");
    if (int.TryParse(Console.ReadLine(), out resposta))
    {
        if (resposta == numeroAleatorio)
        {
            break;
        }
        else if (resposta < numeroAleatorio)
        {
            Console.WriteLine("\nErrou, tente novamente! O número é maior!");
            continue;
        }
        else
        {
            Console.WriteLine("\nErrou, tente novamente! O número é menor!");
            continue;
        }
    }
    else
    {
        Console.WriteLine("Digite um número válido entre 1 e 10!");
        continue;
    }

} while (resposta != numeroAleatorio);

Console.WriteLine("\n================================================================");
Console.WriteLine("\nParabéns! Você acertou o número secreto!");