namespace Windsong_Lyre
{
    partial class AdvancedAppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressbarSongStatus = new System.Windows.Forms.ProgressBar();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxCurrentSongName = new System.Windows.Forms.TextBox();
            this.txtboxHuntingFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnPreviousSong = new System.Windows.Forms.Button();
            this.btnNextSong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressbarSongStatus
            // 
            this.progressbarSongStatus.Location = new System.Drawing.Point(136, 139);
            this.progressbarSongStatus.Name = "progressbarSongStatus";
            this.progressbarSongStatus.Size = new System.Drawing.Size(366, 42);
            this.progressbarSongStatus.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(528, 139);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(82, 42);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(616, 139);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(82, 42);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Stop";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Song:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Song Progress:";
            // 
            // txtboxCurrentSongName
            // 
            this.txtboxCurrentSongName.Location = new System.Drawing.Point(136, 95);
            this.txtboxCurrentSongName.Name = "txtboxCurrentSongName";
            this.txtboxCurrentSongName.ReadOnly = true;
            this.txtboxCurrentSongName.Size = new System.Drawing.Size(366, 26);
            this.txtboxCurrentSongName.TabIndex = 5;
            // 
            // txtboxHuntingFolder
            // 
            this.txtboxHuntingFolder.Location = new System.Drawing.Point(136, 24);
            this.txtboxHuntingFolder.Name = "txtboxHuntingFolder";
            this.txtboxHuntingFolder.ReadOnly = true;
            this.txtboxHuntingFolder.Size = new System.Drawing.Size(366, 26);
            this.txtboxHuntingFolder.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current Folder:";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(528, 18);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(170, 39);
            this.btnOpenFolder.TabIndex = 8;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnPreviousSong
            // 
            this.btnPreviousSong.Location = new System.Drawing.Point(528, 87);
            this.btnPreviousSong.Name = "btnPreviousSong";
            this.btnPreviousSong.Size = new System.Drawing.Size(82, 42);
            this.btnPreviousSong.TabIndex = 9;
            this.btnPreviousSong.Text = "<<";
            this.btnPreviousSong.UseVisualStyleBackColor = true;
            this.btnPreviousSong.Click += new System.EventHandler(this.btnPreviousSong_Click);
            // 
            // btnNextSong
            // 
            this.btnNextSong.Location = new System.Drawing.Point(616, 87);
            this.btnNextSong.Name = "btnNextSong";
            this.btnNextSong.Size = new System.Drawing.Size(82, 42);
            this.btnNextSong.TabIndex = 10;
            this.btnNextSong.Text = ">>";
            this.btnNextSong.UseVisualStyleBackColor = true;
            this.btnNextSong.Click += new System.EventHandler(this.btnNextSong_Click);
            // 
            // AdvancedAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(735, 216);
            this.Controls.Add(this.btnNextSong);
            this.Controls.Add(this.btnPreviousSong);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxHuntingFolder);
            this.Controls.Add(this.txtboxCurrentSongName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.progressbarSongStatus);
            this.MaximizeBox = false;
            this.Name = "AdvancedAppForm";
            this.ShowIcon = false;
            this.Text = "Advanced Windsong Controls";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosingEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressbarSongStatus;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxCurrentSongName;
        private System.Windows.Forms.TextBox txtboxHuntingFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnPreviousSong;
        private System.Windows.Forms.Button btnNextSong;
    }
}