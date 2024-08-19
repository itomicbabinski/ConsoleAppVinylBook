using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVinylBook
{
    internal class MainMenu
    {



        private void ShowMainMenu()
        {
            Console.WriteLine("MainMenu");
            Console.WriteLine("1. Users");
            Console.WriteLine("2. Albums");
            Console.WriteLine("3. Exchanges");
            Console.WriteLine("4. EXIT");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {

            switch (Common.ReadNumberRespond("Select a menu item", 1, 4))
            {
                case 1:
                    Console.Clear();
                    //ObradaSmjer.PrikaziIzbornik();
                    //PrikaziIzbornik();
                    break;
                case 2:
                    Console.Clear();
                    //ObradaPolaznik.PrikaziIzbornik();
                    //PrikaziIzbornik();
                    break;
                case 3:
                    Console.Clear();
                    //ObradaGrupa.PrikaziIzbornik();
                    //PrikaziIzbornik();
                    break;
                case 4:
                    Console.WriteLine("Exit from application... Bye!");
                    //SpremiPodatke();
                    break;
            }
        }

    }
}
