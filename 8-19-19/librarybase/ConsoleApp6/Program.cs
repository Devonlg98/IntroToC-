using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp6
{
    class Program
    {
        struct Book
        {
            public string author;
            public string title;
            public int shelf;
            public bool checkedout;
        }

        static void Main(string[] args)
        {
            Book[] library = new Book[50];
            int libraryCount = 0;
            int libraryidx = 0;
            

            string cmd = "";
            string lCmd = "";
            Example1 eg = new Example1();
            while (cmd.ToLower() != "exit")
            {
                cmd = eg.Ask("Awaiting input?");
                lCmd = cmd.ToLower();
                if(lCmd=="add")
                {
                    Book tmp = new Book();
                    tmp.author = eg.Ask("Please enter Author >");
                    tmp.title = eg.Ask("Please enter Title >");
                    tmp.checkedout = false;
                    int.TryParse(eg.Ask("Please enter Current Shelf >"), out tmp.shelf);
                    
                    library[libraryCount] = tmp;
                    libraryCount++;
                }
                if (lCmd == "list")
                {
                    for (int idx = 0; idx < libraryCount; idx++)
                    {
                        Book book = library[idx];
                        eg.MyPrinter($"Book Index={idx} : {book.author}, {book.title}, {book.shelf}, {book.checkedout}");
                    }

                }
                if (lCmd == "delete")
                {
                    int deleteBook = 0;
                    int.TryParse(eg.Ask("What number book in the list would you like to delete?"), out deleteBook);// Take users requested deletion line
                    for (int fix = 1; fix < libraryCount; fix++) // moves the entire list up on in the array ex. 1->2 2->3 3->4
                    {
                        library[deleteBook] = library[deleteBook + 1]; // set value of requested line equal to the line above ex. requestedDelete = book above in array
                        deleteBook++; // Change users requested line to be the line above ex. book above in array = requestedDelete
                    }
                    libraryCount--; // deletes last line
                    
                }
                if (lCmd == "checkout")
                {
                    int bookFind = 0;
                    string checkedOutx;
                    int.TryParse(eg.Ask("What number book in the list are you looking for?"), out bookFind);
                    Book book = library[bookFind];
                    checkedOutx = eg.Ask($"Is {book.title} The book you would like to check out? (Y/N)");

                    if (checkedOutx == "Y")
                    {
                        library[bookFind].checkedout = true;
                    }
                    else if (checkedOutx == "N")
                    {
                        Console.WriteLine("Ok, what would you like to do next?");
                    }
                    else
                    {
                        Console.WriteLine("You big dumb, thats not a Y or N");
                    }


                }
                if (lCmd == "return")
                {
                    int returnBook = 0;
                    int.TryParse(eg.Ask(" What number book in the list would you like to return?"), out returnBook);
                    library[returnBook].checkedout = false;
                }

                //implement delete book from library
                //implement checkout book from library (set the checked out bool to true
                //implement return book
            }
            eg.MyPrinter("End of execution");
           
            Console.ReadKey();
        }
    }
}
