using LeonardLibrary2024;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LeonardLibrary2024
{
    public class Library
    {
        //create a list to store the holdings
        private List<Holdings> holdings;

        //constructor method
        public Library()
        {
            holdings = new List<Holdings>();
        }

        //method used to add holdings
        public void AddHolding(Holdings holding)
        {
            holdings.Add(holding);
        }

        //method used to check out holdings
        public void CheckOut(int id)
        {
            Holdings holding = holdings.Find(h => h.Id == id);
            if (holding != null && !holding.IsCheckedOut)
            {
                holding.CheckOut();
                WriteLine("You have checked it out.");
            }
            else
            {
                WriteLine("There was a problem with your request");
            }
        }

        //method used to check in holdings
        public void CheckIn(int id)
        {
            Holdings holding = holdings.Find(h => h.Id == id);
            if (holding != null && holding.IsCheckedOut)
            {
                holding.CheckIn();
                WriteLine("You have checked it in.");
            }
            else
            {
                WriteLine("There was a problem with your request");
            }
        }

        //method used to list all holdings
        public void ListAll()
        {
            WriteLine();
            WriteLine("Here are the library's holdings: ");

            bool checkedOutExists = false;
            WriteLine("These holdings are checked out: ");
            foreach (Holdings holding in holdings)
            {
                if (holding.IsCheckedOut)
                {
                    WriteLine(holding);
                    checkedOutExists = true;
                }
            }
            if (!checkedOutExists)
            {
                WriteLine("No holdings are checked out.");
            }

            bool availableExists = false;
            WriteLine();
            WriteLine("These holdings are available: ");
            foreach (Holdings holding in holdings)
            {
                if (!holding.IsCheckedOut)
                {
                    WriteLine(holding);
                    availableExists = true;
                }
            }
            if (!availableExists)
            {
                WriteLine("No holdings are available.");
            }
        }

        //method used to get stats
        public void GetStats()
        {
            int checkedOutCount = holdings.Count(h => h.IsCheckedOut);
            int availableCount = holdings.Count - checkedOutCount;
            WriteLine($"Available: {availableCount,(10)}\nChecked out: {checkedOutCount,(8)}");
        }
    }
} 