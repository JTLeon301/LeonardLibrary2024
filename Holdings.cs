using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonardLibrary2024
{
    public abstract class Holdings
    {
        //properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCheckedOut { get; set; }

        //constructor method
        public Holdings(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
            IsCheckedOut = false;
        }

        //get holding type
        public abstract string HoldingType();

        //check out
        public void CheckOut()
        {
            IsCheckedOut = true;
        }

        //check in
        public void CheckIn()
        {
            IsCheckedOut = false;
        }

        //ToString method
        public override string ToString()
        {
            return $"{Id}\n{HoldingType()}\n{Title}\n{Description}\n{(IsCheckedOut ? "Checked out" : "Available")}";
        }
    }
}
