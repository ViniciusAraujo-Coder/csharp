Console.WriteLine(@"
█▀▀ █▀█ █▄░█ ▀█▀ ▄▀█ █▄░█ █▀▄ █▀█   █▀▀ ▄▀█ █▀█ ▄▀█ █▀▀ ▀█▀ █▀▀ █▀█ █▀▀ █▀
█▄▄ █▄█ █░▀█ ░█░ █▀█ █░▀█ █▄▀ █▄█   █▄▄ █▀█ █▀▄ █▀█ █▄▄ ░█░ ██▄ █▀▄ ██▄ ▄█");

Console.Write("\nDigite uma frase: ");
string frase = Console.ReadLine();

Console.WriteLine($"A frase contém {frase.Length} caracteres.");