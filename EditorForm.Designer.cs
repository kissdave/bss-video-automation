namespace bss_video_automation
{
    partial class EditorForm
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
            this.btn_manageVideos = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cb_Week = new System.Windows.Forms.ComboBox();
            this.cb_Year = new System.Windows.Forms.ComboBox();
            this.btn_GenerateContent = new System.Windows.Forms.Button();
            this.btn_AddScheduledVideo = new System.Windows.Forms.Button();
            this.dataGrid_list = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_list)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_manageVideos
            // 
            this.btn_manageVideos.Location = new System.Drawing.Point(12, 12);
            this.btn_manageVideos.Name = "btn_manageVideos";
            this.btn_manageVideos.Size = new System.Drawing.Size(150, 23);
            this.btn_manageVideos.TabIndex = 0;
            this.btn_manageVideos.Text = "Manage videos";
            this.btn_manageVideos.UseVisualStyleBackColor = true;
            this.btn_manageVideos.Click += new System.EventHandler(this.btn_manageVideos_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cb_Week);
            this.splitContainer1.Panel1.Controls.Add(this.cb_Year);
            this.splitContainer1.Panel1.Controls.Add(this.btn_GenerateContent);
            this.splitContainer1.Panel1.Controls.Add(this.btn_AddScheduledVideo);
            this.splitContainer1.Panel1.Controls.Add(this.btn_manageVideos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGrid_list);
            this.splitContainer1.Size = new System.Drawing.Size(1083, 506);
            this.splitContainer1.SplitterDistance = 44;
            this.splitContainer1.TabIndex = 1;
            // 
            // cb_Week
            // 
            this.cb_Week.FormattingEnabled = true;
            this.cb_Week.Location = new System.Drawing.Point(755, 14);
            this.cb_Week.Name = "cb_Week";
            this.cb_Week.Size = new System.Drawing.Size(315, 21);
            this.cb_Week.TabIndex = 4;
            this.cb_Week.SelectedIndexChanged += new System.EventHandler(this.cb_Week_SelectedIndexChanged);
            // 
            // cb_Year
            // 
            this.cb_Year.FormattingEnabled = true;
            this.cb_Year.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017"});
            this.cb_Year.Location = new System.Drawing.Point(628, 14);
            this.cb_Year.Name = "cb_Year";
            this.cb_Year.Size = new System.Drawing.Size(121, 21);
            this.cb_Year.TabIndex = 3;
            this.cb_Year.SelectedIndexChanged += new System.EventHandler(this.cb_Year_SelectedIndexChanged);
            // 
            // btn_GenerateContent
            // 
            this.btn_GenerateContent.Location = new System.Drawing.Point(324, 12);
            this.btn_GenerateContent.Name = "btn_GenerateContent";
            this.btn_GenerateContent.Size = new System.Drawing.Size(150, 23);
            this.btn_GenerateContent.TabIndex = 2;
            this.btn_GenerateContent.Text = "Generate content";
            this.btn_GenerateContent.UseVisualStyleBackColor = true;
            this.btn_GenerateContent.Click += new System.EventHandler(this.btn_GenerateContent_Click);
            // 
            // btn_AddScheduledVideo
            // 
            this.btn_AddScheduledVideo.Location = new System.Drawing.Point(168, 12);
            this.btn_AddScheduledVideo.Name = "btn_AddScheduledVideo";
            this.btn_AddScheduledVideo.Size = new System.Drawing.Size(150, 23);
            this.btn_AddScheduledVideo.TabIndex = 1;
            this.btn_AddScheduledVideo.Text = "Add scheduled video";
            this.btn_AddScheduledVideo.UseVisualStyleBackColor = true;
            this.btn_AddScheduledVideo.Click += new System.EventHandler(this.btn_AddScheduledVideo_Click);
            // 
            // dataGrid_list
            // 
            this.dataGrid_list.AllowUserToAddRows = false;
            this.dataGrid_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_list.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_list.Name = "dataGrid_list";
            this.dataGrid_list.ReadOnly = true;
            this.dataGrid_list.Size = new System.Drawing.Size(1083, 458);
            this.dataGrid_list.TabIndex = 0;
            this.dataGrid_list.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGrid_list_UserDeletingRow);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 506);
            this.Controls.Add(this.splitContainer1);
            this.Name = "EditorForm";
            this.Text = "EditorForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_manageVideos;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cb_Week;
        private System.Windows.Forms.ComboBox cb_Year;
        private System.Windows.Forms.Button btn_GenerateContent;
        private System.Windows.Forms.Button btn_AddScheduledVideo;
        private System.Windows.Forms.DataGridView dataGrid_list;
    }
}