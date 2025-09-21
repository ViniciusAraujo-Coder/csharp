int codigo = 0;
Console.WriteLine(@"
█▀▀ █░░ ▄▀█ █▀ █▀ █ █▀▀ █ █▀▀ ▄▀█ █▀▀ ▄▀█ █▀█   █▀▄ █▀▀   █░░ █ █░█ █▀█ █▀█ █▀
█▄▄ █▄▄ █▀█ ▄█ ▄█ █ █▀░ █ █▄▄ █▀█ █▄▄ █▀█ █▄█   █▄▀ ██▄   █▄▄ █ ▀▄▀ █▀▄ █▄█ ▄█");

do
{

    Console.Write("\nDigite o código do livro: ");
    if (int.TryParse(Console.ReadLine(), out codigo))
    {
        string categoria = codigo switch
        {
            >= 100 and <= 199 => "Ficção Científica",
            >= 200 and <= 299 => "Literatura Clássica",
            >= 300 and <= 399 => "Fantasia",
            >= 400 and <= 499 => "Romance",
            >= 500 and <= 599 => "Suspense/Mistério",
            >= 600 and <= 699 => "Não Ficção",
            >= 700 and <= 799 => "Biografias/Memórias",
            >= 800 and <= 899 => "Distopia",
            >= 900 and <= 999 => "Infantojuvenil",
            _ => "Código inexistente"
        };

        if (categoria == "Código inexistente")
        {
            Console.WriteLine("Código inexistente, fora da faixa válida (100 a 999). Tente novamente.");
        }
        else
        {
            Console.WriteLine($"\nCategoria: {categoria}");
            return;
        }
    }
    else
    {
        Console.WriteLine("Código fora da faixa válida (100 a 999). Tente novamente.");
    }

} while (true);