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
        public void Checkout()
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
            return $"ID: {Id}\nTitle: {Title}\nDescription {Description}\nStatus: {(IsCheckedOut ? "Checked out" : "Available")}";
        }
    }
}
