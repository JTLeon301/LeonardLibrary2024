using System.Diagnostics;
using System.Runtime.InteropServices;
using static System.Console;

/*
 * NAME: Jaiden Leonard
 * CLASS: .NET Programming
 * ASSIGNMENT: Library
 * DATE: 2/28/24
 * 
 * PURPOSE:
 * The purpose of this program is to manage a library system. It lets the user do various tasks like adding books
 * and periodicals to the collection, listing all of the library's holdings, returning or checking out holdings,
 * and viewing the statistics of the library's holdings.
 * 
 * STRUGGLES:
 * For the most part, this assignment was difficult but managable. The hardest part for me was setting up the library
 * class which took quite a long time to figure out but I was able to do it. I had to research for a bit to discover
 * the lambda expressions to make the methods found within the library class work. The other classes were pretty
 * straight-forward in how to set them up. I also added seperate methods to do certain tasks rather than trying
 * to pack all of it into the switch statement.
 * 
 * NOTES:
 * If you notice anything I could improve on or change, feel free to leave a comment on the assignment
 * grading page. All feedback positive or negative is welcomed. Thank you!
 */

namespace LeonardLibrary2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            Library library = new Library();
            int userEntry;

            //print header
            WriteLine("******************************************************");
            WriteLine("      LIBRARY MANAGEMENT SYSTEM VERSION 1.0");
            WriteLine("******************************************************");
            WriteLine();

            //print program instructions
            WriteLine("This tool helps you to manage a library's collections.");
            WriteLine("Please use the menu to choose what you want to do.");

            //do-while loop to run the program
            do
            {
                //print options
                WriteLine();
                WriteLine("1. List holdings\n2. Add a book\n3. Add a periodical\n4. Reserve a holding\n5. Return a holding\n6. See statistics\n7. Quit");

                //ask user for thier option
                Write("Enter the number of your choice: ");

                if (int.TryParse(ReadLine(), out userEntry))
                {
                    //switch statement to output the selected choice
                    switch (userEntry)
                    {
                        //list holdings
                        case 1:
                            library.ListAll();
                            break;
                        //add a book
                        case 2:
                            AddBook(library);
                            break;
                        //add a periodical
                        case 3:
                            AddPeriodical(library);
                            break;
                        //reserve a holding
                        case 4:
                            ReserveHolding(library);
                            break;
                        //return a holding
                        case 5:
                            ReturnHolding(library);
                            break;
                        //see statistics
                        case 6:
                            library.GetStats();
                            break;
                        //quit option
                        case 7:
                            WriteLine("\nThank you for using this program.");
                            break;
                        //default case
                        default:
                            WriteLine("Invalid input, Please try again");
                            break;
                    }
                } else WriteLine("Invalid input, Please try again");
            } while (userEntry != 7);
        }

        //method used to add a book
        static void AddBook(Library library)
        {
            //ask user for ID number of the book
            Write("Enter ID number: ");
            int id = int.Parse(ReadLine());

            //ask user for the book title
            Write("Enter Title: ");
            string title = ReadLine();

            //ask user for a description of the book
            Write("Enter Description: ");
            string description = ReadLine();

            //ask user for the copyright year of the book
            Write("Enter Copyright year: ");
            int copyRightYear = int.Parse(ReadLine());

            //ask user for the author of the book
            Write("Enter Author: ");
            string author = ReadLine();

            Book book = new Book(id, title, description, copyRightYear, author);
            library.AddHolding(book);
        }

        //method used to add a periodical
        static void AddPeriodical(Library library)
        {
            //ask user for the id number of the periodical
            Write("Enter ID Number: ");
            int id = int.Parse(ReadLine());

            //ask user for the title of the periodical
            Write("Enter Title: ");
            string title = ReadLine();

            //ask user for a description of the periodical
            Write("Enter Description: ");
            string description = ReadLine();

            //ask user for the date of the periodical
            Write("Enter date: ");
            string date = ReadLine();

            Periodical periodical = new Periodical(id, title, description, date);
            library.AddHolding(periodical);
        }

        //method used to reserve a holding
        static void ReserveHolding(Library library)
        {
            //ask the user the id number of the book/periodical they want to reserve
            Write("Enter the ID number of the holding to reserve: ");
            int id = int.Parse(ReadLine());
            library.CheckOut(id);
        }

        //method used to return a holding
        static void ReturnHolding(Library library)
        {
            //ask the user for the id number of the book/periodical they want to return
            Write("Enter the ID number of the holding to return: ");
            int id = int.Parse(ReadLine());
            library.CheckIn(id);
        }
    }
}
