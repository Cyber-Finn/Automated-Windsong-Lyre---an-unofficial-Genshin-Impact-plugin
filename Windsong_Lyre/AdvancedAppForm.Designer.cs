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
            this.label4 = new System.Windows.Forms.Label();
            this.numberUpDown_SongSpeed = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboboxActiveProcesses = new System.Windows.Forms.ComboBox();
            this.btnRefreshActiveProcesses = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberUpDown_SongSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // progressbarSongStatus
            // 
            this.progressbarSongStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressbarSongStatus.Location = new System.Drawing.Point(118, 160);
            this.progressbarSongStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressbarSongStatus.Name = "progressbarSongStatus";
            this.progressbarSongStatus.Size = new System.Drawing.Size(325, 34);
            this.progressbarSongStatus.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(467, 160);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(73, 34);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(545, 160);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(73, 34);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Stop";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Song:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Song Progress:";
            // 
            // txtboxCurrentSongName
            // 
            this.txtboxCurrentSongName.Location = new System.Drawing.Point(118, 125);
            this.txtboxCurrentSongName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxCurrentSongName.Name = "txtboxCurrentSongName";
            this.txtboxCurrentSongName.ReadOnly = true;
            this.txtboxCurrentSongName.Size = new System.Drawing.Size(326, 22);
            this.txtboxCurrentSongName.TabIndex = 5;
            // 
            // txtboxHuntingFolder
            // 
            this.txtboxHuntingFolder.Location = new System.Drawing.Point(118, 46);
            this.txtboxHuntingFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxHuntingFolder.Name = "txtboxHuntingFolder";
            this.txtboxHuntingFolder.ReadOnly = true;
            this.txtboxHuntingFolder.Size = new System.Drawing.Size(326, 22);
            this.txtboxHuntingFolder.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current Folder:";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(467, 41);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(151, 31);
            this.btnOpenFolder.TabIndex = 8;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnPreviousSong
            // 
            this.btnPreviousSong.Location = new System.Drawing.Point(467, 118);
            this.btnPreviousSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreviousSong.Name = "btnPreviousSong";
            this.btnPreviousSong.Size = new System.Drawing.Size(73, 34);
            this.btnPreviousSong.TabIndex = 9;
            this.btnPreviousSong.Text = "<<";
            this.btnPreviousSong.UseVisualStyleBackColor = true;
            this.btnPreviousSong.Click += new System.EventHandler(this.btnPreviousSong_Click);
            // 
            // btnNextSong
            // 
            this.btnNextSong.Location = new System.Drawing.Point(545, 118);
            this.btnNextSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextSong.Name = "btnNextSong";
            this.btnNextSong.Size = new System.Drawing.Size(73, 34);
            this.btnNextSong.TabIndex = 10;
            this.btnNextSong.Text = ">>";
            this.btnNextSong.UseVisualStyleBackColor = true;
            this.btnNextSong.Click += new System.EventHandler(this.btnNextSong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Speed:";
            // 
            // numberUpDown_SongSpeed
            // 
            this.numberUpDown_SongSpeed.Location = new System.Drawing.Point(526, 86);
            this.numberUpDown_SongSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberUpDown_SongSpeed.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberUpDown_SongSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberUpDown_SongSpeed.Name = "numberUpDown_SongSpeed";
            this.numberUpDown_SongSpeed.Size = new System.Drawing.Size(92, 22);
            this.numberUpDown_SongSpeed.TabIndex = 12;
            this.numberUpDown_SongSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberUpDown_SongSpeed.ValueChanged += new System.EventHandler(this.numberUpDown_SongSpeed_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Select App:";
            // 
            // comboboxActiveProcesses
            // 
            this.comboboxActiveProcesses.FormattingEnabled = true;
            this.comboboxActiveProcesses.Location = new System.Drawing.Point(118, 7);
            this.comboboxActiveProcesses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboboxActiveProcesses.Name = "comboboxActiveProcesses";
            this.comboboxActiveProcesses.Size = new System.Drawing.Size(326, 24);
            this.comboboxActiveProcesses.TabIndex = 16;
            // 
            // btnRefreshActiveProcesses
            // 
            this.btnRefreshActiveProcesses.Location = new System.Drawing.Point(467, 8);
            this.btnRefreshActiveProcesses.Name = "btnRefreshActiveProcesses";
            this.btnRefreshActiveProcesses.Size = new System.Drawing.Size(73, 28);
            this.btnRefreshActiveProcesses.TabIndex = 17;
            this.btnRefreshActiveProcesses.Text = "Refresh";
            this.btnRefreshActiveProcesses.UseVisualStyleBackColor = true;
            this.btnRefreshActiveProcesses.Click += new System.EventHandler(this.btnRefreshActiveProcesses_Click);
            // 
            // AdvancedAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(637, 214);
            this.Controls.Add(this.btnRefreshActiveProcesses);
            this.Controls.Add(this.comboboxActiveProcesses);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numberUpDown_SongSpeed);
            this.Controls.Add(this.label4);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AdvancedAppForm";
            this.ShowIcon = false;
            this.Text = "Windsong Lyre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosingEvent);
            ((System.ComponentModel.ISupportInitialize)(this.numberUpDown_SongSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numberUpDown_SongSpeed;
        public System.Windows.Forms.ProgressBar progressbarSongStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboboxActiveProcesses;
        private System.Windows.Forms.Button btnRefreshActiveProcesses;
    }
}