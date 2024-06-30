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
                    string[] filecontents = File.ReadAllLines(fullPath);

                    for (int i = 0; i < filecontents.Length; i++)
                    {
                        int duration = 0;

                        string keysToPress = "";

                        if ((filecontents[i] != "") && (filecontents[i] != " ") && (filecontents[i] != null))
                        {
                            keysToPress = filecontents[i];
                        }
                        
                        //moving it down one line - so we can get the number/duration
                        i++;
                        
                        if (i < filecontents.Length)
                        {
                            if ((filecontents[i] != "") && (filecontents[i] != " ") && (filecontents[i] != null))
                            {
                                int indexOfEnd = filecontents[i].Length;
                                duration = int.Parse(filecontents[i].Substring(0, indexOfEnd)); 
                            }
                        }
                        else
                        {
                            return;
                        }

                        keysToPress.Trim();

                        foreach (char character in keysToPress)
                        {
                            if (character != ' ')
                            {
                                //comment this out when debugging - or else we make changes while debugging
                                SendKeys.Send("{" + character + "}");    
                            }
                        }
                        Thread.Sleep(duration);

                        //todo: want to stop if we press escape
                    }
                }
            }
        }
    }
}
