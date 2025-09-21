int opcao = 0;
void logo()
{
    Console.WriteLine(@"
█▀ ▄▀█ █░█ █▀▄ ▄▀█ █▀▀ ▄▀█ █▀█   █▀█ █▀▀ █▀█ █▀ █▀█ █▄░█ ▄▀█ █░░ █ ▀█ ▄▀█ █▀▄ ▄▀█
▄█ █▀█ █▄█ █▄▀ █▀█ █▄▄ █▀█ █▄█   █▀▀ ██▄ █▀▄ ▄█ █▄█ █░▀█ █▀█ █▄▄ █ █▄ █▀█ █▄▀ █▀█");
}

void conteudo()
{
    do
    {
        Console.WriteLine("""
        
        Que momento do dia é agora?
        1- Manhã
        2- Tarde
        3- Noite
        """);
        Console.Write("\nDigite um número para escolher o momento: ");
        if (int.TryParse(Console.ReadLine(), out opcao) && opcao >= 1 && opcao <= 3)
        {
            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine();

            Console.Clear();

            logo();
            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"\nBom dia, {nome}! :D");
                    break;
                case 2:
                    Console.WriteLine($"\nBoa tarde, {nome}! :D");
                    break;
                case 3:
                    Console.WriteLine($"\nBoa noite, {nome}! :D");
                    break;
            }
            break;
        }

        else
        {
            Console.WriteLine("\nErro. Digite um número valido. Entre 1, 2 e 3. ");
        }
    } while (true);
}

logo();
conteudo();