# Notes:
This tool will allow you to play any songs on Genshin Impact's Windsong lyre and other instruments, as well as music in any game that allows keyboard input for musical instruments.
<br>
When in use, the tool will press combinations of buttons on your keyboard for you - to generate musical notes in-game and to allow you to automatically play the song that you've selected.
<br>
Please don't exit the game until the song has stopped, as the tool will continue to press keys until the song stops, or you close the tool window. This can become pretty messy if you've got something important open

## How to use the app:
1. Simply open the application (Do this while "Genshin Impact" is running **and** the "Windsong Lyre" or another musical instrument is in use by your character).
2. Click the "Advanced" option on the first window, and "Open a folder" on the second window, once that opens.
3. Once you've selected a folder, the app will choose and display the first song. You can use the Next and Previous buttons to select a specific song from the folder.
4. Simply click the "Play" button, then switch back to the Genshin Impact game window. You will have 5 seconds before the tool starts pressing keys for you.
<br>

## Languages used and Requirements: 
- C# only. 
- Requires .Net 4.8 or higher to run

## Target System: 
- PC only - this tool doesn't work on consoles or mobile devices of any kind.

## Additional notes: 
You can configure the tool to play virtually any song, by following these steps:  
1. Create a song file for the app to read (more on this below!)
2. Place the file into a memorable folder on your pc
3. Select that folder in the App - as mentioned in the usage instructions, and click Play.


## Adding new songs:
1. Create a text file that contains both the **Keys-to-press**, and the **Duration** of the press (how long it needs to wait before playing the next note).
    - Do not place numbers and characters on the same line.
    - You can find Sample Files included in this project under the "Notes Backup" folder -> [here](https://github.com/Cyber-Finn/Automated-Windsong-Lyre---an-unofficial-Genshin-Impact-plugin/tree/main/Notes%20backup).
    - The general order should be: **Keys-to-press**, first, then the **Duration**, second.


## Understanding the general note-to-key mappings for Genshin Impact:
1. The top row of notes (treble clef, 𝄞) are mapped to the letters Q to U,
2. The middle row (alto clef, 𝄡) is mapped from A to J,
3. And the bottom row (bass clef, 𝄢) from Z to M.
<br>
Example:
<br>
q w e r t y u  (treble clef, 𝄞)
<br>
a s d f g h j  (alto clef, 𝄡)
<br>
z x c v b n m  (bass clef, 𝄢)
<br>
These are all the possible notes you can play on the Windsong Lyre.
