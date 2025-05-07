using Backend_ScreenSound.Modelos;
using ScreenSound.Modelos;

namespace Backend_ScreenSound.Menus
{
    internal class MenuAvaliarBanda : Menu //método de herança aplicado, quando criado a classe de menu
    {
        public void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            //se a banda existir no dicionario >> atribuir uma nota
            Console.Clear();
            ExibirTituloDaOpcao("Avaliar banda"); //herdado da classe menu permitiu que importassemos o titulo da opção 
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
