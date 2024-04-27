// Peça ao usuário para digitar alguns nomes de alunos e armazená-los em um vetor.
// Em seguida, permita que o usuário digite um nome para pesquisar no vetor.
// Se o nome estiver presente, informe a posição; se não, informe que o nome não foi encontrado.

Console.WriteLine("Qual a quantidade de pessoas desejada?");
int quantidadePessoas = int.Parse(Console.ReadLine());

string[] nomes = new string[quantidadePessoas];

// Pega o nome das pessoas
for (int i = 0; i < nomes.Length; i++)
{
    Console.Write($"Qual o nome da pessoa {i + 1}: ");
    nomes[i] = Console.ReadLine();
}

Console.Clear();

// Permite fazer a pesquisa
string desejaPesquisar = "";
do
{
    Console.WriteLine("Qual nome deseja saber se está na lista?");
    string pesquisa = Console.ReadLine();

    // Pesquisa
    int posicao = 0;

    bool encontrou = false;
    for (int i = 0; i < nomes.Length; i++)
    {
        if (nomes[i].ToUpper() == pesquisa.ToUpper())
        {
            posicao = i;
            encontrou = true;
        }
    }

    if (encontrou)
        Console.WriteLine($"Encontrei a pessoa {nomes[posicao]} na posicao {posicao}");
    else
        Console.WriteLine("Não encontrei a pessoa");

    Console.WriteLine("Deseja pesquisar outro? (s/n)");
    desejaPesquisar = Console.ReadLine();
} while (desejaPesquisar != "n");