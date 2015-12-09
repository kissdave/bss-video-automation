namespace bss_video_automation
{
    partial class AddScheduledVideo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Video = new System.Windows.Forms.ComboBox();
            this.dtpick_start = new System.Windows.Forms.DateTimePicker();
            this.checkbox_Live = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpick_end = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Duration_Hour = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Duration_Minute = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Duration_Second = new System.Windows.Forms.NumericUpDown();
            this.cb_isPremiere = new System.Windows.Forms.CheckBox();
            this.btn_Send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Duration_Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Duration_Minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Duration_Second)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start time:";
            // 
            // cb_Video
            // 
            this.cb_Video.FormattingEnabled = true;
            this.cb_Video.Location = new System.Drawing.Point(69, 31);
            this.cb_Video.Name = "cb_Video";
            this.cb_Video.Size = new System.Drawing.Size(240, 21);
            this.cb_Video.TabIndex = 2;
            this.cb_Video.SelectedIndexChanged += new System.EventHandler(this.cb_Video_SelectedIndexChanged);
            // 
            // dtpick_start
            // 
            this.dtpick_start.CustomFormat = "yyyy. MM. dd.  HH:mm:ss";
            this.dtpick_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpick_start.Location = new System.Drawing.Point(69, 54);
            this.dtpick_start.Name = "dtpick_start";
            this.dtpick_start.Size = new System.Drawing.Size(240, 20);
            this.dtpick_start.TabIndex = 3;
            this.dtpick_start.ValueChanged += new System.EventHandler(this.dtpick_start_ValueChanged);
            // 
            // checkbox_Live
            // 
            this.checkbox_Live.AutoSize = true;
            this.checkbox_Live.Location = new System.Drawing.Point(69, 8);
            this.checkbox_Live.Name = "checkbox_Live";
            this.checkbox_Live.Size = new System.Drawing.Size(46, 17);
            this.checkbox_Live.TabIndex = 5;
            this.checkbox_Live.Text = "Live";
            this.checkbox_Live.UseVisualStyleBackColor = true;
            this.checkbox_Live.CheckedChanged += new System.EventHandler(this.checkbox_Live_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "End time:";
            // 
            // dtpick_end
            // 
            this.dtpick_end.CustomFormat = "yyyy. MM. dd.  HH:mm:ss";
            this.dtpick_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpick_end.Location = new System.Drawing.Point(69, 80);
            this.dtpick_end.Name = "dtpick_end";
            this.dtpick_end.Size = new System.Drawing.Size(240, 20);
            this.dtpick_end.TabIndex = 7;
            this.dtpick_end.ValueChanged += new System.EventHandler(this.dtpick_end_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Duration";
            // 
            // tb_Duration_Hour
            // 
            this.tb_Duration_Hour.Location = new System.Drawing.Point(69, 105);
            this.tb_Duration_Hour.Name = "tb_Duration_Hour";
            this.tb_Duration_Hour.Size = new System.Drawing.Size(46, 20);
            this.tb_Duration_Hour.TabIndex = 9;
            this.tb_Duration_Hour.ValueChanged += new System.EventHandler(this.tb_Duration_Hour_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "m";
            // 
            // tb_Duration_Minute
            // 
            this.tb_Duration_Minute.Location = new System.Drawing.Point(140, 106);
            this.tb_Duration_Minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.tb_Duration_Minute.Name = "tb_Duration_Minute";
            this.tb_Duration_Minute.Size = new System.Drawing.Size(46, 20);
            this.tb_Duration_Minute.TabIndex = 11;
            this.tb_Duration_Minute.ValueChanged += new System.EventHandler(this.tb_Duration_Minute_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "s";
            // 
            // tb_Duration_Second
            // 
            this.tb_Duration_Second.Location = new System.Drawing.Point(213, 106);
            this.tb_Duration_Second.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.tb_Duration_Second.Name = "tb_Duration_Second";
            this.tb_Duration_Second.Size = new System.Drawing.Size(46, 20);
            this.tb_Duration_Second.TabIndex = 13;
            this.tb_Duration_Second.ValueChanged += new System.EventHandler(this.tb_Duration_Second_ValueChanged);
            // 
            // cb_isPremiere
            // 
            this.cb_isPremiere.AutoSize = true;
            this.cb_isPremiere.Location = new System.Drawing.Point(69, 132);
            this.cb_isPremiere.Name = "cb_isPremiere";
            this.cb_isPremiere.Size = new System.Drawing.Size(357, 17);
            this.cb_isPremiere.TabIndex = 15;
            this.cb_isPremiere.Text = "Premiere (First playing, the video will not be scheduled before this time)";
            this.cb_isPremiere.UseVisualStyleBackColor = true;
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Send.ForeColor = System.Drawing.Color.White;
            this.btn_Send.Location = new System.Drawing.Point(351, 155);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(177, 23);
            this.btn_Send.TabIndex = 16;
            this.btn_Send.Text = "Add video";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // AddScheduledVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 186);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.cb_isPremiere);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Duration_Second);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Duration_Minute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Duration_Hour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpick_end);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkbox_Live);
            this.Controls.Add(this.dtpick_start);
            this.Controls.Add(this.cb_Video);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddScheduledVideo";
            this.Text = "AddScheduledVideo";
            ((System.ComponentModel.ISupportInitialize)(this.tb_Duration_Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Duration_Minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Duration_Second)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Video;
        private System.Windows.Forms.DateTimePicker dtpick_start;
        private System.Windows.Forms.CheckBox checkbox_Live;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpick_end;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown tb_Duration_Hour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown tb_Duration_Minute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown tb_Duration_Second;
        private System.Windows.Forms.CheckBox cb_isPremiere;
        private System.Windows.Forms.Button btn_Send;
    }
}