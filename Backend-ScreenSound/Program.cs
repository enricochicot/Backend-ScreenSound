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
            Console.WriteLine("Digite 5 para registrar o álbum de uma banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    RegistrarBanda();
                    break;

                case 2:
                    MostrarAsBandasRegistradas();
                    break;

                case 3:
                    AvaliarUmaBanda();
                    break;

                case 4:
                    ExibirMedia();
                    break;

                case 5:
                    RegistrarAlbum();
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

                default:
                    Console.WriteLine("Opção inválida, digite novamente.");
                    break;
            }
        }

        void RegistrarAlbum()
        {
            Console.Clear();
            Console.WriteLine("Registro de álbuns");
            Console.WriteLine("Digite a banda cujo álbum deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.WriteLine("Agora digite o titulo do álbum: ");
                string tituloAlbum = Console.ReadLine()!;
                Banda banda = bandasRegistradas[nomeDaBanda];
                banda.AdicionarAlbum(new Album(tituloAlbum));
                Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
                Thread.Sleep(3000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            ExibirOpcoesDoMenu();
        }

        void RegistrarBanda()
        {
            Console.Clear();
            Console.WriteLine("Registro de bandas");
            Console.WriteLine("\nDigite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            Banda banda = new Banda(nomeDaBanda);
            bandasRegistradas.Add(nomeDaBanda, banda);
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
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                banda.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso!");
                Thread.Sleep(3000);
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
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}");
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
    }
}