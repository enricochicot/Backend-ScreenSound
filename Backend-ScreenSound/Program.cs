//List<string> listaDasBandas = new List<string> {"U2" , {"Iron Maiden"} , {"ACDC"} };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> {10, 8, 9}); //nome é atribuido previamente junto com a nota
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirLogo() //função void, ela não espera um valor só é utilizado quando for solicitado
{
    Console.WriteLine(@" 

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandar");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;

        case 2: MostrarAsBandasRegistradas();
            break;

        case 3: AvaliarUmaBanda();
            break;

        case 4: ExibirMedia();
            break;

        case -1:
            Console.WriteLine(@"

██╗░░░██╗░█████╗░░█████╗░███████╗  ███████╗░██████╗░█████╗░░█████╗░██╗░░░░░██╗░░██╗███████╗██╗░░░██╗
██║░░░██║██╔══██╗██╔══██╗██╔════╝  ██╔════╝██╔════╝██╔══██╗██╔══██╗██║░░░░░██║░░██║██╔════╝██║░░░██║
╚██╗░██╔╝██║░░██║██║░░╚═╝█████╗░░  █████╗░░╚█████╗░██║░░╚═╝██║░░██║██║░░░░░███████║█████╗░░██║░░░██║
░╚████╔╝░██║░░██║██║░░██╗██╔══╝░░  ██╔══╝░░░╚═══██╗██║░░██╗██║░░██║██║░░░░░██╔══██║██╔══╝░░██║░░░██║
░░╚██╔╝░░╚█████╔╝╚█████╔╝███████╗  ███████╗██████╔╝╚█████╔╝╚█████╔╝███████╗██║░░██║███████╗╚██████╔╝
░░░╚═╝░░░░╚════╝░░╚════╝░╚══════╝  ╚══════╝╚═════╝░░╚════╝░░╚════╝░╚══════╝╚═╝░░╚═╝╚══════╝░╚═════╝░

░██████╗░█████╗░██╗██████╗░
██╔════╝██╔══██╗██║██╔══██╗
╚█████╗░███████║██║██████╔╝
░╚═══██╗██╔══██║██║██╔══██╗
██████╔╝██║░░██║██║██║░░██║
╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚═╝ 
");
            break;

        default: Console.WriteLine("Opção inválida, digite novamente.");
            break;
    } 
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("\nDigite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");//string nome da banda é exibido 
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarAsBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("Bandas registradas");
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
        //Console.WriteLine($"\nBanda: {listaDasBandas[i]}");
    //}
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"\nBanda: {banda}");
    }

    Console.WriteLine("\nTecle enter para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarUmaBanda()
{
    //se a banda existir no dicionario >> atribuir uma nota
    Console.Clear();
    Console.WriteLine("Avaliar banda");
    Console.WriteLine("Digite o nome da banda que deseja avaliar");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add (nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMedia()
{
    Console.Clear();
    Console.WriteLine("Exibição de média das bandas");
    Console.WriteLine("Digite o nome da banda que deseja verificar a média");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas [nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}


ExibirOpcoesDoMenu();

