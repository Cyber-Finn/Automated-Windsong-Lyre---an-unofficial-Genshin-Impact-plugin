using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Threading;

namespace Windsong_Lyre
{
    public class OpenTargetFile
    {
        public void openTargetFile(string directory, string filename)
        {
            string fullPath = directory + "\\" + filename;

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (Directory.Exists(directory))
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
            List<string> filecontents = cleanFile_RemoveEmptyLines(File.ReadAllLines(fullPath));

            for (int i = 0; i < filecontents.Count; i++)
            {
                if ((filecontents[i] != "") && (filecontents[i] != " ") && (filecontents[i] != null))
                {
                    try //convert the element to an int
                    {
                        int indexOfEnd = filecontents[i].Length;
                        int duration = int.Parse(filecontents[i].Substring(0, indexOfEnd));

                        Thread.Sleep(duration);
                    }
                    catch //convert the element to a string
                    {
                        string keysToPress = filecontents[i].Trim();

                        if (keysToPress != "")
                        {
                            foreach (char character in keysToPress)
                            {
                                if (character != ' ')
                                {
                                    //comment this out when debugging - or else we make changes while debugging
                                    SendKeys.Send("{" + character + "}");
                                }
                            }
                        }
                    }
                }
                //todo: want to stop if we press escape
            }
        }
    }
}
