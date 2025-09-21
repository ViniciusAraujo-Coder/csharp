Console.WriteLine(@"
█▀ █░█ █▄▄ █▀ ▀█▀ █ ▀█▀ █░█ █ █▄░█ █▀▄ █▀█   █▀█ ▄▀█ █░░ ▄▀█ █░█ █▀█ ▄▀█ █▀
▄█ █▄█ █▄█ ▄█ ░█░ █ ░█░ █▄█ █ █░▀█ █▄▀ █▄█   █▀▀ █▀█ █▄▄ █▀█ ▀▄▀ █▀▄ █▀█ ▄█");

Console.WriteLine("Digite uma frase: ");
string frase = Console.ReadLine();

Console.WriteLine("\nQual palavra você quer substituir? ");
string palavraAntiga = Console.ReadLine();

Console.WriteLine("\nPor qual palavra? ");
string palavraNova = Console.ReadLine();

string novaFrase = frase.Replace(palavraAntiga, palavraNova);

Console.WriteLine("\nFrase modificada:");
Console.WriteLine(novaFrase);