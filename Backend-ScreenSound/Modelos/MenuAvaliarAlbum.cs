using Backend_ScreenSound.Menus;
using ScreenSound.Modelos;

namespace Backend_ScreenSound.Modelos
{
    internal class MenuAvaliarAlbum : Menu 
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);

            //se a banda existir no dicionario >> atribuir uma nota
            base.Executar(bandasRegistradas);

            ExibirTituloDaOpcao("Avaliar álbum"); //herdado da classe menu permitiu que importassemos o titulo da opção 
            Console.WriteLine("Digite o nome do álbum que deseja avaliar");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {

                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.WriteLine("\nDigite o nome da banda que deseja registrar: ");
                string tituloAlbum = Console.ReadLine()!;
                if(banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum))) 
                {
                    Console.Write($"Qual a nota que o álbum {tituloAlbum} merece: ");
                    Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                    Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                    album.AdicionarNota(nota);
                    Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso!");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"\nO álbum {tituloAlbum} não foi encontrado!");
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
