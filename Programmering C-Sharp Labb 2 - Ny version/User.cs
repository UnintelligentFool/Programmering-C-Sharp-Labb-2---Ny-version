using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Ny_version {
    class User : Create_New_User {


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

        public static List<string[]> UsersShoppingCart {//Får inte lov att vara statisk enligt Niklas! .... Dags att fäörändra och skapa problem......
            get { return usersShoppingCart; }
            set { usersShoppingCart = value; }
        }


        public User(string username, string password) {



        }

        //List<string[]> iHateCarts = new List<string[]>(UsersShoppingCart);//Die cart die

        public User(string username, string password, string name, string lastname, string membershipLevel, List<string[]> shoppingcart) {
            Name = name;
            Lastname = lastname;
            Username = username;
            MembershipLevel = membershipLevel;
            Password = password;
            
            //UsersShoppingCart = shoppingcart;
            
            for (int i = 0; i < shoppingcart.Count; ) {

                UsersShoppingCart.Add(shoppingcart[i]);

                shoppingcart.RemoveAt(i);

            }

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

        public User() {

            List<string[]> newCart = UsersShoppingCart;


        }

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