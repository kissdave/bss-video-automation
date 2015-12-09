namespace bss_video_automation
{
    partial class VideoEditorForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.videosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bss_video_automationDataSet = new bss_video_automation.bss_video_automationDataSet();
            this.videosTableAdapter = new bss_video_automation.bss_video_automationDataSetTableAdapters.VideosTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_RefreshList = new System.Windows.Forms.Button();
            this.btn_AddVideo = new System.Windows.Forms.Button();
            this.videoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationFramesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contributorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bss_video_automationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.videoIDDataGridViewTextBoxColumn,
            this.filenameDataGridViewTextBoxColumn,
            this.durationTimeDataGridViewTextBoxColumn,
            this.durationFramesDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.makeDateDataGridViewTextBoxColumn,
            this.contributorsDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.videosBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(908, 416);
            this.dataGridView1.TabIndex = 0;
            // 
            // videosBindingSource
            // 
            this.videosBindingSource.DataMember = "Videos";
            this.videosBindingSource.DataSource = this.bss_video_automationDataSet;
            // 
            // bss_video_automationDataSet
            // 
            this.bss_video_automationDataSet.DataSetName = "bss_video_automationDataSet";
            this.bss_video_automationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // videosTableAdapter
            // 
            this.videosTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_RefreshList);
            this.splitContainer1.Panel1.Controls.Add(this.btn_AddVideo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(908, 453);
            this.splitContainer1.SplitterDistance = 33;
            this.splitContainer1.TabIndex = 1;
            // 
            // btn_RefreshList
            // 
            this.btn_RefreshList.Location = new System.Drawing.Point(181, 4);
            this.btn_RefreshList.Name = "btn_RefreshList";
            this.btn_RefreshList.Size = new System.Drawing.Size(188, 23);
            this.btn_RefreshList.TabIndex = 1;
            this.btn_RefreshList.Text = "Refresh list";
            this.btn_RefreshList.UseVisualStyleBackColor = true;
            this.btn_RefreshList.Click += new System.EventHandler(this.btn_RefreshList_Click);
            // 
            // btn_AddVideo
            // 
            this.btn_AddVideo.Location = new System.Drawing.Point(4, 4);
            this.btn_AddVideo.Name = "btn_AddVideo";
            this.btn_AddVideo.Size = new System.Drawing.Size(171, 23);
            this.btn_AddVideo.TabIndex = 0;
            this.btn_AddVideo.Text = "Add video";
            this.btn_AddVideo.UseVisualStyleBackColor = true;
            this.btn_AddVideo.Click += new System.EventHandler(this.btn_AddVideo_Click);
            // 
            // videoIDDataGridViewTextBoxColumn
            // 
            this.videoIDDataGridViewTextBoxColumn.DataPropertyName = "VideoID";
            this.videoIDDataGridViewTextBoxColumn.HeaderText = "VideoID";
            this.videoIDDataGridViewTextBoxColumn.Name = "videoIDDataGridViewTextBoxColumn";
            this.videoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filenameDataGridViewTextBoxColumn
            // 
            this.filenameDataGridViewTextBoxColumn.DataPropertyName = "Filename";
            this.filenameDataGridViewTextBoxColumn.HeaderText = "Filename";
            this.filenameDataGridViewTextBoxColumn.Name = "filenameDataGridViewTextBoxColumn";
            // 
            // durationTimeDataGridViewTextBoxColumn
            // 
            this.durationTimeDataGridViewTextBoxColumn.DataPropertyName = "DurationTime";
            this.durationTimeDataGridViewTextBoxColumn.HeaderText = "DurationTime";
            this.durationTimeDataGridViewTextBoxColumn.Name = "durationTimeDataGridViewTextBoxColumn";
            // 
            // durationFramesDataGridViewTextBoxColumn
            // 
            this.durationFramesDataGridViewTextBoxColumn.DataPropertyName = "DurationFrames";
            this.durationFramesDataGridViewTextBoxColumn.HeaderText = "DurationFrames";
            this.durationFramesDataGridViewTextBoxColumn.Name = "durationFramesDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // makeDateDataGridViewTextBoxColumn
            // 
            this.makeDateDataGridViewTextBoxColumn.DataPropertyName = "MakeDate";
            this.makeDateDataGridViewTextBoxColumn.HeaderText = "MakeDate";
            this.makeDateDataGridViewTextBoxColumn.Name = "makeDateDataGridViewTextBoxColumn";
            // 
            // contributorsDataGridViewTextBoxColumn
            // 
            this.contributorsDataGridViewTextBoxColumn.DataPropertyName = "Contributors";
            this.contributorsDataGridViewTextBoxColumn.HeaderText = "Contributors";
            this.contributorsDataGridViewTextBoxColumn.Name = "contributorsDataGridViewTextBoxColumn";
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // VideoEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 453);
            this.Controls.Add(this.splitContainer1);
            this.Name = "VideoEditorForm";
            this.Text = "VideoEditorForm";
            this.Load += new System.EventHandler(this.VideoEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bss_video_automationDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bss_video_automationDataSet bss_video_automationDataSet;
        private System.Windows.Forms.BindingSource videosBindingSource;
        private bss_video_automationDataSetTableAdapters.VideosTableAdapter videosTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_AddVideo;
        private System.Windows.Forms.Button btn_RefreshList;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationFramesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contributorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
    }
}