Console.WriteLine(@"
█▀▀ █▀█ █▄░█ █░█ █▀▀ █▀█ █▀ █▀█ █▀█   █▀▄ █▀▀   █▀▄▀█ █ █░░ █░█ ▄▀█ █▀
█▄▄ █▄█ █░▀█ ▀▄▀ ██▄ █▀▄ ▄█ █▄█ █▀▄   █▄▀ ██▄   █░▀░█ █ █▄▄ █▀█ █▀█ ▄█");

do
{
    Console.Write("\nDigite um valor em milhas para converter em quilômetros: ");
    if (double.TryParse(Console.ReadLine(), out double milhas))
    {
        double quilometros = milhas * 1.60934;
        Console.WriteLine($"\n{milhas} Milhas equivalem a {quilometros} quilômetros.");
        break;
    }
    else
    {
        Console.WriteLine("\nErro. Por favor digite apenas números.");
        continue;
    }
} while (true);