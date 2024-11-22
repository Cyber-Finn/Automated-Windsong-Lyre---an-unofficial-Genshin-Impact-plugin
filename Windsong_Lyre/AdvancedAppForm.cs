using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Windsong_Lyre
{
    public partial class AdvancedAppForm : Form
    {
        //using this not only for where to start once a song is paused and played again, but also for updating the progress bar on the main form
        public int _CurrentSongStartIndex = 0;


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
        
        //we'll be using this to ensure the backgroundworker process is closed
        private ManualResetEvent _resetEvent = new ManualResetEvent(false);

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
            clearAllProcessNames();
            if(this.comboboxActiveProcesses.Items.Count==0)
            {
                getAllCurrentOpenWindows();
                listAllProcessNames();
            }
            else
            {
                MessageBox.Show("error updating view of processes");
            }
        }

        private void clearAllProcessNames()
        {
            this.comboboxActiveProcesses.Items.Clear();
            this.comboboxActiveProcesses.SelectedIndex = -1;
            this.comboboxActiveProcesses.SelectedItem = null;
            this.activeProcessList.Clear();
            this.activeProcessList.TrimExcess();
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
                AdvancedPlaySong_UpdateFolderName(_folderName);

                Handle_SongsInDirectory();

                //load up the first song by default
                updateTextBox_CurrentSong(_songsInDirectory[_currentSong]);

                AdvancedPlaySong_UpdateFileName(_songsInDirectory[_currentSong]);

                HandleButtons_Enabled(true);
                updateSongoffsetSpeed();
            }
        }
        /// <summary>
        /// Tells the app which song file to actually start playing
        /// </summary>
        /// <param name="songName"></param>
        private void AdvancedPlaySong_UpdateFileName(string songName)
        {
            advancedPlaySong.advancedOpenTargetFile._Filename = songName;
        }
        /// <summary>
        /// Tells the app which Folder it needs to browse
        /// </summary>
        /// <param name="folderName"></param>
        private void AdvancedPlaySong_UpdateFolderName(string folderName)
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
            _songsInDirectory = CleanFileName(Directory.GetFiles(_folderName,"*.txt").ToList());
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
                    //pass the current class object down the line (We'll use this for accessing and updating our controls later on)
                    advancedPlaySong.advancedOpenTargetFile.callingClass = this;
                    //play the currently selected song
                    advancedPlaySong.Play();
                    handleWhenSongHasFinishedButNoPauseYet();
                }
                catch //if there are any problems, we need to request that the thread close
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

            //just an extra edge-case to ensure that we're closing the background thread (if something happens, or user closes) no matter what
            if (backgroundWorker1.CancellationPending)
            {
                e.Cancel = true; // Indicate cancellation of the worker thread
            }
            else
            {
                HandleBackgroundWorker_Close();
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
            //dont want to do anything here until the user closes the app,
            //we want to be able to play the next song once the current one is done.
            //closing this worker will prevent that, so we'll be resetting it
            _resetEvent.Set(); //signal completion
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
            AdvancedPlaySong_UpdateFileName(_songsInDirectory[_currentSong]);
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
            AdvancedPlaySong_UpdateFileName(_songsInDirectory[_currentSong]);
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
            handleSongHasBeenPaused(false);

            if (!loadUpSelectedProcess())
                return;

            //start or restart the worker to execute our logic (basically calls HandleBackgroundWorker_DoWork)
            StartOrReuseWorker();
            handlePlayButtonClickVisibilitySettings(false);
        }
        private void StartOrReuseWorker()
        {
            if (backgroundWorker1.IsBusy)
            {
                //cancel previous work
                HandleBackgroundWorker_Close();
                //wait for completion
                _resetEvent.WaitOne();
            }
            if(!backgroundWorker1.IsBusy) //could've done an ELSE to catch any other status, but want to really clamp this down to only execute if the state is NOT BUSY
            {
                //start the new work
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void handlePlayButtonClickVisibilitySettings(bool isVisible)
        {
            handleBtnPlayVisibility(isVisible);
            handleProcessListVisibility(isVisible);
        }

        private void handleBtnPlayVisibility(bool isEnabled)
        {
            btnPlay.Enabled = isEnabled;
        }
        private void handleProcessListVisibility(bool isEnabled)
        {
            comboboxActiveProcesses.Enabled = isEnabled;
        }
        private void handleSongHasBeenPaused(bool isPaused)
        {
            advancedPlaySong.advancedOpenTargetFile._SongHasBeenPaused = isPaused;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            HandleBackgroundWorker_Close();
            _stillOpen = false;
            handleSongHasBeenPaused(true);
            handleBtnPlayVisibility(true);
        }
        private void formClosingEvent(object sender, FormClosingEventArgs e)
        {
            _stillOpen = false;

            //if the worker is still busy, close it gracefully
            if (backgroundWorker1.IsBusy)
            {
                //call for the worker to finish
                HandleBackgroundWorker_Close();

                //todo: display a message to the user asking them to wait for the app to finish up closing

                //while the worker is finishing off its work, let it process all the work it needs to and then close
                while (backgroundWorker1.IsBusy)
                {
                    Application.DoEvents();
                }
            }
            //terminate the current process (Further means of freeing up the resources, in case the others didnt work)
            Environment.Exit(0);
        }
        private void numberUpDown_SongSpeed_ValueChanged(object sender, EventArgs e)
        {
            updateSongoffsetSpeed();
        }

        private void btnRefreshActiveProcesses_Click(object sender, EventArgs e)
        {
            handleAccessCurrentOpenWindows();
        }
    }
}