Console.WriteLine("Verificador de qualidade de mouses");

int idMouse;
string defeito;

Dictionary<string, int> situacoes = new Dictionary<string, int>()
{
    { "Necessita da esfera", 0 },
    { "Necessita de limpeza", 0 },
    { "Necessita troca cabo/conector", 0 },
    { "Quebrado ou inutilizado", 0 }
};

do
{
    Console.WriteLine("\nDigite o número de identificação do mouse (digite 0 para encerrar):");
    idMouse = int.Parse(Console.ReadLine());

    if (idMouse == 0)
        break;

    Console.WriteLine("\nDigite o tipo de defeito do mouse:");
    Console.WriteLine("1.Necessita da esfera.");
    Console.WriteLine("2.Necessita de limpeza.");
    Console.WriteLine("3.Necessita troca cabo/conector.");
    Console.WriteLine("4.Quebrado ou inutilizado.\n");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            defeito = "Necessita da esfera";
            break;
        case 2:
            defeito = "Necessita de limpeza";
            break;
        case 3:
            defeito = "Necessita troca cabo/conector";
            break;
        case 4:
            defeito = "Quebrado ou inutilizado";
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            continue;
    }

    situacoes[defeito]++;

    Console.WriteLine("\nDeseja cadastrar outro mouse? (S/N): ");
    string resposta = Console.ReadLine();

    if (!resposta.Equals("S", StringComparison.CurrentCultureIgnoreCase))
    {
        Console.WriteLine("\nEncerrando Programa...");
        break;
    }
} while (true);

Console.WriteLine($"\nQuantidade de mouses: {situacoes.Values.Sum()}");
Console.WriteLine("\nSituação:\t\t\tQuantidade:\t\tPercentual:");

foreach (var situacao in situacoes)
{
    double percentual = (double)situacao.Value / situacoes.Values.Sum() * 100;
    Console.WriteLine($"{situacao.Key}\t\t\t{situacao.Value}\t\t{percentual:0.##}%");
}