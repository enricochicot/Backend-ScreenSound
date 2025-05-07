using ScreenSound.Modelos;

namespace Backend_ScreenSound.Menus
{
    internal class MenuMostrarBandas : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Bandas registradas");
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
        }
    }
}
