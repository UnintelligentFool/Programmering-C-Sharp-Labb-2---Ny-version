using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programmering_C_Sharp_Labb_2_Ny_version;

namespace Programmering_C_Sharp_Labb_2___Ny_version {

    
    public abstract class Bridge { //Bridge used for smuggling properties from one class to the next...

        //private int year;

        //public int Year {
        //    get { return year; }
        //    set { year = value; }
        //}

        private string[] itemsBeingSent;

        public string[] ItemsBeingSent {
            get { return itemsBeingSent; }
            set { itemsBeingSent = value; }
        }


        public Bridge() {

            //Year = 2012;

        }

        //public void deliverItems() {

            

        //}

        //Veni vidi vici - Gaius Julius Ceasar (Inte jag.)

    }
}
