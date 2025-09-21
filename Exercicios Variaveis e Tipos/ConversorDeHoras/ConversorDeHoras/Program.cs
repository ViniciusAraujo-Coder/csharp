Console.WriteLine(@"
█▀▀ █▀█ █▄░█ █░█ █▀▀ █▀█ █▀ █▀█ █▀█   █▀▄ █▀▀   █░█ █▀█ █▀█ ▄▀█ █▀
█▄▄ █▄█ █░▀█ ▀▄▀ ██▄ █▀▄ ▄█ █▄█ █▀▄   █▄▀ ██▄   █▀█ █▄█ █▀▄ █▀█ ▄█");

do
{
    Console.Write("\nQuantos minutos? ");
    if (int.TryParse(Console.ReadLine(), out int minutos))
    {
        int horas = minutos / 60;
        int restantesMinutos = minutos % 60;
        Console.WriteLine($"\nTempo: {horas} horas e {restantesMinutos} minutos");
        break;
    }
    else
    {
        Console.WriteLine("Erro. Por favor digite somente numeros.");
        continue;
    }
} while (true);