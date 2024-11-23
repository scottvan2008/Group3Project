using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_final_LibrarySystem
{
    public class DeletedBook : BookBase
    {
		public DeletedBook() { }
		public DeletedBook(string isbn, string name, string author,string genre)
            : base(isbn, name, author,genre)
        {
        }
    }
}
