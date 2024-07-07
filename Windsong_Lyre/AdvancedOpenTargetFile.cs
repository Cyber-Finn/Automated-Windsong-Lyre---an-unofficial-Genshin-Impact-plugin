using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windsong_Lyre
{
    internal class AdvancedOpenTargetFile
    {
        //using these 2 not only for where to start once paused, but for updating the progress bar on the main form
        public int _CurrentSongStartIndex = 0;
        public int _CurrentSongNumberOfLines = 0;

        public int _SongSpeedOffset = 1;
        public bool _SongHasFinished = false;
        public AdvancedAppForm callingClass = null;
        /// <summary>
        /// This helps us prevent a scenario where the app has requested closure, but the thread is stuck in the for-loop until the song is finished
        /// </summary>
        public bool _SongHasBeenPaused = false;
        /// <summary>
        /// Holds all the contents of the current song file, works in conjunction with the _CurrentSongStartIndex and being able to Pause/Play the song
        /// </summary>
        public List<string> _CurrentSongFileContents = new List<string>();
        public string _Directory = string.Empty;
        public string _Filename = string.Empty;
        #region Ensure that only Genshin receives the keypresses
        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        #endregion Ensure that only Genshin receives the keypresses
        public double GetPercentageOfSongPlayed()
        {
            double answer = ((_CurrentSongStartIndex * 100.0) / _CurrentSongNumberOfLines);
            return answer;
        }
        public void openTargetFile()
        {
            //before we do anything, check that the target window is accessible (i.e, The game is still open)
            if (!checkTargetWindowIsAccessible())
                return;

            string fullPath = _Directory + "\\" + _Filename;

            if (Directory.Exists(_Directory))
            {
                if (File.Exists(fullPath))
                {
                    playSong(fullPath);
                }
            }
        }
        private List<string> cleanFile_RemoveEmptyLines(string[] filecontents)
        {
            int lengthOfArray = filecontents.Length;
            List<string> cleanedFileContents = new List<string>();

            for (int i = 0; i < lengthOfArray; i++)
            {
                string line = filecontents[i];
                if (line.Length > 0 && !((line == "\n") || (line == "\r\n") || (line == null)))
                    cleanedFileContents.Add(line);
            }
            return cleanedFileContents;
        }
        private void updateformProgressBar()
        {
            //update the progress bar on the app's main form
            callingClass.backgroundWorker1.ReportProgress(Convert.ToInt32(GetPercentageOfSongPlayed()));
        }
        private bool getTargetAppWindow()
        {
            //ensure that only the specified window gets the keypresses
            //IntPtr targetWindowHandle = FindWindow(null, callingClass.nameOfAppToSendKeysTo);
            int i = SetForegroundWindow(callingClass.targetGameProcess.MainWindowHandle);
            return (i > 0); //if it's empty and we couldnt get the target window, return false. if it passed, return true
        }
        private bool checkTargetWindowIsAccessible()
        {
            if (!getTargetAppWindow())
            {
                MessageBox.Show("Couldn't get focus on the target window");
                _SongHasBeenPaused = true;
                return false; //we couldn't get focus on the window, need to return - since we dont have an app to send keys to anymore.
            }
            return true;
        }
        private void playSong(string fullPath)
        {
            _CurrentSongFileContents = cleanFile_RemoveEmptyLines(File.ReadAllLines(fullPath));

            _CurrentSongNumberOfLines = _CurrentSongFileContents.Count;

            for (int i = _CurrentSongStartIndex; i < _CurrentSongFileContents.Count; i++)
            {
                if(!_SongHasBeenPaused)
                {
                    if ((_CurrentSongFileContents[i] != "") && (_CurrentSongFileContents[i] != " ") && (_CurrentSongFileContents[i] != null))
                    {
                        _CurrentSongStartIndex = i;

                        if (!checkTargetWindowIsAccessible())
                            return;

                        updateformProgressBar();

                        try //convert the element to an int
                        {
                            int indexOfEnd = _CurrentSongFileContents[i].Length;
                            int duration = int.Parse(_CurrentSongFileContents[i].Substring(0, indexOfEnd));

                            Thread.Sleep(((int)duration / _SongSpeedOffset));
                        }
                        catch //convert the element to a string
                        {
                            string keysToPress = _CurrentSongFileContents[i].Trim();

                            if (keysToPress != "")
                            {
                                foreach (char character in keysToPress)
                                {
                                    if (character != ' ')
                                    {
                                        //comment this out when debugging -> or else we make changes while debugging
                                        SendKeys.SendWait("{" + character + "}");
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            _SongHasFinished = true;
        }
    }
}
