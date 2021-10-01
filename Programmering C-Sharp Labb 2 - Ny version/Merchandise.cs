using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Ny_version {
    class Merchandise {
        public Merchandise(string[] headerAndCategories, string merchandise_Page, List<string[]> merchandiseList/*, int itemNumbers*/) {//Kom ihåg att kontrollera om jag skall ta bort merchandise_Page

            string kindOfMerchandise = merchandise_Page;

            //int itemNumber = itemNumbers;

            List<string[]> listOfMerchandise = merchandiseList;

            string header = headerAndCategories[0];
            string categoryOne = headerAndCategories[1];
            string categoryTwo = headerAndCategories[2];
            string categoryThree = headerAndCategories[3];
            string categoryFour = headerAndCategories[4];

            /*
            Console.WriteLine(merchandiseList[0][0]);//Exempel: Bok 1, värde 1. Bok 1 = BokArray 1, värde är det första värdet i arrayen.
            Console.WriteLine(merchandiseList[0][1]);//Exempel: Bok 1, värde 2. Bok 1 = BokArray 1, värde är det andra värdet i arrayen.
            Console.WriteLine(merchandiseList[0][2]);//Exempel: Bok 1, värde 3. Bok 1 = BokArray 1, värde är det tredje värdet i arrayen.
            */

            ////Skriv ut sådant som kategorier och kanhända rubriker:
            //if(kindOfMerchandise == "Books_Page") {
            //} else if(kindOfMerchandise == "Games_Page") {
            //} else if(kindOfMerchandise == "Movies_Page") {
            //} else {
            //}

            Console.WriteLine("\n     För att handla, skriv varunummret på varan du vill köpa.");

            Console.WriteLine("\n");

            for (int a = 0; a < 107; a++) {

                if (a < 5) {

                    Console.Write(" ");

                } else {

                    if (a % 2 == 0) {

                        Console.Write(">");

                    } else {

                        Console.Write("<");

                    }

                }

            }

            Console.WriteLine();

            for (int b = 0; b < 107; b++) {

                if (b < 5) {

                    Console.Write(" ");

                } else if (b == 5 || b == 105) {

                    Console.Write("<");

                } else if (b == 6 || b == 106) {

                    Console.Write(">");

                } else {

                    int adjustUnevenNumber = 0;

                    if (header.Length % 2 == 0) {

                        adjustUnevenNumber = 0;

                    } else {

                        adjustUnevenNumber = 1;

                    }

                    if (b < (56 - header.Length / 2)) {

                        Console.Write(" ");

                    } else if (b == (56 - header.Length / 2)) {

                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.Write(header);

                        Console.ResetColor();

                    } else if (b > 52 + header.Length - adjustUnevenNumber) {

                        Console.Write(" ");

                    }

                }

            }

            Console.WriteLine();

            for (int c = 0; c < 107; c++) {

                if (c < 5) {

                    Console.Write(" ");

                } else {

                    if (c % 2 == 0) {

                        Console.Write(">");

                    } else {

                        Console.Write("<");

                    }

                }

            }

            Console.WriteLine();

            for (int d = 0; d < 107; d++) {

                if (d < 5) {

                    Console.Write(" ");

                } else if (d == 5 || d == 93) {

                    Console.Write("<");

                } else if (d == 6 || d == 94) {

                    Console.Write(">");

                } else {

                    int adjustUnevenNumber = 0;

                    if (categoryOne.Length % 2 == 0) {

                        adjustUnevenNumber = 0;

                    } else {

                        adjustUnevenNumber = 1;

                    }

                    if (d == (27 - categoryOne.Length / 2)) {

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write(categoryOne);

                        Console.ResetColor();

                    }

                    if (d == 34 - adjustUnevenNumber) {

                        Console.Write("<>");

                    }

                    if (categoryTwo.Length % 2 == 0) {

                        adjustUnevenNumber = 0;

                    } else {

                        adjustUnevenNumber = 1;

                    }

                    if (d < ((54 - categoryOne.Length) - categoryTwo.Length / 2)) {

                        Console.Write(" ");

                    } else if (d == 54 - categoryTwo.Length / 2) {

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write(categoryTwo);

                        Console.ResetColor();

                    }

                    int secondAdjustUnevenNumber = 0;

                    if (categoryThree.Length % 2 == 0) {

                        secondAdjustUnevenNumber = 0;

                    } else {

                        secondAdjustUnevenNumber = 1;

                    }

                    if (d == 70 + (categoryTwo.Length + adjustUnevenNumber) / 2) {

                        Console.Write("<>");

                    }

                    int thirdAdjustUnevenNumber = 0;

                    if (categoryOne.Length % 2 == 0) {

                        thirdAdjustUnevenNumber = 0;

                    } else {

                        thirdAdjustUnevenNumber = 1;

                    }

                    if (d == 64 + categoryOne.Length + categoryTwo.Length + categoryThree.Length / 2 + adjustUnevenNumber - secondAdjustUnevenNumber - thirdAdjustUnevenNumber) {

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write(categoryThree);

                        Console.ResetColor();

                    } else if (d > 55 + categoryTwo.Length + adjustUnevenNumber - secondAdjustUnevenNumber) {

                        Console.Write(" ");

                    }

                    if (d == 80 + (categoryTwo.Length + adjustUnevenNumber) / 2) {

                        Console.Write("<>");

                    }

                    if (d == 86 + categoryThree.Length / 2) {

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write(categoryFour);

                        Console.ResetColor();

                    }

                }

            }

            Console.WriteLine();

            for (int e = 0; e < 107; e++) {

                if (e < 5) {

                    Console.Write(" ");

                } else {

                    if (e % 2 == 0) {

                        Console.Write(">");

                    } else {

                        Console.Write("<");

                    }

                }

            }

            Console.WriteLine("\n\n");

            for (int f = 0; f < 107; f++) {

                if (f < 5) {

                    Console.Write(" ");

                } else if (f == 5) {

                    Console.Write("<");

                } else if (f == 106) {

                    Console.Write(">");

                } else {

                    Console.Write("-");

                }

            }

            Console.WriteLine();

            for (int i = 0; i < listOfMerchandise.Count; i++) {

                for (int g = 0; g < 107; g++) {

                    if (g < 5) {

                        Console.Write(" ");

                    } else if (g == 5) {

                        Console.Write("<");

                    } else if (g == 6) {

                        Console.Write("-");

                    } else if (g > 6 && g < 10) {

                        Console.Write(" ");

                    }

                }

                if (i % 2 == 0) {

                    Console.ForegroundColor = ConsoleColor.Blue;
                    //Console.BackgroundColor = ConsoleColor.Blue;

                } else {

                    Console.ForegroundColor = ConsoleColor.Red;
                    //Console.BackgroundColor = ConsoleColor.Red;

                }

                Console.Write(listOfMerchandise[i][0]);
                
                for (int j = 0; j < 46 - (listOfMerchandise[i][0].Length) - (listOfMerchandise[i][1].Length / 2); j++) {

                    Console.Write(" ");

                }

                Console.Write(listOfMerchandise[i][1]);

                int fourthAdjustmentNumber = 0;

                if (listOfMerchandise[i][1].Length % 2 == 0) {

                    fourthAdjustmentNumber = 0;

                } else {

                    fourthAdjustmentNumber = 1;

                }

                for (int k = 0; k < 21 - fourthAdjustmentNumber - (listOfMerchandise[i][1].Length / 2); k++) {

                    Console.Write(" ");

                }

                Console.Write(listOfMerchandise[i][2]);

                int sixthAdjustmentNumber = 0;

                if (listOfMerchandise[i][2].Length % 2 == 0) {

                    sixthAdjustmentNumber = 0;

                } else {

                    sixthAdjustmentNumber = 1;

                }


                for (int k = 0; k < 16 - sixthAdjustmentNumber - (listOfMerchandise[i][2].Length / 2); k++) {

                    Console.Write(" ");

                }

                Console.Write(listOfMerchandise[i][3]);
//
//                itemNumber++;
//
//                Console.Write(itemNumber);
//
                //string[] product[itemNumber] = listOfMerchandise[i];

                Console.ResetColor();

                //int fifthAdjustmentNumber = 0;

                //if (listOfMerchandise[i][2].Length % 2 == 0) {

                //    fifthAdjustmentNumber = 1;

                //} else {

                //    fifthAdjustmentNumber = 0;

                //}

                for (int h = 0; h < 10; h++) {

                    if (h == 8/* + fifthAdjustmentNumber*/) {

                        Console.Write("-");

                    } else if (h == 9/* + fifthAdjustmentNumber*/) {

                        Console.Write(">");

                    } else {

                        Console.Write(" ");

                    }

                }

                Console.WriteLine();

            }

            for (int j = 0; j < 107; j++) {

                if (j < 5) {

                    Console.Write(" ");

                } else if (j == 5) {

                    Console.Write("<");

                } else if (j == 106) {

                    Console.Write(">");

                } else {

                    Console.Write("-");

                }

            }

            Console.WriteLine();

        }
    }
}


