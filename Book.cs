using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonardLibrary2024
{
public class Book : Holdings
    {
        //properties
        public int CopyRightYear { get; set; }
        public string Author { get; set; }

        //constructor method
        public Book(int id, string title, string description, int copyRightYear, string author) : base(id, title, description)
        {
            CopyRightYear = copyRightYear;
            Author = author;
        }

        //override HoldingType() method
        public override string HoldingType()
        {
            return "Book";
        }

        //override ToString() method
        public override string ToString()
        {
            return base.ToString() + $"\n{Author}\n{CopyRightYear}\n";
        }
    }
}
