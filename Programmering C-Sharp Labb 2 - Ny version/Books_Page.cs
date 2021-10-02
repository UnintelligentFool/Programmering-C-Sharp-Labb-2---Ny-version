using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programmering_C_Sharp_Labb_2___Ny_version;

namespace Programmering_C_Sharp_Labb_2_Ny_version {
    class Books_Page {




        //Jobba med priser som heltal - Niklas använder nog "." och min dator använder nog "," för att se decimaler. Enklast så...
        //Bok Titel, Författare, Pris, Varunummer
        public static string[] Book1 = new string[] { "Ödets Fullbordan", "David Eddings", "99", "101" };
        public static string[] Book2 = new string[] { "Elantris", "Brandon Sanderson", "85", "102" };//Riktigt pris! (Pocket)
        public static string[] Book3 = new string[] { "Sista Riket", "Brandon Sanderson", "212", "103" };
        public static string[] Book4 = new string[] { "Svarta Tornet", "Robert Jordan", "169", "104" };//Riktigt pris! (Hardback)
        public static string[] Book5 = new string[] { "The Saga of Tanya the Evil", "Carlo Zen", "179", "105" };//Riktigt pris! ("Pocket"? Stor men utan hård rygg... Vad kallas det?)
        public static string[] Book6 = new string[] { "The Eye of the World", "Robert Jordan", "79", "106" };
        public static string[] Book7 = new string[] { "The Great Hunt", "Robert Jordan", "79", "107" };

        public static List<string[]> listOfBooks = new List<string[]>() { Book1, Book2, Book3, Book4, Book5, Book6, Book7 };

        public static string[] headlineAndCategories = new string[] { "Böcker", "Titel", "Författare", "Pris", "Varunummer" };

        //int itemNumbersStartAt = 100;

        //public int itemnumber = 102;

        private static int itemnumber = 0;

        public static int Itemnumber {
            get { return itemnumber; }
            set { itemnumber = value; }
        }


        public Books_Page() {

            Merchandise books_Page = new Merchandise(headlineAndCategories, "Books_Page", listOfBooks/*, itemNumbersStartAt*/);

            WhatBookToCreate(itemnumber);

        }

        public static void WhatBookToCreate(int itemnumber) {

            if (itemnumber == 101) {

                MakeABook(Book1);

            }

            if (itemnumber == 102) {

                MakeABook(Book2);

            }

            if (itemnumber == 103) {

                MakeABook(Book3);

            }

            if (itemnumber == 104) {

                MakeABook(Book4);

            }

            if (itemnumber == 105) {

                MakeABook(Book5);

            }

            if (itemnumber == 106) {

                MakeABook(Book6);

            }

            if (itemnumber == 107) {

                MakeABook(Book7);

            }

        }

        public static void MakeABook(string[] BookValuesArray) {

            //NewItem newBook = new NewItem(Book1[0], Book1[1], Book1[2], Book1[3]);
            //Console.WriteLine("We just created " + newBook.Title.ToString());

            //NewItem newBook2 = new NewItem();
            //newBook2.Title = Book2[0];
            //newBook2.Author = Book2[1];
            //newBook2.ItemNumber = Book2[2];
            //newBook2.Price = Book2[3];
            //Console.WriteLine("We just created " + newBook2.Title.ToString());

            /*
            for (int i = 0; i < listOfBooks.Count; i++) {

                NewItem newBook = new NewItem();
                newBook.Title = listOfBooks[i][0];
                newBook.Author = listOfBooks[i][1];
                newBook.ItemNumber = listOfBooks[i][2];
                newBook.Price = listOfBooks[i][3];

                //Console.WriteLine("We just created " + newBook.Title.ToString());

            }
            */

            NewItem newBook = new NewItem();
            newBook.Title = BookValuesArray[0];
            newBook.Author = BookValuesArray[1];
            newBook.ItemNumber = BookValuesArray[2];
            newBook.Price = BookValuesArray[3];

            Itemnumber = 0;

            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Tillagd i kundvagnen: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(newBook.Title.ToString() + "\n");
            Console.ResetColor();

            //Console.ReadKey();

            Program.Books();

        }

    }
}


//Denna sida får nu ett omdefinierat uppdrag: Ropa på merchandise klassen samt sänd dit en lista med böcker. Använd sedan den klassen för att skriva ut allt.
//Gör samma med Games_Page och Movies_Page.









































//Ungefär som meny sidan? ....Tusen for loopar....?
//
//Lista som sparar Böcker, författare, pris.
//Kan använda samma om man gör för spel, Titel, utvecklare, pris.
//För filmer, Titel, filmföretag, pris.
//Med andra ord 3 string arrayer i en lista, där pris arrayen omvandlas till en double med Parse. (TryParse onödig eftersom inte användaren påverkar?)
//
//Skriv ut listan i ordning.
//Ordna tre rader med de tre olika.
//Använda en klass/interface för att skriva ut en lista som definieras och skrivs in här?
//
//Background color som passar böcker, kanske Foregroundcolor som passar Background color
//
//Funktionalitet: knappar som går att trycka på för att lägga i produkter i vagnen. Sänd med Bok,
//styckpris, antal av varje bok samt pris som definieras för hela köpet, men det kan kanske skötas
//av annan klass, View_Shopping_Cart.
//
//Rent teoretiskt kan man skapa tre olika sidor från samma klass, sänd bara in olika värden genom parametrar..... Dålig ide eller bra...?








//En sida som kan hjälpa till med att skapa en lista med arrayer är:
//https://stackoverflow.com/questions/549399/c-sharp-creating-an-array-of-arrays/549417