// Överväg att sätta värdena för parametrarna som används för kategorierna "Pris" och "Varunummer" till just det, göra dem till
// interna variabler och ta bort de parametrarna så att man inte kan sända in någon annan kategori för de två fälten.


// Lägg till ett värde för varunummer. Ta emot en till parameter för varunummer, använd den parametern som "startvärdet" för varunummret.
// Öka med ett per iteration, när varunummer skrivs in, lägg till i varukorg.
// Lägg till information om hur man handlar, typ: "För att köpa en vara, skriv in varunummret till vänster om produkten med ett plus
// framför nummret. Skriv ett minus framför för att ta bort varan från varukorgen/kundvagnen."


//  Ram:
//  <---------------------------------->
//  <-                                ->
//  <-       Text text text           ->
//  <-       mer text text            ->
//  <-                                ->
//  <---------------------------------->
//
//
//  Rubrik/kategorier:
//
//  <><><><><><><><><><><><><><><><><>
//  <>            Rubrik            <>
//  <><><><><><><><><><><><><><><><><>
//  <>      Hej     <>     Svej     <>
//  <><><><><><><><><><><><><><><><><>
//
//  Proportioner för Ram: 15, 72, 15. Mellanrum mellan text och sidorna på 15 på båda sidor, 70 tecken som text därimellan
//
//  Sända array/lista som parameter för Rubrik/kategorier med? Ja? Spelar kindOfMerchandise ut sin roll då?
//
//  Proportioner för Rubrik/kategorier: Tre kategorier. Bredd på 102 tecken för det som skrivs ut. Justering: lägg till 5 tomma tecken till vänster.
//  Centrera rubriken i sitt fält.
//  För kategorier, centrera mitten kategorin. Komplicerat att räkna ut hur man skall få de andra att hamna rätt då alla tre
//  kategorierna påverkar varandra. Mitten av de orden på sidorna bör vara 34 tecken från kanten/sidan.
//



