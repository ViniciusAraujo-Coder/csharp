/*
Este programa simula um sistema de pesquisa que verifica se uma palavra-chave está presente no texto digitado pelo usuário.
Se a palavra-chave for encontrada, exibe uma mensagem de confirmação.
*/

string palavraChave = "C#"; 

Console.Write("Digite um texto: ");
string textoUsuario = Console.ReadLine();

if (textoUsuario.Contains(palavraChave))
{
    Console.WriteLine("A palavra-chave foi encontrada na pesquisa.");
}
else
{
    Console.WriteLine("A palavra-chave não foi encontrada na pesquisa.");
}
