//Kundvagnen ska visa alla produkter man lagt i den, styckpriset,
//antalet och totalpriset samt totala kostnaden för hela kundvagnen.
//Kundvagnen skall sparas i kund och finnas tillgänglig när man loggar in.
//
//Notering: totalpriset måste betyda totalpriset för alla varor av den angivna typen.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Ny_version {
    class View_Shopping_Cart {
    }
}

/*

    Hur fungerar en varukorg?

    När varor läggs till:

    1. Först tar varukorg emot ett varunummer.
    2a If varunummer inte existerar i lista/dictionary: Lägg till i lista/dictionary. Öka variabel för antal med ett.
    2b If varunummer existerar i lista/dictionary: Öka variabel för antal med ett
    
    När varor tas bort:

    1. Ta emot nummer på vara som skall tas bort.
    2a If vara inte i lista/dictionary: Gör ingenting.
    2b If vara i lista/dictionary: Sänk variabel med antal med ett.
    3a If Variabel med antal == större än 0: Låt vara.
    3b If Variabel för antal == 0 eller mindre: Ta bort vara ur lista/dictionary.

    När användaren klickar för att visa varor i varukorgen:

    1. En lista på varorna visas. Det som skall visas är Titel, antal varor av varje typ, 
       styckpris, totalpris för alla varor av en typ samt totalpris för alla varorna.
    2. Uträkningar för totalpris per vara samt styckpris skall synas per produkt, samma rad.
    3. Totalpris längst ned till höger.

*/