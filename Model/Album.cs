using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVinylBook.Model
{
    internal class Album : Entitet, IComparable<Album>
    {
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public bool? Language { get; set; }
        public string? Genre { get; set; }

        public int CompareTo(Album? other)
        {
            return Title.CompareTo(other.Title);
        }

        public override string ToString()
        {
            return "Title=" + Title + " ,Artist=" + Artist + ", Language=" + Language + ", Genre=" + Genre ;
        }
    }
}
