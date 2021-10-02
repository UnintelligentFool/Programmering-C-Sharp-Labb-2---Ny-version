using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Ny_version {
    class NewItem {//NewBook

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

            User sendingUserItems = new User(this.Title, this.Author, this.ItemNumber, this.Price);
            
        }

    }
}

/*
  
    Istället för att lägga bok med nummer i en lista, lägga instansnamn i en lista? Skapa instans när nummer 
    skrivs in och sedan lägga dess namn i en lista i kund?

 */