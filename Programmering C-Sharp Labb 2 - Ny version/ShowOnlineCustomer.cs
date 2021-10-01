using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Ny_version {
    class ShowOnlineCustomer {

        public static bool isSomeoneLoggedIn = false;

        public static string userLoggedIn = "";

        public  ShowOnlineCustomer(bool isSomeoneOnline, string userOnline /*bool isSomeoneOnlineNow*/) {

            isSomeoneLoggedIn = isSomeoneOnline;
            userLoggedIn = userOnline;

            if (isSomeoneLoggedIn == true) {

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("++++++++++++++++++++++++++++++");

                Console.Write("+");

                int spacesBetweenBorderAndName = 0;

                for (int i = 0; i < ((29 - userLoggedIn.Length) / 2); i++) {

                    Console.Write(" ");

                    spacesBetweenBorderAndName++;

                }

                Console.Write(userLoggedIn);

                for (int i = 0; i < (28 - userLoggedIn.Length - spacesBetweenBorderAndName); i++) {

                    Console.Write(" ");

                }

                Console.Write("+");

                Console.WriteLine();

                Console.ResetColor();

            } else {

                //Console.Clear();

            }

        }

    }
}
