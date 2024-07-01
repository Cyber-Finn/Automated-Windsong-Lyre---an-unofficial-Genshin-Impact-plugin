using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windsong_Lyre.Properties;

namespace Windsong_Lyre
{
    public partial class Form1 : Form
    {
        #region other songs I want to try:

        // Raiden Theme | use this one: https://www.youtube.com/watch?v=mIFVpa3saOs  || https://www.youtube.com/watch?v=6TaxgzMOUKs
        // Pirates Theme | use this one: https://www.youtube.com/watch?v=HMji3Nls9Z8
        // pretty cool Marceline song: https://www.youtube.com/watch?v=3GP0TDxpITs

        // violet evergarden : https://www.youtube.com/watch?v=CUYX13MyiQs
        // Might do this one first: spirited away: https://www.youtube.com/watch?v=T1fnaiSSqN4
        // Omori final duet: https://www.youtube.com/watch?v=GfDncFXV1IE
        // bethoven virus: https://www.youtube.com/watch?v=5SNKlQTwDaQ
        // your name theme: https://www.youtube.com/watch?v=Ye6piib3keQ
        // glimpse of us - Joji: https://www.youtube.com/watch?v=CLM40KGlNRE
        // tokyo ghoul theme: https://www.youtube.com/watch?v=q9elNtHjZDk
        // spy x family theme: https://www.youtube.com/watch?v=DTxi8KD4ZsA
        // HARD AF: Honkai impact theme - True: https://www.youtube.com/watch?v=SbhcmkFwYoA
        // justin bieber - stay: https://www.youtube.com/watch?v=O65pKV-poSU

        #endregion 

        PlaySong playOurSong = new PlaySong();
        /*
             If you’re playing on PC, you can use either the keyboard or the mouse. On the keyboard, the top row of notes (treble clef, 𝄞) 
             are mapped to the letters Q to U, the middle row (alto clef, 𝄡) from A to J, and the bottom row (bass clef, 𝄢) from Z to M.
             * q w e r t y u
             * a s d f g h j 
             * z x c v b n m
         */

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelStatus.ResetText();
            labelStatus.Text = "Status: Running";
            DateTime start = DateTime.Now;

            string songToPlay = "";


            if (radio200BpmMonster.Checked)
            {
                songToPlay = Resources.StarsetMonster200bpmFileName;
            }

            if (radioVanaranaTheme.Checked)
            {
                songToPlay = Resources.VanaranaThemeFileName;
            }

            if (radioRaidenTheme.Checked)
            {
                songToPlay = Resources.RaidenShogunThemeFileName;
            }


            if (radioTossACoin.Checked)
            {
                songToPlay = Resources.TossACoinToYourWitcherFileName;
            }

            if (radioSomeoneYouLoved.Checked)
            {
                songToPlay = Resources.SomeoneYouLovedFileName;
            }

            if (radioHowlsCastle.Checked)
            {
                // Might do this instead: https://www.youtube.com/watch?v=C9dqhFsKNz0
                songToPlay = Resources.HowlsMovingCastleFileName;
            }

            if (radioHonkaiTrue.Checked)
            {
                songToPlay = Resources.HonkaiTrueThemeFileName;
            }

            if (radioSpiritAway.Checked)
            {
                songToPlay = Resources.SpiritedAwayTheme;
            }


            playOurSong.Play(Resources.Directory, songToPlay);

            DateTime ended = DateTime.Now;

            labelStatus.Text = "Status: Done";
            labelTimeTaken.Text = "Time Taken: " +(ended-start).ToString();
        }
    }
}
