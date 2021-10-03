using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programmering_C_Sharp_Labb_2___Ny_version;

namespace Programmering_C_Sharp_Labb_2_Ny_version {
    class NewItem : Bridge /*: INewItem*/ {//NewBook

        //public delegate void ProductToCart(string title, string author, string itemnumber, string price);

        private string title;//bookTitle

        public string Title {
            get { return title; }
            set { title = value; }
        }

        private string author;

        public string Author {
            get { return author; }
            set { author = value; }
        }

        private string itemNumber;//Varunummer

        public string ItemNumber {
            get { return itemNumber; }
            set { itemNumber = value; }
        }

        private string price;

        public string Price {
            get { return price; }
            set { price = value; }
        }

        public NewItem(string title, string author, string itemnumber, string price) {

            Title = title;
            Author = author;
            ItemNumber = itemnumber;
            Price = price;

        }

        public NewItem() {

            //SendingItem(Title, Author, ItemNumber, Price);

            //Year = 2021;

            ItemsBeingSent = new string[] { Title, Author, ItemNumber, Price};

        }

//        public NewItem(ProductToCart productToCart) {
//
//            //User sendingUserItems = new User(this.Title, this.Author, this.ItemNumber, this.Price);
//
//            productToCart(Title, Author, ItemNumber, Price);
//
//        }

//        public void SendingItem(Action<string> title, Action<string> author, Action<string> itemNumber, Action<string> price) {
//
//            //User sendingUserItems = new User(this.Title, this.Author, this.ItemNumber, this.Price);
//
//            //productToCart(Title, Author, ItemNumber, Price);
//
//            title(Title);
//            author(Author);
//            itemNumber(ItemNumber);
//            price(Price);
//            
//        }

    }
}

/*
  
    Istället för att lägga bok med nummer i en lista, lägga instansnamn i en lista? Skapa instans när nummer 
    skrivs in och sedan lägga dess namn i en lista i kund?

 */