//Skapa en parameter som kontrollerar vilken typ av vara som skall visas --> Skriv ut olika kategorier med if statement, för att visa
//exempelvis titel/författare/spelföretag etcetera beroende på parametern. Ungefär som menyerna.

//Skriva "+1" för att öka vara nummer ett med en samt "-1" för att ta bort vara 1 med en?
//
//Går det att arbeta vidare med denna iden - göra så att när denna klass körs blir olika nummer
//olika varor ad infinitum? Så, om 4657 varor är vara nummer 4632 den vara man köper om man skriver in 4633?
//Använda en for loop som ger vilket värde som skall skrivas ut i sådana fall.
//Måste även ändra till andra (ej siffror) tangenter som man använder för meny systemet.
//Nej: Börja ange siffror med variabel som startar på högre värde för produkterna!
//Exempelvis starta med produktnummer från 10. Första "produktnummret" kan bli 11, och så vidare.
//Annars krockar det med systemet för siffror för menyn och bokstäver för de andra menyalternativen, främst att man inte kan använda "A, B, C"
//för "1, 2, 3" då "B" redan används av "Betala" alternativet.För att förhindra olika likadana nummer när varukorg etcetera visas,
//starta med olika för de olika för de olika kategorierna. Exempelvis, böcker startar från varunummer 100, spel från 200 och filmer från 300.
//
//Skriv även instruktioner för hur man handlar med detta system... Kolla antal så att inte minsta antal blir för lågt, kanske max gräns för 99 stycken?







//Ungefär som meny sidan? ....Tusen for loopar....?
//
//Lista som sparar Böcker, författare, pris.
//Kan använda samma om man gör för spel, Titel, utvecklare, pris.
//För filmer, Titel, filmföretag, pris.
//Med andra ord 3 string arrayer i en lista, där pris arrayen omvandlas till en double med Parse. (TryParse onödig eftersom inte användaren påverkar?)
//
//Skriv ut listan i ordning.
//Ordna tre rader med de tre olika.
//Använda en klass/interface för att skriva ut en lista som definieras och skrivs in här?
//
//Background color som passar böcker, kanske Foregroundcolor som passar Background color
//
//Funktionalitet: knappar som går att trycka på för att lägga i produkter i vagnen. Sänd med Bok,
//styckpris, antal av varje bok samt pris som definieras för hela köpet, men det kan kanske skötas
//av annan klass, View_Shopping_Cart.
//
//Rent teoretiskt kan man skapa tre olika sidor från samma klass, sänd bara in olika värden genom parametrar..... Dålig ide eller bra...?








//En sida som kan hjälpa till med att skapa en lista med arrayer är:
//https://stackoverflow.com/questions/549399/c-sharp-creating-an-array-of-arrays/549417