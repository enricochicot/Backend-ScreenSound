using ScreenSound.Modelos;

namespace Backend_ScreenSound.Menus
{
    internal class MenuRegistrarAlbum : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Registro de bandas");
            Console.WriteLine("\nDigite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            Banda banda = new Banda(nomeDaBanda);
            bandasRegistradas.Add(nomeDaBanda, banda);
            Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");//string nome da banda é exibido 
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
