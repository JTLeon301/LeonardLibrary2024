using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonardLibrary2024
{
  public class Periodical : Holdings
    {
        //properties
        public string Date { get; set; }

        //constructor method
        public Periodical(int id, string title, string description, string date) : base(id, title, description)
        {
            Date = date;
        }

        //override HoldingType() method
        public override string HoldingType()
        {
            return "Periodical";
        }

        //override ToString() method
        public override string ToString()
        {
            return base.ToString() + $"\n{Date}";
        }
    }
}
