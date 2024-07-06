using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Windsong_Lyre
{
    public partial class AdvancedAppForm : Form
    {
        private string _folderName = string.Empty;
        private List<string> _songsInDirectory = new List<string>();
        private bool _stillOpen = true;
        private int _currentSong = 0;
        public string nameOfAppToSendKeysTo = string.Empty;

        // Create a BackgroundWorker instance for the music player (multithreading, basically)
        public BackgroundWorker backgroundWorker1 = new BackgroundWorker();

        private AdvancedPlaySong advancedPlaySong = new AdvancedPlaySong();
        public Process targetGameProcess = null;
        public List<Process> activeProcessList = new List<Process>();
        public IntPtr targetWindowHandle = IntPtr.Zero;

        public AdvancedAppForm()
        {
            InitializeComponent();

            //pass this object down the line (We'll use this for accessing and updating our controls)
            advancedPlaySong.advancedOpenTargetFile.callingClass = this;
            SetUpHandlers_BackgroundWorker();
            //set button visibility
            HandleButtons_Enabled(false);
            //get the names of all currently open windows and display them to the user for selection
            handleAccessCurrentOpenWindows();
        }

        private void handleAccessCurrentOpenWindows()
        {
            getAllCurrentOpenWindows();
            listAllProcessNames();
        }
        private void getAllCurrentOpenWindows()
        {
            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    //Console.WriteLine($"Process: {process.ProcessName} (ID: {process.Id}) - Window title: {process.MainWindowTitle}");
                    activeProcessList.Add(process);
                }
            }
        }
        private void listAllProcessNames()
        {
            if (activeProcessList == null)
                return;

            foreach(Process process in activeProcessList)
            {
                comboboxActiveProcesses.Items.Add(process.MainWindowTitle);
            }
        }
        private bool loadUpSelectedProcess()
        {
            nameOfAppToSendKeysTo = comboboxActiveProcesses.SelectedItem.ToString();
            targetGameProcess = getSelectedProcess();
            return (targetGameProcess!=null) ? true : false; //if it's not null, return true. Else return false (We cant execute further)
        }
        private Process getSelectedProcess()
        {
            foreach(Process process in activeProcessList)
            {
                if(process.MainWindowTitle.Equals(nameOfAppToSendKeysTo))
                {
                    return process;
                }
            }
            return null;
        }
        private void HandleButtons_Enabled(bool isEnabled)
        {
            btnNextSong.Enabled = isEnabled;
            btnPreviousSong.Enabled = isEnabled;
            btnPause.Enabled = isEnabled;
            btnPlay.Enabled = isEnabled;
            numberUpDown_SongSpeed.Enabled = isEnabled;
        }
        private void SetUpHandlers_BackgroundWorker()
        {
            //to allow us to close the worker later on
            backgroundWorker1.WorkerSupportsCancellation = true;
            //allows us to update the progressbar
            backgroundWorker1.WorkerReportsProgress = true;

            // Set up event handlers
            backgroundWorker1.DoWork += HandleBackgroundWorker_DoWork;
            backgroundWorker1.RunWorkerCompleted += HandleBackgroundWorker_WhenWorkCompleted;

            //allows us to update the progressbar in the background thread
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressbarSongStatus.Value = e.ProgressPercentage;
        }


        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();
            if(fbDialog.ShowDialog() == DialogResult.OK)
            {
                _folderName = fbDialog.SelectedPath;
                txtboxHuntingFolder.Text = _folderName;
                AdvancePlaySongUpdateFolderName(_folderName);

                Handle_SongsInDirectory();

                //load up the first song by default
                updateTextBox_CurrentSong(_songsInDirectory[_currentSong]);

                AdvancePlaySongUpdateFileName(_songsInDirectory[_currentSong]);

                HandleButtons_Enabled(true);
                updateSongoffsetSpeed();
            }
        }

        /// <summary>
        /// Tells the app which song file to actually start playing
        /// </summary>
        /// <param name="songName"></param>
        private void AdvancePlaySongUpdateFileName(string songName)
        {
            advancedPlaySong.advancedOpenTargetFile._Filename = songName;
        }
        /// <summary>
        /// Tells the app which Folder it needs to browse
        /// </summary>
        /// <param name="folderName"></param>
        private void AdvancePlaySongUpdateFolderName(string folderName)
        {
            advancedPlaySong.advancedOpenTargetFile._Directory = folderName;
        }
        private void updateSongoffsetSpeed()
        {
            int _songSpeedOffset = Convert.ToInt32(numberUpDown_SongSpeed.Value);
            advancedPlaySong.advancedOpenTargetFile._SongSpeedOffset = _songSpeedOffset;
        }

        private void Clear_SongsInDirectory()
        {
            _songsInDirectory.Clear();
            _songsInDirectory.TrimExcess();
        }

        private void Handle_SongsInDirectory()
        {
            Clear_SongsInDirectory();
            _songsInDirectory = CleanFileName(Directory.GetFiles(_folderName).ToList());
        }
        /// <summary>
        /// Updates the textbox with a specific message
        /// </summary>
        /// <param name="message"></param>
        private void updateTextBox_CurrentSong(string message)
        {
            txtboxCurrentSongName.Text = message;
        }
        /// <summary>
        /// Updates the textboxt with the currently selected song
        /// </summary>
        private void updateTextBox_CurrentSong()
        {
            updateTextBox_CurrentSong(_songsInDirectory[_currentSong]);
        }

        /// <summary>
        /// handles multiple files
        /// </summary>
        /// <param name="files"> the multiple filename strings to clean </param>
        private List<string> CleanFileName(List<string> files)
        {
            List<string> cleanedFiles = new List<string>();
            foreach (var file in files)
            {
                //take away the path part of the name and keep only the filename
                cleanedFiles.Add(CleanFileName(file));
            }
            return cleanedFiles;
        }
        /// <summary>
        /// handles a singular filename
        /// </summary>
        /// <param name="file"> the Filename string to clean</param>
        /// <returns></returns>
        private string CleanFileName(string file)
        {
            //take away the path part of the name and keep only the filename
            return Path.GetFileName(file);
        }
        private void HandleBackgroundWorker_Close()
        {
            backgroundWorker1.CancelAsync();
        }

        /// <summary>
        /// happens when the folder has been selected and we need to start sending keypresses, until a song is changed or stopped
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (_stillOpen)
            {
                try
                {
                    // Set the focus to the desired window
                    //IntPtr targetWindowHandle = FindWindow(null, nameOfAppToSendKeysTo);
                    //SetForegroundWindow(targetWindowHandle);

                    //pass this object down the line (We'll use this for accessing and updating our controls later on)
                    advancedPlaySong.advancedOpenTargetFile.callingClass = this;
                    //play the currently selected song
                    advancedPlaySong.Play();
                    handleWhenSongHasFinishedButNoPauseYet();
                }
                catch
                {
                    HandleBackgroundWorker_Close();
                }

                // Check for cancellation
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true; // Indicate cancellation of the worker thread
                    break;
                }
            }
        }

        private void handleWhenSongHasFinishedButNoPauseYet()
        {
            if(advancedPlaySong.advancedOpenTargetFile._SongHasFinished)
            {
                //thread safety
                if (InvokeRequired)
                {
                    // Invoke the UI update on the main thread
                    Invoke(new Action(() => HandleNextSong()));
                }
                else
                {
                    // Directly update the UI (if already on the main thread)
                    HandleNextSong();//just play the next song
                }
            }
        }

        /// <summary>
        /// happens when the event finishes, or the user hits cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleBackgroundWorker_WhenWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void btnPreviousSong_Click(object sender, EventArgs e)
        {
            HandlePreviousSong();
        }
        private void HandlePreviousSong()
        {
            numberUpDown_SongSpeed.Value = 1;

            if (_currentSong > 0)
            {
                _currentSong--;
            }
            else //wrap it back to the last one in the list
            {
                _currentSong = _songsInDirectory.Count - 1;
            }
            updateTextBox_CurrentSong();
            resetProgressBarToEmpty();
            AdvancePlaySongUpdateFileName(_songsInDirectory[_currentSong]);
        }

        private void btnNextSong_Click(object sender, EventArgs e)
        {
            HandleNextSong();
        }
        private void HandleNextSong()
        {
            //reset the value of the speed to 1x Speed (default value)
            numberUpDown_SongSpeed.Value = 1;

            if (_currentSong < _songsInDirectory.Count - 1)
            {
                _currentSong++;
            }
            else //wrap it back to the first one in the list
            {
                _currentSong = 0;
            }
            updateTextBox_CurrentSong();
            resetProgressBarToEmpty();
            AdvancePlaySongUpdateFileName(_songsInDirectory[_currentSong]);
        }

        private void resetProgressBarToEmpty()
        {

            //thread safety
            if (InvokeRequired)
            {
                // Invoke the UI update on the main thread
                Invoke(new Action(() => backgroundWorker1.ReportProgress(0)));
            }
            else
            {
                // Directly update the UI (if already on the main thread)
                progressbarSongStatus.Value = 0;
            }
        }



        private void btnPlay_Click(object sender, EventArgs e)
        {
            _stillOpen = true;
            if (!loadUpSelectedProcess())
                return;

            // Start the background worker, only if it's not already running
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
                handleBtnPlayVisibility(false);
                handleProcessListVisibility(false);
            }
        }
        private void handleBtnPlayVisibility(bool isEnabled)
        {
            btnPlay.Enabled = isEnabled;
        }
        private void handleProcessListVisibility(bool isEnabled)
        {
            comboboxActiveProcesses.Enabled = isEnabled;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            HandleBackgroundWorker_Close();
            _stillOpen = false;
            advancedPlaySong.advancedOpenTargetFile._SongHasBeenPaused = true;
            handleBtnPlayVisibility(true);
        }

        private void formClosingEvent(object sender, FormClosingEventArgs e)
        {
            HandleBackgroundWorker_Close();
            backgroundWorker1.Dispose();
            _stillOpen = false;
            //terminate the current process (Further means of freeing up the resources, in case the others didnt work)
            Environment.Exit(0);
        }

        private void numberUpDown_SongSpeed_ValueChanged(object sender, EventArgs e)
        {
            updateSongoffsetSpeed();
        }
    }
}