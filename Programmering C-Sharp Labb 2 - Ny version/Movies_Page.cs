using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programmering_C_Sharp_Labb_2___Ny_version;

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

        public int itemnumber = 0;

        public Movies_Page() {


            Merchandise movies_Page = new Merchandise(headlineAndCategories, "Movies_Page", listOfMovies/*, itemNumbersStartAt*/);

            WhatMovieToCreate(itemnumber);

        }

        public static void WhatMovieToCreate(int itemnumber) {

            if (itemnumber == 101) {

                MakeAMovie(Movie1);

            }

            if (itemnumber == 102) {

                MakeAMovie(Movie2);

            }

            if (itemnumber == 103) {

                MakeAMovie(Movie3);

            }

        }

        public static void MakeAMovie(string[] MovieValuesArray) {

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
            Console.WriteLine(MovieValuesArray[0] + "\n");
            Console.ResetColor();

        }

    }
}
