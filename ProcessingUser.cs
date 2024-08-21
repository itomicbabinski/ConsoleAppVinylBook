using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppVinylBook.Model;

namespace ConsoleAppVinylBook
{
    internal class ProcessingUser
    {
        public List<User> Users { get; set; }
        public List<Album> Albums { get; set; }

        public ProcessingUser()
        {
            Albums = new List<Album>();
            Users = new List<User>();
            if (Common.DEV)
            {
                ReadTestData();
            }
        }

        private void ReadTestData()
        {
            for (int i = 0; i < 10; i++)
            {
                Users.Add(new()
                {
                    FirstName = Faker.Name.First(),
                    LastName = Faker.Name.Last()
                });
            }

            {
                Albums.Add(new() { Title = "Trainspotting" });
                Albums.Add(new() { Title = "Alibaba" });
                Albums.Add(new() { Title = "Sarlo Akrobata" });
            }
        }

        public void ShowMenu()
        {
            Console.WriteLine("Users menu");
            Console.WriteLine("1. User Data");
            Console.WriteLine("2. User Collection");
            Console.WriteLine("3. Return to main menu");
            ProcessingMenuOptions();
        }
        private void ProcessingMenuOptions()
        {
            switch (Common.ReadNumberRespond("Select a menu item", 1, 3))
            {
                case 1:
                    Console.Clear();
                    ShowUserData();
                    ShowMenu();
                    break;
                case 2:
                    Console.Clear();
                    ShowUserCollection();
                    ShowMenu();
                    break;
                case 3:
                    Console.Clear();
                    break;
            }
        }
        private void ShowUserCollection()
        {
            
            ShowUsers();
            int rb = Common.ReadNumberRespond("Select number of User to view collection",0, Users.Count);
            Console.Clear();
            if (rb > 0)
                {
                    var selected = Users[rb - 1];
                Console.WriteLine("*****************************");
                Console.WriteLine("List of Albums ");
                int rba = 0;
                foreach (var s in Albums)  //ovdje ce ici uvjet da album pripada useru
                {
                    Console.WriteLine(++rba + ". " + s.Title);
                }
                Console.WriteLine("****************************");
            }

        }

        private void ShowUserData()
        {
            
            ShowUsers();
            int rb = Common.ReadNumberRespond("Select number of User to view data", 0, Users.Count);
            Console.Clear();
            if (rb > 0)
            {
                var selected = Users[rb - 1];
                Console.WriteLine("*****************************");
                Console.WriteLine("FirstName : " + selected.FirstName);
                Console.WriteLine("LasttName : " + selected.LastName);
                Console.WriteLine("Email : " + selected.Email);
                Console.WriteLine("Address : " + selected.FirstName);
                Console.WriteLine("*****************************");
            }
        }

        public void ShowUsers()
        {
            Console.WriteLine("0. Back to Menu ");
            Console.WriteLine("*****************************");
            Console.WriteLine("List of Users ");
            int rb = 0;
            foreach (var u in Users)
            {
                Console.WriteLine(++rb + ". " + u.FirstName);
            }
            Console.WriteLine("****************************");
        }

    

    }
}
