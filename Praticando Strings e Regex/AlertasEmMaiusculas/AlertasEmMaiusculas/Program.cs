Console.WriteLine(@"
█▀▀ █▀█ █▄░█ █░█ █▀▀ █▀█ ▀█▀ █▀▀ █▄░█ █▀▄ █▀█   █▀▀ █▀▄▀█   █▀▄▀█ ▄▀█ █ █░█ █▀ █▀▀ █░█ █░░ ▄▀█ █▀
█▄▄ █▄█ █░▀█ ▀▄▀ ██▄ █▀▄ ░█░ ██▄ █░▀█ █▄▀ █▄█   ██▄ █░▀░█   █░▀░█ █▀█ █ █▄█ ▄█ █▄▄ █▄█ █▄▄ █▀█ ▄█");

Console.Write("\nDigite o alerta: ");
string alerta = Console.ReadLine();

string resultado = alerta.ToUpper();

Console.Write("\nAlerta padronizado:");
Console.WriteLine(resultado);