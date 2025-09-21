List<string> aluno = new List<string> { "Ana", "Carlos", "Bianca", "João", "Marina" };
bool encontrado = false;
int posicao = 0;

Console.Write("Nome do Aluno(a): ");
string nomeEncontrado = Console.ReadLine();

while (posicao < aluno.Count)
{
    if (aluno[posicao] == nomeEncontrado)
    {
        encontrado = true;
        break;
    }
    posicao++;
}

if (encontrado == true)
{
    Console.WriteLine($"Aluno encontrado na posição: {posicao}");
}
else
{
    Console.WriteLine("Aluno não está presenta na lista");
}