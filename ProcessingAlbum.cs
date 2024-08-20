using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppVinylBook.Model;

namespace ConsoleAppVinylBook
{
    internal class ProcessingAlbum
    {
        public List<Album> Albums { get; set; }

        public ObradaSmjer()
        {
            Albums = new List<Album>();
            if (Common.DEV)
            {
                ReadTestData();
            }
        }

        private void ReadTestData()
        {
            Albums.Add(new() { Title = "Trainspotting" });
            Albums.Add(new() { Title = "Alibaba" });
            Albums.Add(new() { Title = "Sarlo Akrobata" });
        }

        public void ShowMenu()
        {
            Console.WriteLine("Albums menu");
            Console.WriteLine("1. List of Albums");
            Console.WriteLine("2. Add new Album");
            Console.WriteLine("3. Change Album Data");
            Console.WriteLine("4. Delete Album");
            Console.WriteLine("5. Return to main menu");
            ProcessingMenuOptions();
        }

        private void ProcessingMenuOptions()
        {
            switch (Common.ReadNumberRespond("Select a menu item", 1, 5))
            {
                case 1:
                    ShowAlbums();
                    ShowMenu();
                    break;
                case 2:
                    AddNewAlbum();
                    ShowMenu();
                    break;
                case 3:
                    ChangeAlbum();
                    ShowMenu();
                    break;
                case 4:
                    DeleteAlbum();
                    ShowMenu();
                    break;
                case 5:
                    Console.Clear();
                    break;
            }
        }

        private void DeleteAlbum()
        {
            ShowAlbums();
            var selected= Albums[Common.ReadNumberRespond("Select number of album to delete",
                1, Albums.Count) - 1];

            if (Common.ReadBool("Delete " + selected.Title + "? (YES/NO)", "yes"))
            {
                Albums.Remove(selected);
            }

        }

        private void ChangeAlbum()
        {
            ShowAlbums();
            var selected = Albums[Common.ReadNumberRespond("Odaberi redni broj smjera za promjenu",
                1, Albums.Count) - 1];
            selected.Title = Common.ReadString("Input Album title", 50, true);
            selected.Artist = Common.ReadString("Input Album artist", 50, true);
            selected.Genre = Common.ReadString("Input Album genre", 50, true);
            selected.Language = Common.ReadBool("Is the ExYu language of the album (YES/NO)", "da");

        }

        public void ShowAlbums()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("List of Albums ");
            int rb = 0;
            foreach (var s in Albums)
            {
                Console.WriteLine(++rb + ". " + s.Title);
            }
            Console.WriteLine("****************************");
        }


        private void AddNewAlbum()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Enter the required information for the album:");
            Albums.Add(new()
            {

                Title = Common.ReadString("Input album title", 50, true),
                Artist = Common.ReadString("Input artist", 50, true),
                Genre = Common.ReadString("Input genre", 50, true),
                Language = Common.ReadBool("Is the ExYu language of the album (YES/NO)", "yes")

            });
        }
    }
}
