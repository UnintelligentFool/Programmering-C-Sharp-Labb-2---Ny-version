using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Books_Page() {

            Merchandise books_Page = new Merchandise(headlineAndCategories, "Books_Page", listOfBooks/*, itemNumbersStartAt*/);

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