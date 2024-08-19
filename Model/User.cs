using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVinylBook.Model
{
    internal class User : Entitet
    {

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        public override string ToString()
        {
            return "FirstName=" + FirstName + " ,LastName=" + LastName + ", Email=" + Email + ", Phone=" + Phone +", Address=" + Address;
        }



    }
}
