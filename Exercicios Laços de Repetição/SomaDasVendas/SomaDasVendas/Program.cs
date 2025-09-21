decimal soma;
decimal totaldeVendas = 0;

void logo()
{
    Console.WriteLine(@"
█▀ █▀█ █▀▄▀█ ▄▀█   █▀▄ █▀▀   █░█ █▀▀ █▄░█ █▀▄ ▄▀█ █▀
▄█ █▄█ █░▀░█ █▀█   █▄▀ ██▄   ▀▄▀ ██▄ █░▀█ █▄▀ █▀█ ▄█");
}
;

void conteudo()
{
    logo();
    do
    {
        Console.Write("\nDigite o valor da venda (ou 0 para encerrar): ");
        if (decimal.TryParse(Console.ReadLine(), out soma))
        {
            if (soma != 0)
            {
                totaldeVendas = totaldeVendas + soma;
            }
            else
            {
                Console.Clear();
                logo();
                Console.WriteLine("\n-------------------------------------------------");
                Console.WriteLine($"\nTotal de vendas do dia: R${totaldeVendas:F2}");
                Console.WriteLine("\n-------------------------------------------------");
                break;
            }
        }
        else
        {
            Console.WriteLine("\nDigite um valor válido ou 0 para encerrar");
            continue;
        }

    } while (true);
}

conteudo();