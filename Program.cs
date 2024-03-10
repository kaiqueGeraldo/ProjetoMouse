Console.WriteLine("Verificador de qualidade de mouses");

int idMouse;
string defeito;

Dictionary<string, List<int>> situacoes = new Dictionary<string, List<int>>()
{
    { "Sem defeitos", new List<int>() },
    { "Necessita da esfera", new List<int>() },
    { "Necessita de limpeza", new List<int>() },
    { "Necessita troca cabo/conector", new List<int>() },
    { "Quebrado ou inutilizado", new List<int>() }
};

do
{
    Console.WriteLine("\nDigite o número de identificação do mouse (digite 0 para encerrar):");
    idMouse = int.Parse(Console.ReadLine());

    if (idMouse == 0)
        break;

    Console.WriteLine("\nDigite o tipo de defeito do mouse:");
    Console.WriteLine("1.Sem defeitos.");
    Console.WriteLine("2.Necessita da esfera.");
    Console.WriteLine("3.Necessita de limpeza.");
    Console.WriteLine("4.Necessita troca cabo/conector.");
    Console.WriteLine("5.Quebrado ou inutilizado.\n");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            situacoes["Sem defeitos"].Add(idMouse);
            break;
        case 2:
            situacoes["Necessita da esfera"].Add(idMouse);
            break;
        case 3:
            situacoes["Necessita de limpeza"].Add(idMouse);
            break;
        case 4:
            situacoes["Necessita troca cabo/conector"].Add(idMouse);
            break;
        case 5:
            situacoes["Quebrado ou inutilizado"].Add(idMouse);
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            continue;
    }

    Console.WriteLine("\nDeseja cadastrar outro mouse? (S/N): ");
    string resposta = Console.ReadLine();

    if (!resposta.Equals("S", StringComparison.CurrentCultureIgnoreCase))
    {
        Console.WriteLine("\nEncerrando Programa...");
        break;
    }
} while (true);

foreach (var situacao in situacoes)
{
    Console.WriteLine($"\n---- Identificação dos mouses {situacao.Key.ToLower()} ----");
    if (situacao.Value.Count != 0)
    {
        Console.WriteLine(string.Join(", ", situacao.Value));

    }
    else
    {
        Console.WriteLine("Nenhum");
    }
    Console.WriteLine($"Total: {situacao.Value.Count} mouse(s)");
    Console.WriteLine();
}