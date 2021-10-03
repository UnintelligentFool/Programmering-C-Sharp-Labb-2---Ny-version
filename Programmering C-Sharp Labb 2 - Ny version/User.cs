using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programmering_C_Sharp_Labb_2___Ny_version;

namespace Programmering_C_Sharp_Labb_2_Ny_version {
    //class User : Create_New_User {
    class User : Bridge /*: INewItem*/ {

        private string name;

        public string Name {
            get { return name; }
            set { name = value; }
        }


        private string lastName;

        public string Lastname {
            get { return lastName; }
            set { lastName = value; }
        }


        private string userName;

        public string Username {
            get { return userName; }
            set { userName = value; }
        }


        private string membershipLevel;

        public string MembershipLevel {
            get { return membershipLevel; }
            set { membershipLevel = value; }
        }


        private string password;

        public string Password {
            get { return password; }
            private set { password = value; }
        }


        private static List<string[]> usersShoppingCart;

        public List<string[]> UsersShoppingCart {//Får inte lov att vara statisk enligt Niklas! .... Dags att fäörändra och skapa problem......
            get { return usersShoppingCart; }
            set { usersShoppingCart = value; }
        }

        //NewItem...
        //
        //NewItem...
        //
        //NewItem...

        private static List<string[]> newCart;

        public List<string[]> NewCart {
            get { return newCart; }
            set { newCart = value; }
        }

        //public string Author { get; set; }
        //public string ItemNumber { get; set; }
        //public string Price { get; set; }
        //public string Title { get; set; }

        public User(string username/*, string password*/) {

            CheckCart();

        }

        //List<string[]> iHateCarts = new List<string[]>(UsersShoppingCart);//Die cart die

        public User(string username, string password, string name, string lastname, string membershipLevel/*, List<string[]> shoppingcart*/) {
            Name = name;
            Lastname = lastname;
            Username = username;
            MembershipLevel = membershipLevel;
            Password = password;
            
            //UsersShoppingCart = shoppingcart;
            
//            for (int i = 0; i < shoppingcart.Count; ) {
//
//                UsersShoppingCart.Add(shoppingcart[i]);
//
//                shoppingcart.RemoveAt(i);
//
//            }

            /*for (int i = 0; i < shoppingcart.Count; i++) {

                UsersShoppingCart.Add(shoppingcart[i]);

            }*/

            //UsersShoppingCart = new List<string[]>(Program.shoppingCartList);

            //List<string[]> usersCart = new List<string[]>(Program.shoppingCartList);//Fungerade..

            //UsersShoppingCart.AddRange(Program.shoppingCartList);
            //UsersShoppingCart = shoppingcart;
            //UsersShoppingCart.AddRange(Program.shoppingCartList);

            //List<string[]> iHateCarts = new List<string[]> (UsersShoppingCart);
            
            //iHateCarts.GetRange(0, UsersShoppingCart.Count;

            string[] newUser = new string[] { username, password, name, lastname, membershipLevel /*, shoppingcart */ };

            Program.listOfUsers.Add(newUser);

        }

//        public User(string title, string author, string itemnumber, string price) {
//
//            //List<string[]> newCart = UsersShoppingCart;
//
//            /*            string[] itemsToAdd = { title, author, itemnumber, price };
//
//                        NewCart.Add(itemsToAdd);
//
//                        Console.WriteLine("Added item to cart! " + itemnumber);
//            */
//
//            Console.WriteLine("What's happening?");
//
//        }

        //public static void ReceivingItems(string Title, string Author, string ItemNumber, string Price) {
//        public static void ReceivingItems(string Title, string Author, string ItemNumber, string Price) {
//
//            Console.WriteLine("Game Over!");
//
//        }

        public User() {
            //ReceivingItems;

            Console.WriteLine("Work! Work! Work!");

            //if (ItemsBeingSent != null) {

            //Console.WriteLine(ItemsBeingSent[0]);
            //NewCart.Add(ItemsBeingSent);
            NewCart.Add(ArrayOfItems);
                Console.WriteLine("ItemsBeingSent received by User class!");
                Console.WriteLine("User is getting a: " + NewCart[(NewCart.Count - 1)]);
                //ItemsBeingSent = null;

            //}

            Console.WriteLine("Noooooo!");

        }

        public static void CheckCart() {

            for (int i = 0; i < User.newCart.Count; i++) {

                Console.WriteLine(User.newCart[i][0]);

            }

        }
        
        //Death! Death! DEATH! - Theoden, warcry before charging in his last battle

        //public static void ShowMeYourCart() {



        //}

    }
}


/*
 
 Två sätt att komma åt användaren, två konstruktorer? En där användare skapas och en som körs vid inloggning? Är det vad jag håller på med? O.o
 
*/


/*
 
 string name;

 string lastName;

 string vipMember; //4 värden, om jag implementerar det, "No"/"Bronze"/"Silver"/"Gold"

 string password;
 
 */