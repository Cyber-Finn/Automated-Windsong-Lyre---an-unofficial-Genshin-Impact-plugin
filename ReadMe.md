Notes:
      This tool will allow you to play any songs on Genshin Impact's Windsong lyre.
      The use of this tool is as follows:
                                        1) Simply open the application (Do this while "Genshin Impact" is running and the "Windsong Lyre" is in use)
                                        2) Once you've selected a song to play, simply click the run button, then switch back to the game window.
      When in use, the tool will press combinations of buttons on your keyboard for you - to generate notes in-game and to allow you to automatically play the song that you've selected.

Languages used: 
                C# only.

Target System: 
               PC only - this doesn't work on consoles of any kind.

Additional notes: 
                You can configure the tool to play virtually any song. You simply need to create a file for the app to read (Which can be placed into your C: drive).
                Configuring the files in the right format can be a bit tricky, so that deserves it's own section of this ReadMe (found below).


Configuring the note-files:
                1) Create a text file that contains both the key-to-press, and the duration of the note (You can look at some of the Sample files included in this project to get an idea of what to do, but the structure should be "key to press", then on a new line, "duration of note", etc.) 
                        For those playing on PC, who need help understanding the general note-mappings:
                         On the keyboard:
                           The top row of notes (treble clef, 𝄞) are mapped to the letters Q to U, 
                           The middle row (alto clef, 𝄡) is mapped from A to J, 
                           And the bottom row (bass clef, 𝄢) from Z to M.
                             * q w e r t y u  (treble clef, 𝄞)
                             * a s d f g h j  (alto clef, 𝄡)
                             * z x c v b n m  (bass clef, 𝄢)
                          These are all the possible notes you can play on the Windsong Lyre.
                2) Once the note-file has been created, you need to add the "location of the file" to the Resources.resx file - which can usually be found in "Debug" (or "Release") sub-folder named "Properties".
                    You can also add your own default directory (Where you'll store all the other note files). Simply replace the value of the "Directory" resource in the Resources.resx
                3) Once the resource has been added, you need to create a new radio-button for the specific song on "Form1" (Likely through Visual Studio)
                4) Once the radio button has been created, you need to find "button1_Click" in Form1's code-behind, and add a new condition to cater for the option selected. 
                    Simply set the "songToPlay" object to our newly added resource, and the rest of the code will cater for the new radio-button when the option is selected.