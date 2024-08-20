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

        public List<User> Users{ get; set; }
        private void AddNewUser()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Enter the required information for the user:");
            Users.Add(new()
            {
                
                FirstName = Common.ReadString("Input first name", 50, true),
                LastName = Common.ReadString("Input last name", 50, true),
                Email = Common.ReadString("Input email", 50, true),
                Phone = Common.ReadString("Input phone", 50, false),
                Address = Common.ReadString("Input address", 50, false)
            });
        }
    }
}
