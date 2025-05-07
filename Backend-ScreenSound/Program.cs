using Backend_ScreenSound.Menus;
using Backend_ScreenSound.Modelos;
using ScreenSound.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {
        Banda ira = new Banda("Ira");
        ira.AdicionarNota(new Avaliacao(10));
        ira.AdicionarNota(new Avaliacao(9));
        ira.AdicionarNota(new Avaliacao(8));
        Banda beatles = new("The Beatles");


        Dictionary<string, Banda> bandasRegistradas = new();
        bandasRegistradas.Add(ira.Nome, ira);
        bandasRegistradas.Add(beatles.Nome, beatles);

        Dictionary<int, Menu> opcoes = new();
        opcoes.Add(1, new MenuRegistrarAlbum());
        opcoes.Add(2, new MenuRegistrarBanda());
        opcoes.Add(3, new MenuAvaliarBanda());
        opcoes.Add(4, new MenuExibirDetalhes());
        opcoes.Add(5, new MenuMostrarBandas());
        opcoes.Add(6, new MenuAvaliarAlbum());
        opcoes.Add(-1, new MenuSair());


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
            Console.WriteLine("\nDigite 1 para registrar um álbum");
            Console.WriteLine("Digite 2 para registrar uma banda");
            Console.WriteLine("Digite 3 para avaliar uma banda");
            Console.WriteLine("Digite 4 para exibir a média de uma banda");
            Console.WriteLine("Digite 5 para mostrar as bandas registradas");
            Console.WriteLine("Digite 6 para avaliar um álbum");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
            {
                Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
                menuASerExibido.Executar(bandasRegistradas);
                if(opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
            }
            else
            {
                Console.WriteLine("Opção inválida, digite novamente.");
            }

        }      
            ExibirOpcoesDoMenu();
    }
}