using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programmering_C_Sharp_Labb_2___Ny_version;

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

        public int itemnumber = 0;

        public Games_Page() {

            Merchandise games_Page = new Merchandise(headlineAndCategories, "Games_Page", listOfGames/*, itemNumbersStartAt*/);

            WhatGameToCreate(itemnumber);

        }

        public static void WhatGameToCreate(int itemnumber) {

            if (itemnumber == 101) {

                MakeAGame(Game1);

            }

            if (itemnumber == 102) {

                MakeAGame(Game2);

            }

            if (itemnumber == 103) {

                MakeAGame(Game3);

            }

            if (itemnumber == 104) {

                MakeAGame(Game4);

            }

        }

        public static void MakeAGame(string[] GameValuesArray) {

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



            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Tillagd i kundvagnen: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(GameValuesArray[0] + "\n");
            Console.ResetColor();

        }

    }
}
