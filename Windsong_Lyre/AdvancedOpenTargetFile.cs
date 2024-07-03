using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
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

        public bool _SongHasFinished = false; //might not use this
        public AdvancedAppForm callingClass = null;

        /// <summary>
        /// This helps us prevent a scenario where the app has requested closure, but the thread is stuck in the for-loop until the song is finished
        /// </summary>
        public bool _SongHasBeenPaused = false;
        /// <summary>
        /// Holds all the contents of the current song file, works in conjunction with the _CurrentSongStartIndex
        /// </summary>
        public List<string> _CurrentSongFileContents = new List<string>();

        public string _Directory = string.Empty;
        public string _Filename = string.Empty;

        public double GetPercentageOfSongPlayed()
        {
            double answer = ((_CurrentSongStartIndex * 100.0) / _CurrentSongNumberOfLines);
            return answer;
        }


        public void openTargetFile()
        {
            //Reset the progress bar on the app's main form
            callingClass.backgroundWorker1.ReportProgress(0);

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

                        //update the progress bar on the app's main form
                        callingClass.backgroundWorker1.ReportProgress(Convert.ToInt32(GetPercentageOfSongPlayed()));
                        //callingClass.progressbarSongStatus.Value = Convert.ToInt32(GetPercentageOfSongPlayed());

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
