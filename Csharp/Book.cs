using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_final_LibrarySystem
{
    public class Book:BookBase
    {
        //fields
        bool availability;
        int quantity;

        //setter and getter
        
        public int Quantity { get => quantity; set => quantity = value; }
        public bool Availability { get => availability; set => availability = value; }

        //empty constructor
        public Book():base()
        {

        }
        
        //constructor with boolean availability
        public Book(string isbn, string name, string author, string genre, bool availability, int quantity):base(isbn,name,author,genre)
        {
            
            Availability = availability;
            Quantity = quantity;
        }

        //constructor with int availability(catering for the database)
        public Book(string isbn, string name, string author, string genre, int availability, int quantity): base(isbn, name, author,genre)
        {
            
            if (availability == 0)
                Availability = false;
            if (availability == 1)
                Availability = true;
            Quantity = quantity;
        }
        
    }
}
