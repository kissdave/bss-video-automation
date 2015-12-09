namespace bss_video_automation
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.lb_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainSplit = new System.Windows.Forms.SplitContainer();
            this.listBox_playlist = new System.Windows.Forms.ListBox();
            this.SideSplit = new System.Windows.Forms.SplitContainer();
            this.lb_clock = new System.Windows.Forms.Label();
            this.btn_Player_Disconnect = new System.Windows.Forms.Button();
            this.btn_Player_Connect = new System.Windows.Forms.Button();
            this.btn_Player_Stop = new System.Windows.Forms.Button();
            this.btn_Player_Start = new System.Windows.Forms.Button();
            this.timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).BeginInit();
            this.MainSplit.Panel1.SuspendLayout();
            this.MainSplit.Panel2.SuspendLayout();
            this.MainSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SideSplit)).BeginInit();
            this.SideSplit.Panel1.SuspendLayout();
            this.SideSplit.Panel2.SuspendLayout();
            this.SideSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.logToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.editorToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editorToolStripMenuItem.Text = "Editor";
            this.editorToolStripMenuItem.Click += new System.EventHandler(this.editorToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.errorLogToolStripMenuItem,
            this.videoLogToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // errorLogToolStripMenuItem
            // 
            this.errorLogToolStripMenuItem.Name = "errorLogToolStripMenuItem";
            this.errorLogToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.errorLogToolStripMenuItem.Text = "Error log";
            this.errorLogToolStripMenuItem.Click += new System.EventHandler(this.errorLogToolStripMenuItem_Click);
            // 
            // videoLogToolStripMenuItem
            // 
            this.videoLogToolStripMenuItem.Name = "videoLogToolStripMenuItem";
            this.videoLogToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.videoLogToolStripMenuItem.Text = "Video log";
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_status});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 487);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(952, 22);
            this.mainStatusStrip.TabIndex = 1;
            this.mainStatusStrip.Text = "mainStatusStrip";
            // 
            // lb_status
            // 
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(53, 17);
            this.lb_status.Text = "lb_status";
            // 
            // MainSplit
            // 
            this.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.MainSplit.IsSplitterFixed = true;
            this.MainSplit.Location = new System.Drawing.Point(0, 24);
            this.MainSplit.Name = "MainSplit";
            // 
            // MainSplit.Panel1
            // 
            this.MainSplit.Panel1.Controls.Add(this.listBox_playlist);
            // 
            // MainSplit.Panel2
            // 
            this.MainSplit.Panel2.Controls.Add(this.SideSplit);
            this.MainSplit.Size = new System.Drawing.Size(952, 463);
            this.MainSplit.SplitterDistance = 714;
            this.MainSplit.SplitterWidth = 1;
            this.MainSplit.TabIndex = 2;
            // 
            // listBox_playlist
            // 
            this.listBox_playlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_playlist.FormattingEnabled = true;
            this.listBox_playlist.Location = new System.Drawing.Point(0, 0);
            this.listBox_playlist.Name = "listBox_playlist";
            this.listBox_playlist.Size = new System.Drawing.Size(714, 463);
            this.listBox_playlist.TabIndex = 0;
            // 
            // SideSplit
            // 
            this.SideSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SideSplit.IsSplitterFixed = true;
            this.SideSplit.Location = new System.Drawing.Point(0, 0);
            this.SideSplit.Name = "SideSplit";
            this.SideSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SideSplit.Panel1
            // 
            this.SideSplit.Panel1.BackColor = System.Drawing.Color.LightYellow;
            this.SideSplit.Panel1.Controls.Add(this.lb_clock);
            // 
            // SideSplit.Panel2
            // 
            this.SideSplit.Panel2.Controls.Add(this.btn_Player_Disconnect);
            this.SideSplit.Panel2.Controls.Add(this.btn_Player_Connect);
            this.SideSplit.Panel2.Controls.Add(this.btn_Player_Stop);
            this.SideSplit.Panel2.Controls.Add(this.btn_Player_Start);
            this.SideSplit.Size = new System.Drawing.Size(237, 463);
            this.SideSplit.SplitterWidth = 1;
            this.SideSplit.TabIndex = 0;
            // 
            // lb_clock
            // 
            this.lb_clock.AutoSize = true;
            this.lb_clock.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_clock.Location = new System.Drawing.Point(41, 5);
            this.lb_clock.Name = "lb_clock";
            this.lb_clock.Size = new System.Drawing.Size(167, 38);
            this.lb_clock.TabIndex = 0;
            this.lb_clock.Text = "00:00:00";
            this.lb_clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Player_Disconnect
            // 
            this.btn_Player_Disconnect.BackColor = System.Drawing.Color.Red;
            this.btn_Player_Disconnect.Location = new System.Drawing.Point(4, 92);
            this.btn_Player_Disconnect.Name = "btn_Player_Disconnect";
            this.btn_Player_Disconnect.Size = new System.Drawing.Size(230, 23);
            this.btn_Player_Disconnect.TabIndex = 3;
            this.btn_Player_Disconnect.Text = "DISCONNECT FROM SERVER";
            this.btn_Player_Disconnect.UseVisualStyleBackColor = false;
            this.btn_Player_Disconnect.Click += new System.EventHandler(this.btn_Player_Disconnect_Click);
            // 
            // btn_Player_Connect
            // 
            this.btn_Player_Connect.Location = new System.Drawing.Point(4, 4);
            this.btn_Player_Connect.Name = "btn_Player_Connect";
            this.btn_Player_Connect.Size = new System.Drawing.Size(230, 23);
            this.btn_Player_Connect.TabIndex = 2;
            this.btn_Player_Connect.Text = "CONNECT TO SERVER";
            this.btn_Player_Connect.UseVisualStyleBackColor = true;
            this.btn_Player_Connect.Click += new System.EventHandler(this.btn_Player_Connect_Click);
            // 
            // btn_Player_Stop
            // 
            this.btn_Player_Stop.BackColor = System.Drawing.Color.Orange;
            this.btn_Player_Stop.Location = new System.Drawing.Point(4, 62);
            this.btn_Player_Stop.Name = "btn_Player_Stop";
            this.btn_Player_Stop.Size = new System.Drawing.Size(230, 23);
            this.btn_Player_Stop.TabIndex = 1;
            this.btn_Player_Stop.Text = "STOP PLAYOUT";
            this.btn_Player_Stop.UseVisualStyleBackColor = false;
            this.btn_Player_Stop.Click += new System.EventHandler(this.btn_Player_Stop_Click);
            // 
            // btn_Player_Start
            // 
            this.btn_Player_Start.Location = new System.Drawing.Point(4, 33);
            this.btn_Player_Start.Name = "btn_Player_Start";
            this.btn_Player_Start.Size = new System.Drawing.Size(230, 23);
            this.btn_Player_Start.TabIndex = 0;
            this.btn_Player_Start.Text = "START PLAYOUT";
            this.btn_Player_Start.UseVisualStyleBackColor = true;
            this.btn_Player_Start.Click += new System.EventHandler(this.btn_Player_Start_Click);
            // 
            // timer_Clock
            // 
            this.timer_Clock.Enabled = true;
            this.timer_Clock.Interval = 10;
            this.timer_Clock.Tick += new System.EventHandler(this.timer_Clock_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 509);
            this.Controls.Add(this.MainSplit);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Text = "BSS Video Automation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.MainSplit.Panel1.ResumeLayout(false);
            this.MainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).EndInit();
            this.MainSplit.ResumeLayout(false);
            this.SideSplit.Panel1.ResumeLayout(false);
            this.SideSplit.Panel1.PerformLayout();
            this.SideSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SideSplit)).EndInit();
            this.SideSplit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoLogToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.SplitContainer MainSplit;
        private System.Windows.Forms.SplitContainer SideSplit;
        private System.Windows.Forms.Label lb_clock;
        private System.Windows.Forms.Timer timer_Clock;
        private System.Windows.Forms.Button btn_Player_Start;
        private System.Windows.Forms.Button btn_Player_Disconnect;
        private System.Windows.Forms.Button btn_Player_Connect;
        private System.Windows.Forms.Button btn_Player_Stop;
        private System.Windows.Forms.ToolStripStatusLabel lb_status;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox_playlist;
    }
}

