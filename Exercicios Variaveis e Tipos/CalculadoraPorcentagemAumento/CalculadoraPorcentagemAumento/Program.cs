Console.Write("Digite o salário atual: ");
decimal salarioAtual = decimal.Parse(Console.ReadLine());

Console.Write("Digite o percentual de aumento: ");
decimal percentualAumento = decimal.Parse(Console.ReadLine());

decimal novoSalario = salarioAtual + (salarioAtual * percentualAumento / 100);

Console.WriteLine($"O novo salário é de R${novoSalario:F2}");
