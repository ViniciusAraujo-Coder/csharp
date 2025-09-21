/*verifica se:
- A senha digitada é 42
- O nível de acesso é igual ou superior a 5

Se ambos os critérios forem atendidos, o programa exibe "Acesso liberado";
Caso contrário, exibe "Acesso negado".
*/

Console.WriteLine(@"
▄▀█ █▀▀ █▀▀ █▀ █▀ █▀█   ▄▀█ █▀█ █▀▀ ▄▀█   █▀█ █▀▀ █▀ ▀█▀ █▀█ █ ▀█▀ ▄▀█
█▀█ █▄▄ ██▄ ▄█ ▄█ █▄█   █▀█ █▀▄ ██▄ █▀█   █▀▄ ██▄ ▄█ ░█░ █▀▄ █ ░█░ █▀█");
Console.Write("Digite a senha: ");
int senha = int.Parse(Console.ReadLine());

Console.Write("Digite o nível de acesso: ");
int nivelAcesso = int.Parse(Console.ReadLine());

if (senha == 42 && nivelAcesso >= 5)
{
    Console.WriteLine("Acesso liberado");
}
else
{
    Console.WriteLine("Acesso negado");
}
