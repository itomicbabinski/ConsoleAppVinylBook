using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVinylBook
{
    internal class MainMenu
    {

        public MainMenu()
        {
            Common.DEV = true;
            //ObradaSmjer = new ObradaSmjer();
            //ObradaPolaznik = new ObradaPolaznik();
            //ObradaGrupa = new ObradaGrupa(this);
            //UcitajPodatke();
            HelloMesage();
            ShowMainMenu();
        }
        private void ReadData()
        {
            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //if (File.Exists(Path.Combine(docPath, "smjerovi.json")))
            //{
            //    StreamReader file = File.OpenText(Path.Combine(docPath, "smjerovi.json"));
            //    ObradaSmjer.Smjerovi = JsonConvert.DeserializeObject<List<Smjer>>(file.ReadToEnd());


            //}

        }

        private void ShowMainMenu()
        {
            Console.WriteLine("MainMenu");
            Console.WriteLine("1. Users");
            Console.WriteLine("2. Albums");
            Console.WriteLine("3. Exchanges");
            Console.WriteLine("4. EXIT");
            ChoseOptionMainMenu();
        }

        private void ChoseOptionMainMenu()
        {

            switch (Common.ReadNumberRespond("Select a menu item", 1, 4))
            {
                case 1:
                    Console.Clear();
                    //ObradaSmjer.PrikaziIzbornik();
                    ShowMainMenu();
                    break;
                case 2:
                    Console.Clear();
                    //ObradaPolaznik.PrikaziIzbornik();
                    ShowMainMenu();
                    break;
                case 3:
                    Console.Clear();
                    //ObradaGrupa.PrikaziIzbornik();
                    ShowMainMenu();
                    break;
                case 4:
                    Console.WriteLine("Exit from application... Bye!");
                    SaveData();
                    break;
            }
}
private void SaveData()
        {
            if (Common.DEV)
            {
                return;
            }

            //Console.WriteLine(JsonConvert.SerializeObject(ProcessingUser.Users));

            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "users.json"));
            //outputFile.WriteLine(JsonConvert.SerializeObject(ProcessingUser.Users));
            //outputFile.Close();
        }

        private void HelloMesage()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("*** VinylBook Console App v 1.0 ***");
            Console.WriteLine("***********************************");
        }

    }
}
