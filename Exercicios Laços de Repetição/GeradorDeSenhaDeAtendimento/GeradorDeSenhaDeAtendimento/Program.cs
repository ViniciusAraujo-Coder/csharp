void menu()
{
    Console.Clear();
    Console.WriteLine(@"
█▀▀ █▀▀ █▀█ ▄▀█ █▀▄ █▀█ █▀█   █▀▄ █▀▀   █▀ █▀▀ █▄░█ █░█ ▄▀█
█▄█ ██▄ █▀▄ █▀█ █▄▀ █▄█ █▀▄   █▄▀ ██▄   ▄█ ██▄ █░▀█ █▀█ █▀█");

    Console.Write("""

        Selecione uma opção:
        1 - Gerar uma nova senha
        2 - Chamar próxima senha
        3 - Sair
        
        Opção: 
        """);
}

int opcao;
int senhaAtual = 0;
int senhaGerada = 0;

do
{
    menu();

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.Write("Entrada inválida. Digite um número!");
        Thread.Sleep(1500);
        Console.Clear();
        continue;
    }

    switch (opcao)
    {
        case 1:
            senhaGerada++;
            Console.WriteLine($"\nSenha gerada: {senhaGerada.ToString("D3")}");
            Console.Write("\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
            break;

        case 2:
            if (senhaAtual + 1 <= senhaGerada)
            {
                senhaAtual++;
                Console.WriteLine($"Senha chamada: {senhaAtual.ToString("D3")}");
            }
            else
            {
                Console.WriteLine("Nenhuma senha para continuar.");
            }
            Console.Write("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
            break;

        case 3:
            Console.WriteLine("Encerrando o sistema.");
            break;

        default:
            {
                Console.Write("Opção inválida.");
                Thread.Sleep(1000);
                break;
            }

    }

} while (opcao != 3);
