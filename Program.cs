using LibraryAssignmentInterfaces.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAssignmentInterfaces
{
    internal class Program
    {
        static void Main()
        {
            Book book = new Book()
            {
                Author = "Thomas E.",
                Borrower = "Jose Martinez",
                Title = "Los Perez en Valle",
                ISBN  = "14902 898032 32849043"               
           };
           CD CD = new CD()
           {
               Director = "Jualin A.",
               Borrower = "Jose Perez",
               Title = "This song E",
               LengthInMinutes = "31"
           };
           DVD Dvd = new DVD()
           {
               Artist = "Kevin A.",
               Borrower = "Smither Perez",
               Title = "DVD - Harry F.",
               NumberOfTracks = "6"
           };

            Console.WriteLine("CD DETAILS");
            CD.Print();
            CD.Borrow(CD.Borrower);
            CD.Return(CD.LoanPeriod);
            Console.WriteLine();
            Console.WriteLine("DVD DETAILS");
            Dvd.Print();
            Dvd.Borrow(Dvd.Borrower);
            Dvd.Return(Dvd.LoanPeriod);
            Console.WriteLine();
            Console.WriteLine("BOOK DETAILS");
            book.Print();
            book.Borrow(book.Borrower);
            book.Return(book.LoanPeriod);



        }
    }
}
