using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Ny_version {
    class Games_Page {



        //Jobba med priser som heltal - Niklas använder nog "." och min dator använder nog "," för att se decimaler. Enklast så...
        //Spel Titel, Spelstudio, Pris, Varunummer
        public static string[] Game1 = new string[] { "Star Wars: Knights of the Old Republic", "BioWare Corp.", "299", "301" };
        public static string[] Game2 = new string[] { "Mass Effect", "BioWare", "179", "302" };
        public static string[] Game3 = new string[] { "Warlords Battlecry II", "SSG and Ubisoft", "189", "303" };
        public static string[] Game4 = new string[] { "Neverwinter Nights", "BioWare Corp.", "349", "304" };

        public static List<string[]> listOfGames = new List<string[]>() { Game1, Game2, Game3, Game4 };

        public static string[] headlineAndCategories = new string[] { "Datorspel", "Spel", "Spelstudio", "Pris", "Varunummer" };

        //int itemNumbersStartAt = 300;

        public Games_Page() {

            Merchandise games_Page = new Merchandise(headlineAndCategories, "Games_Page", listOfGames/*, itemNumbersStartAt*/);

        }

    }
}
