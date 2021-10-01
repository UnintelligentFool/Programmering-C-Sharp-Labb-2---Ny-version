using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Ny_version {
    public class Menu {

        private string[] firstMenuArray = new string[] { "1 Logga in", "2 Skapa ny användare", "3 Logga inte in" };
        private string[] secondMenuPartOneArray = new string[] { "1 Böcker", "2 Datorspel", "3 Filmer" };
        private string[] thirdMenuPartTwoArray = new string[] { "K Kundvagn", "B Betala", "L Logga in/ut" };

        public Menu(bool isThisTheFirstMenu) {

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int a = 0; a < 30; a++) {

                Console.Write("#");

            }

            Console.WriteLine();

            int arrayLength = 0;

            if (isThisTheFirstMenu == true) {

                arrayLength = firstMenuArray.Length;

            } else {

                arrayLength = secondMenuPartOneArray.Length;

            }

            for (int i = 0; i < arrayLength; i++) {

                for (int d = 0; d < 30; d++) {

                    if (d == 0 || d == 29) {

                        Console.Write("#");

                    } else {

                        Console.Write(" ");

                    }

                }

                Console.WriteLine();

                Console.Write("#   ");

                string arrayValueToBeWrittenOut = "";

                if (isThisTheFirstMenu == true) {

                    arrayValueToBeWrittenOut = firstMenuArray[i];

                } else {

                    arrayValueToBeWrittenOut = secondMenuPartOneArray[i];

                }

                Console.Write(arrayValueToBeWrittenOut);//substring + räkna hur många char som skrivs ut //Nope.

                for (int e = 0; e < (25 - arrayValueToBeWrittenOut.Length); e++) {

                    Console.Write(" ");

                }

                Console.Write("#");

                Console.WriteLine();

            }

            for (int b = 0; b < 30; b++) {

                if (b == 0 || b == 29) {

                    Console.Write("#");

                } else {

                    Console.Write(" ");

                }

            }

            Console.WriteLine();

            for (int c = 0; c < 30; c++) {

                Console.Write("#");

            }

            Console.WriteLine();

            if (isThisTheFirstMenu == false) {

                for (int h = 0; h < 30; h++) {

                    if (h == 0 || h == 29) {

                        Console.Write("#");

                    } else {

                        Console.Write(" ");

                    }

                }

                Console.WriteLine();

                for (int j = 0; j < thirdMenuPartTwoArray.Length; j++) {

                    Console.Write("#   ");

                    string arrayValueToBeWrittenOut = thirdMenuPartTwoArray[j];

                    Console.Write(arrayValueToBeWrittenOut);

                    for (int e = 0; e < (25 - arrayValueToBeWrittenOut.Length); e++) {

                        Console.Write(" ");

                    }

                    Console.Write("#\n");

                }

                for (int g = 0; g < 30; g++) {

                    if (g == 0 || g == 29) {

                        Console.Write("#");

                    } else {

                        Console.Write(" ");

                    }

                }

                Console.WriteLine();

                for (int f = 0; f < 30; f++) {

                    Console.Write("#");

                }

            }

            Console.WriteLine();

            Console.ResetColor();

        }
    }
}


/*

    För första menyn, introduktionssidan: Gör en array med de olika menyalternativen. Skriv en foreach. Innan foreach, bara "#" exempelvis. 
    Sedan foreach där startar och avslutar med "#". Fyll ut tomrum med mellanrum. Lägg in orden från arrayen med nummer "1", "2", "3" etcetera i mitten.
    Resultat en ram med ord och siffror för vad man skall skriva för olika alternativ. Antingen 1. Logga in eller 2. Ny användare.

    Korrigering, börja med texten på menyalternativen på den femte x-axel positionen.

    Gör första menyn på totalt 30 tecken i x-led och 2 rader ovan, 2 rader under samt en rad per menyalternatic plus en rad med ett mellanrum. (Fortfarande # på kanterna.)
    Exempel: "#####" rad, följd av tom "#     #" rad, följd av "Menyalternativ" + tom "#     #" rad, följd av "#####" rad.

    Resultat:

    ##############################
    #                            #
    #   1. Logga in              #
    #                            #
    #   2. Skapa ny användare    #
    #                            #
    ##############################

    
    ALTERNATIVT:
    Gör samma meny, återanvänd, för båda menyerna - men använd olika arrayer. Istället för att skriva om koden mer, 
    gör bara if satsen för just det? Kanske skapa en variabel som ändras och styr det om det behövs?

    För huvudmenyn - Två arrayer, mellanrum mellan varornas kategorier och de andra kategorierna? Kanske överkurs - få allt att fungera först?

    
    När man loggar in/ut, kolla om man redan är inloggad.
    
    Spara kundkorg om man loggar in men tömm om man loggar ut/in med annan (kolla nogare vad som står)

*/
















































//namespace Programmering_C_Sharp_Labb_2_Try2 {
//    public class Menu {

//        public bool isItTheFirstMenu;

//        private string[] firstMenuArray = new string[] { "1. Logga in", "2. Skapa ny användare" };

//        public Menu(bool isThisTheFirstMenu) {

//            isItTheFirstMenu = isThisTheFirstMenu;

//            if (isItTheFirstMenu == true) {



//            } else {



//            }

//        }
//    }
//}






















/*
 
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Try3 {
    public class First_Menu {

        public bool isItTheFirstMenu;

        private string[] firstMenuArray = new string[] { "1. Logga in", "2. Skapa ny användare" };
        
        public First_Menu (bool isThisTheFirstMenu) {

            isItTheFirstMenu = isThisTheFirstMenu;

            if(isItTheFirstMenu == true) {

                //Console.WriteLine("First");
                //Console.Clear();
                for (int b = 0; b < 30; b++) {

                    Console.Write("#");

                }

                Console.WriteLine();

                for (int i = 0; i < firstMenuArray.Length; i++) {

                    if(i == 0) {

                        

                    }

                }
                


            } else {
                //Console.Clear();
                //Console.WriteLine("Second");

                for (int c = 0; c < 30; c++) {

                    Console.Write("#");

                }

                for (int a = 0; a < secondMenuPartOneArray.Length; a++) {



                }

            }
            
        }
    }
}
 
 */























/*
 
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Try3 {
    public class Main_Menu {

        private string[] mainMenuPartOneArray = new string[] { "1. Böcker", "2. Datorspel", "3. Filmer" };
        private string[] mainMenuPartTwoArray = new string[] { "K Kundvagn", "B Betala", "L Logga in/ut" };

        public Main_Menu() {

            //Console.Clear();
            //Console.WriteLine("Second");

            for (int a = 0; a < 30; a++) {

                Console.Write("#");

            }

            for (int i = 0; i < mainMenuPartOneArray.Length; i++) {



            }

            for (int b = 0; b < 30; b++) {

                Console.Write("#");

            }

            Console.WriteLine();

        }
    }
}
 
 */