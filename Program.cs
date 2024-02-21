using System.Runtime.InteropServices;
using static System.Console;

/*
 * NAME: Jaiden Leonard
 * CLASS: .NET Programming
 * ASSIGNMENT: Library
 * DATE: 2/20/24 (Will change with updates)
 * 
 * PURPOSE:
 * The purpose of this program is to manage a library system. It lets the user do various tasks like adding books
 * and periodicals to the collection, listing all of the library's holdings, returning or checking out holdings,
 * and viewing the statistics of the library's holdings.
 * 
 * STRUGGLES:
 * %% Finish %%
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
                WriteLine("Enter the number of your choice: ");

                if (int.TryParse(ReadLine(), out userEntry))
                {
                    //switch statement to output the selected choice
                    switch (userEntry)
                    {
                        //list holdings
                        case 1:
                            //%% Finish %%
                            break;
                        //add a book
                        case 2:
                            //%% Finish %%
                            break;
                        //add a periodical
                        case 3:
                            //%% Finish %%
                            break;
                        //reserve a holding
                        case 4:
                            //%% Finish %%
                            break;
                        //return a holding
                        case 5:
                            //%% Finish %%
                            break;
                        //see statistics
                        case 6:
                            //%% Finish %%
                            break;
                        //quit option
                        case 7:
                            WriteLine("Thank you for using this program.");
                            break;
                        //default case
                        default:
                            WriteLine("Invalid input, Please try again");
                            break;
                    }
                } else WriteLine("Invalid input, Please try again");
            } while (true);
        }
    }
}
