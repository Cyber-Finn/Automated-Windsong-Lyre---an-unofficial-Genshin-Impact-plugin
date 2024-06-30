using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Windsong_Lyre
{
    class Toss_A_Coin
    {
        public void Play()
        {
            // 5 SECONDS
            Thread.Sleep(5000);

            // PREVERSE
            SendKeys.Send("{Q}");
            SendKeys.Send("{H}"); 
            Thread.Sleep(200);

            SendKeys.Send("{E}");
            Thread.Sleep(200);
            SendKeys.Send("{Y}");
            Thread.Sleep(200);
            //should be perfect up to here

            SendKeys.Send("{Q}");
            Thread.Sleep(300);
            SendKeys.Send("{J}");
            Thread.Sleep(300);
            SendKeys.Send("{H}"); // LA
            Thread.Sleep(300);
            SendKeys.Send("{G}");
            Thread.Sleep(300);

            SendKeys.Send("{H}"); // LA
            Thread.Sleep(200);
            SendKeys.Send("{W}");
            Thread.Sleep(200);
            SendKeys.Send("{T}");
            Thread.Sleep(200);
            SendKeys.Send("{Y}");

            Thread.Sleep(500);

            // START OF THE SONG:
            SendKeys.Send("{W}"); //RE
            Thread.Sleep(350);
            SendKeys.Send("{E}");
            Thread.Sleep(350);
            SendKeys.Send("{Q}");
            Thread.Sleep(350);
            SendKeys.Send("{J}");
            Thread.Sleep(200);
            SendKeys.Send("{H}");
            Thread.Sleep(200);
            SendKeys.Send("{W}");
            Thread.Sleep(200);
            SendKeys.Send("{R}");

            Thread.Sleep(500);

            //6sec in
            //START OF V1 MELODY
            SendKeys.Send("{H}");
            Thread.Sleep(400);
            SendKeys.Send("{W}");
            Thread.Sleep(400);
            SendKeys.Send("{W}");
            Thread.Sleep(400);
            SendKeys.Send("{E}");

            Thread.Sleep(200);
            SendKeys.Send("{Q}");
            Thread.Sleep(200);
            SendKeys.Send("{G}");
            Thread.Sleep(200);
            SendKeys.Send("{J}");
            Thread.Sleep(200);
            SendKeys.Send("{E}");
            Thread.Sleep(200);
            SendKeys.Send("{H}");
            //10sec in - perfect up to here
            Thread.Sleep(500);
            SendKeys.Send("{H}");
            Thread.Sleep(500);
            SendKeys.Send("{W}");

            Thread.Sleep(500);
            SendKeys.Send("{Q}");
            Thread.Sleep(500);
            SendKeys.Send("{W}");
            // @ 11 SEC IN
            Thread.Sleep(200);
            SendKeys.Send("{E}");
            SendKeys.Send("{H}");
            Thread.Sleep(200);
            SendKeys.Send("{Y}");
            //should be perfect up to here

            Thread.Sleep(500);
            // THE ACTUAL VERSE STARTS
            SendKeys.Send("{W}");
            Thread.Sleep(400);
            SendKeys.Send("{E}");

            Thread.Sleep(200);
            SendKeys.Send("{G}"); 
            Thread.Sleep(200);
            SendKeys.Send("{J}");
            Thread.Sleep(200);
            SendKeys.Send("{E}");
            Thread.Sleep(200);
            SendKeys.Send("{T}");

            Thread.Sleep(200);
            SendKeys.Send("{H}");
            Thread.Sleep(200);
            SendKeys.Send("{J}");
            Thread.Sleep(200);
            SendKeys.Send("{E}");
            Thread.Sleep(200);
            SendKeys.Send("{Y}");
            //should be perfect up to here now
            // "when a humble bard" starts here:
            Thread.Sleep(700);
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");

            Thread.Sleep(250);
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{N}");
            SendKeys.Send("{Q}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            Thread.Sleep(250);
            SendKeys.Send("{J}");

            Thread.Sleep(250);
            SendKeys.Send("{N}");
            SendKeys.Send("{H}");
            
            //19 SECONDS IN
            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{G}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");


            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{G}");
            SendKeys.Send("{V}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{V}");

            // 21 SECONDS IN
            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");
            SendKeys.Send("{V}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{E}");
            SendKeys.Send("{V}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{W}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");
            Thread.Sleep(250);
            SendKeys.Send("{W}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{E}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            Thread.Sleep(250);
            SendKeys.Send("{B}");
            Thread.Sleep(250);
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");
            Thread.Sleep(250);
            SendKeys.Send("{D}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");

            Thread.Sleep(250);
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");

            Thread.Sleep(250);
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{J}");

            Thread.Sleep(250);
            SendKeys.Send("{N}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{G}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            Thread.Sleep(250);
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");
            SendKeys.Send("{Q}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{J}");

            Thread.Sleep(250);
            SendKeys.Send("{V}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");


            Thread.Sleep(250);
            SendKeys.Send("{V}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{V}");
            SendKeys.Send("{W}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{V}");
            SendKeys.Send("{E}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{T}");
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{W}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            SendKeys.Send("{E}");

            Thread.Sleep(250);
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");

            Thread.Sleep(250);
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{J}");

            Thread.Sleep(250);
            SendKeys.Send("{H}");
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{G}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{H}");
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{J}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{V}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");

            Thread.Sleep(250);
            SendKeys.Send("{V}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{V}");
            SendKeys.Send("{W}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{V}");
            SendKeys.Send("{E}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");
            SendKeys.Send("{W}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{Q}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");
            SendKeys.Send("{W}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{W}");

            Thread.Sleep(250);
            SendKeys.Send("{E}");
            SendKeys.Send("{G}");
            SendKeys.Send("{M}");

            Thread.Sleep(250);
            SendKeys.Send("{M}");
            SendKeys.Send("{G}");

            Thread.Sleep(250);
            SendKeys.Send("{M}");
            SendKeys.Send("{G}");

            Thread.Sleep(250);
            SendKeys.Send("{M}");
            SendKeys.Send("{G}");

            Thread.Sleep(250);
            SendKeys.Send("{M}");
            SendKeys.Send("{G}");

            Thread.Sleep(250);
            SendKeys.Send("{M}");
            SendKeys.Send("{G}");

            Thread.Sleep(250);
            SendKeys.Send("{M}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{M}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{M}");

            Thread.Sleep(250);
            SendKeys.Send("{A}");
            Thread.Sleep(250);
            SendKeys.Send("{D}");
            Thread.Sleep(250);
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");

            Thread.Sleep(250);
            SendKeys.Send("{E}");
            SendKeys.Send("{A}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");


            Thread.Sleep(250);
            SendKeys.Send("{A}");
            SendKeys.Send("{W}");
            SendKeys.Send("{D}");
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{E}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{E}");
            SendKeys.Send("{G}");
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");


            Thread.Sleep(250);
            SendKeys.Send("{Q}");

            Thread.Sleep(250);
            SendKeys.Send("{J}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");

            Thread.Sleep(250);
            SendKeys.Send("{A}");
            SendKeys.Send("{D}");
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{E}");
            SendKeys.Send("{G}");
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");

            Thread.Sleep(250);
            SendKeys.Send("{J}");


            Thread.Sleep(250);
            SendKeys.Send("{Q}");


            Thread.Sleep(250);
            SendKeys.Send("{A}");
            SendKeys.Send("{D}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{G}");

            Thread.Sleep(250);
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");

            Thread.Sleep(250);
            SendKeys.Send("{A}");
            Thread.Sleep(250);
            SendKeys.Send("{D}");
            Thread.Sleep(250);
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");

            Thread.Sleep(250);
            SendKeys.Send("{A}");
            SendKeys.Send("{E}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            Thread.Sleep(250);
            SendKeys.Send("{J}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");

            // 1MIN 4SECONDS IN
            Thread.Sleep(250);
            SendKeys.Send("{A}");
            SendKeys.Send("{W}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");

            Thread.Sleep(250);
            SendKeys.Send("{E}");


            Thread.Sleep(250);
            SendKeys.Send("{E}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{G}");

            Thread.Sleep(250);
            SendKeys.Send("{T}");

            Thread.Sleep(250);
            SendKeys.Send("{E}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");

            Thread.Sleep(250);
            SendKeys.Send("{E}");

            Thread.Sleep(250);
            SendKeys.Send("{C}");


            Thread.Sleep(250);
            SendKeys.Send("{E}");
            SendKeys.Send("{M}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");

            Thread.Sleep(250);
            SendKeys.Send("{M}");

            Thread.Sleep(250);
            SendKeys.Send("{C}");

            Thread.Sleep(250);
            SendKeys.Send("{M}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");

            Thread.Sleep(250);
            SendKeys.Send("{M}");

            Thread.Sleep(250);
            SendKeys.Send("{C}");
            SendKeys.Send("{Y}");

            Thread.Sleep(250);
            SendKeys.Send("{M}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");

            Thread.Sleep(250);
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{J}");

            //NOT SURE WHAT HAPPENS BEFORE THIS: 1MIN 13SEC
            Thread.Sleep(250);
            SendKeys.Send("{Y}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            Thread.Sleep(250);
            SendKeys.Send("{D}");
            Thread.Sleep(250);
            SendKeys.Send("{S}");
            Thread.Sleep(250);
            SendKeys.Send("{A}");
            Thread.Sleep(250);
            SendKeys.Send("{M}");
            Thread.Sleep(250);
            SendKeys.Send("{N}");
            Thread.Sleep(250);
            SendKeys.Send("{D}"); //

            Thread.Sleep(250);
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");

            Thread.Sleep(250);
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{J}");
            SendKeys.Send("{D}");

            Thread.Sleep(250);
            SendKeys.Send("{H}");
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            SendKeys.Send("{G}");

            Thread.Sleep(250);
            SendKeys.Send("{H}");
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{M}");

            Thread.Sleep(250);
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{J}");

            Thread.Sleep(250);
            SendKeys.Send("{H}");
            SendKeys.Send("{V}");

            Thread.Sleep(250);
            SendKeys.Send("{A}");

            Thread.Sleep(250);
            SendKeys.Send("{V}");

            Thread.Sleep(250);
            SendKeys.Send("{H}");
            SendKeys.Send("{A}");

            Thread.Sleep(250);
            SendKeys.Send("{V}");
            SendKeys.Send("{W}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");
            SendKeys.Send("{A}");

            Thread.Sleep(250);
            SendKeys.Send("{V}");
            SendKeys.Send("{E}");

            Thread.Sleep(250);
            SendKeys.Send("{A}");
            SendKeys.Send("{Q}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{H}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{H}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{E}");
            SendKeys.Send("{D}");
            SendKeys.Send("{M}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            SendKeys.Send("{M}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            SendKeys.Send("{M}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            SendKeys.Send("{M}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            SendKeys.Send("{M}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            SendKeys.Send("{M}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            SendKeys.Send("{M}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            SendKeys.Send("{M}");


            Thread.Sleep(250);
            SendKeys.Send("{A}");
            SendKeys.Send("{E}");
            SendKeys.Send("{T}");
            SendKeys.Send("{G}");
            SendKeys.Send("{J}");

            Thread.Sleep(250);
            SendKeys.Send("{A}");
            SendKeys.Send("{G}");

            Thread.Sleep(250);
            SendKeys.Send("{A}");
            SendKeys.Send("{G}");

            Thread.Sleep(250);
            SendKeys.Send("{A}");
            SendKeys.Send("{G}");

            // AT 1:26
            Thread.Sleep(250);
            SendKeys.Send("{D}");
            SendKeys.Send("{E}");
            SendKeys.Send("{Y}");
            SendKeys.Send("{H}");
            SendKeys.Send("{J}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");

            Thread.Sleep(250);
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{D}");
            SendKeys.Send("{J}");

            Thread.Sleep(250);
            SendKeys.Send("{H}");
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{G}");
            SendKeys.Send("{D}");

            Thread.Sleep(250);
            SendKeys.Send("{H}");
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{N}");

            Thread.Sleep(250);
            SendKeys.Send("{J}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{H}");
            SendKeys.Send("{V}");

            Thread.Sleep(250);
            SendKeys.Send("{A}");

            Thread.Sleep(250);
            SendKeys.Send("{V}");

            Thread.Sleep(250);
            SendKeys.Send("{A}");
            SendKeys.Send("{H}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");
            SendKeys.Send("{V}");

            Thread.Sleep(250);
            SendKeys.Send("{W}");
            SendKeys.Send("{A}");

            Thread.Sleep(250);
            SendKeys.Send("{E}");
            SendKeys.Send("{V}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{A}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{H}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");
            SendKeys.Send("{W}");

            Thread.Sleep(250);
            SendKeys.Send("{Q}");
            SendKeys.Send("{S}");

            Thread.Sleep(250);
            SendKeys.Send("{B}");
            SendKeys.Send("{W}");

            Thread.Sleep(250);
            SendKeys.Send("{S}");
            SendKeys.Send("{W}");

            Thread.Sleep(250);
            SendKeys.Send("{E}");
            SendKeys.Send("{M}"); // leaving from here off - it's a bit long lol

       }
    }
}
