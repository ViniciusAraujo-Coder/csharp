Console.WriteLine(@"
█▀▄ █ █░█ █ █▀▄ █ █▄░█ █▀▄ █▀█   █░█ █▀▄▀█ ▄▀█   █▀ ▀█▀ █▀█ █ █▄░█ █▀▀
█▄▀ █ ▀▄▀ █ █▄▀ █ █░▀█ █▄▀ █▄█   █▄█ █░▀░█ █▀█   ▄█ ░█░ █▀▄ █ █░▀█ █▄█");

string log = "2025-03-25,Erro,Arquivo não encontrado";

string[] partes = log.Split(',');

Console.WriteLine($"Data: {partes[0]}");
Console.WriteLine($"Tipo de erro: {partes[1]}");
Console.WriteLine($"Mensagem: {partes[2]}");