using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windsong_Lyre
{
    public partial class AdvancedAppForm : Form
    {
        private string _folderName = string.Empty;
        private List<string> _songsInDirectory = new List<string>();
        private bool _songHasFinished = false;
        private bool _stillOpen = true;
        private int _currentSong = 0;
        private int _currentSongStartIndex = 0;
        // Create a BackgroundWorker instance for the music player (multithreading, basically)
        private BackgroundWorker backgroundWorker1 = new BackgroundWorker();
        
        public AdvancedAppForm()
        {
            InitializeComponent();
            SetUpHandlers_BackgroundWorker();
            HandleButtons_Enabled(false);
        }
        private void HandleButtons_Enabled(bool isEnabled)
        {
            btnNextSong.Enabled = isEnabled;
            btnPreviousSong.Enabled = isEnabled;
            btnPause.Enabled = isEnabled;
            btnPlay.Enabled = isEnabled;
        }
        private void SetUpHandlers_BackgroundWorker()
        {
            //to allow us to close the worker later on
            backgroundWorker1.WorkerSupportsCancellation = true;

            // Set up event handlers
            backgroundWorker1.DoWork += HandleBackgroundWorker_DoWork;
            backgroundWorker1.RunWorkerCompleted += HandleBackgroundWorker_WhenWorkCompleted;

            //allows us to update the progressbar in the background thread
            backgroundWorker1.ProgressChanged += (sender, e) =>
            {
                progressbarSongStatus.Value = e.ProgressPercentage;
            };
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();
            if(fbDialog.ShowDialog() == DialogResult.OK)
            {
                _folderName = fbDialog.SelectedPath;
                txtboxHuntingFolder.Text = _folderName;
                Handle_SongsInDirectory();

                //load up the first song by default
                updateTextBox_CurrentSong(_songsInDirectory[_currentSong]);
                HandleButtons_Enabled(true);
            }
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
                // Your file creation logic here
                // ...


                // Check for cancellation
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true; // Indicate cancellation of the worker thread
                    break;
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
            if(_currentSong > 0)
            {
                _currentSong--;
            }
            else //wrap it back to the last one in the list
            {
                _currentSong = _songsInDirectory.Count-1;
            }
            updateTextBox_CurrentSong();
        }

        private void btnNextSong_Click(object sender, EventArgs e)
        {
            if (_currentSong < _songsInDirectory.Count-1)
            {
                _currentSong++;
            }
            else //wrap it back to the first one in the list
            {
                _currentSong = 0;
            }
            updateTextBox_CurrentSong();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            _stillOpen = true;
            // Start the background worker
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            HandleBackgroundWorker_Close();
            _stillOpen = false;
        }

        private void formClosingEvent(object sender, FormClosingEventArgs e)
        {
            HandleBackgroundWorker_Close();
            backgroundWorker1.Dispose();
            _stillOpen = false;
            //terminate the current process (Further means of freeing up the resources for if the others didnt work)
            Environment.Exit(0);
        }
    }
}



