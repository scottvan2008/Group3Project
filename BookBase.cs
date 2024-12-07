using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_final_LibrarySystem
{
    public abstract class BookBase
    {
        public string Isbn { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public BookBase() { }
        public BookBase(string isbn, string name, string author, string genre)
        {
            Isbn = isbn;
            Name = name;
            Author = author;
            Genre = genre;
        }
    }
}
