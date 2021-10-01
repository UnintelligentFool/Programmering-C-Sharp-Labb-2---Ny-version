using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Ny_version {
    class Movies_Page {


        //Jobba med priser som heltal - Niklas använder nog "." och min dator använder nog "," för att se decimaler. Enklast så...
        //Film Titel, Filmbolag, Pris, Varunummer
        public static string[] Movie1 = new string[] { "Black Book", "Egmont", "129", "201" };
        public static string[] Movie2 = new string[] { "Star Wars III - Mörkrets Hämnd", "Lucasfilm Ltd.", "119", "202" };
        public static string[] Movie3 = new string[] { "Appleseed", "Digital Frontier", "99", "203" };

        public static List<string[]> listOfMovies = new List<string[]>() { Movie1, Movie2, Movie3 };

        public static string[] headlineAndCategories = new string[] { "Filmer", "Film", "Filmbolag", "Pris", "Varunummer" };

        //int itemNumbersStartAt = 200;

        public Movies_Page() {


            Merchandise movies_Page = new Merchandise(headlineAndCategories, "Movies_Page", listOfMovies/*, itemNumbersStartAt*/);

        }

    }
}
