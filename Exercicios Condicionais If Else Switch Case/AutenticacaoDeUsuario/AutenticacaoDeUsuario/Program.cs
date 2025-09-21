Console.WriteLine(@"
█▀ █ █▀ ▀█▀ █▀▀ █▀▄▀█ ▄▀█   █▀▄ █▀▀   ▄▀█ █░█ ▀█▀ █▀▀ █▄░█ ▀█▀ █ █▀▀ ▄▀█ █▀▀ ▄▀█ █▀█
▄█ █ ▄█ ░█░ ██▄ █░▀░█ █▀█   █▄▀ ██▄   █▀█ █▄█ ░█░ ██▄ █░▀█ ░█░ █ █▄▄ █▀█ █▄▄ █▀█ █▄█");

List<string> adminsCadastrados = new List<string> { "Vinicius", "Arthur Dent" };
List<string> usuariosCadastrados = new List<string>();

Console.Write("\nDigite seu nome de usuário: ");
string nomeUsuario = Console.ReadLine();

string statusUsuario = nomeUsuario switch
{
    _ when adminsCadastrados.Contains(nomeUsuario) => "\nADMIN LOGADO",
    _ when usuariosCadastrados.Contains(nomeUsuario) => "\nUSUÁRIO LOGADO",
    _ => "\nUsuário não cadastrado."
};

Console.WriteLine(statusUsuario);

if (statusUsuario != "\nUsuário não cadastrado.")
{
    Console.WriteLine($"\nBem-vindo, {nomeUsuario}!");
}
else
{
    menuNaoCadastrado();
}

void menuNaoCadastrado()
{
    string mensagemErro = "\nErro, por favor digite uma opção de 1 a 3.";
    while (true)
    {
        Console.WriteLine(@"
Opções disponíveis:
[1] Cadastrar novo usuário
[2] Acessar como convidado
[3] Sair");
        Console.WriteLine();
        if (int.TryParse(Console.ReadLine(), out int opcao))
        {
            switch (opcao)
            {
                case 1:
                    usuariosCadastrados.Add(nomeUsuario);
                    Console.WriteLine($"\nNovo usuário {nomeUsuario} cadastrado com sucesso!");
                    return;
                case 2:
                    Console.WriteLine("\nAcesso concedido como convidado.");
                    return;
                case 3:
                    Console.WriteLine("\nAté mais!");
                    return;
                default:
                    Console.WriteLine(mensagemErro);
                    break;
            }
        }
        else
        {
            Console.WriteLine(mensagemErro);
        }
    }

}