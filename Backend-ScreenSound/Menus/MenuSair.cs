﻿using ScreenSound.Modelos;

namespace Backend_ScreenSound.Menus
{
    internal class MenuSair : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
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
        }
    }
}
