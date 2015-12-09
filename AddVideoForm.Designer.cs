namespace bss_video_automation
{
    partial class AddVideoForm
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
            this.lb_filename = new System.Windows.Forms.Label();
            this.cb_Filename = new System.Windows.Forms.ComboBox();
            this.lb_Title = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.cal_Date = new System.Windows.Forms.MonthCalendar();
            this.tb_Title = new System.Windows.Forms.TextBox();
            this.lb_Contributors = new System.Windows.Forms.Label();
            this.tb_Contributors = new System.Windows.Forms.TextBox();
            this.lb_Rating = new System.Windows.Forms.Label();
            this.tb_Rating = new System.Windows.Forms.NumericUpDown();
            this.btn_Send = new System.Windows.Forms.Button();
            this.lb_Duration = new System.Windows.Forms.Label();
            this.tb_Duration = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Rating)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_filename
            // 
            this.lb_filename.AutoSize = true;
            this.lb_filename.Location = new System.Drawing.Point(13, 13);
            this.lb_filename.Name = "lb_filename";
            this.lb_filename.Size = new System.Drawing.Size(49, 13);
            this.lb_filename.TabIndex = 0;
            this.lb_filename.Text = "Filename";
            // 
            // cb_Filename
            // 
            this.cb_Filename.FormattingEnabled = true;
            this.cb_Filename.Location = new System.Drawing.Point(110, 12);
            this.cb_Filename.Name = "cb_Filename";
            this.cb_Filename.Size = new System.Drawing.Size(558, 21);
            this.cb_Filename.TabIndex = 1;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Location = new System.Drawing.Point(12, 66);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(27, 13);
            this.lb_Title.TabIndex = 2;
            this.lb_Title.Text = "Title";
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Location = new System.Drawing.Point(12, 91);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(30, 13);
            this.lb_Date.TabIndex = 3;
            this.lb_Date.Text = "Date";
            // 
            // cal_Date
            // 
            this.cal_Date.Location = new System.Drawing.Point(109, 91);
            this.cal_Date.Name = "cal_Date";
            this.cal_Date.TabIndex = 4;
            // 
            // tb_Title
            // 
            this.tb_Title.Location = new System.Drawing.Point(110, 66);
            this.tb_Title.Name = "tb_Title";
            this.tb_Title.Size = new System.Drawing.Size(558, 20);
            this.tb_Title.TabIndex = 5;
            // 
            // lb_Contributors
            // 
            this.lb_Contributors.AutoSize = true;
            this.lb_Contributors.Location = new System.Drawing.Point(12, 269);
            this.lb_Contributors.Name = "lb_Contributors";
            this.lb_Contributors.Size = new System.Drawing.Size(63, 13);
            this.lb_Contributors.TabIndex = 6;
            this.lb_Contributors.Text = "Contributors";
            // 
            // tb_Contributors
            // 
            this.tb_Contributors.Location = new System.Drawing.Point(110, 265);
            this.tb_Contributors.Name = "tb_Contributors";
            this.tb_Contributors.Size = new System.Drawing.Size(558, 20);
            this.tb_Contributors.TabIndex = 7;
            // 
            // lb_Rating
            // 
            this.lb_Rating.AutoSize = true;
            this.lb_Rating.Location = new System.Drawing.Point(12, 299);
            this.lb_Rating.Name = "lb_Rating";
            this.lb_Rating.Size = new System.Drawing.Size(38, 13);
            this.lb_Rating.TabIndex = 8;
            this.lb_Rating.Text = "Rating";
            // 
            // tb_Rating
            // 
            this.tb_Rating.DecimalPlaces = 1;
            this.tb_Rating.Location = new System.Drawing.Point(110, 299);
            this.tb_Rating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tb_Rating.Name = "tb_Rating";
            this.tb_Rating.Size = new System.Drawing.Size(558, 20);
            this.tb_Rating.TabIndex = 9;
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Send.ForeColor = System.Drawing.Color.White;
            this.btn_Send.Location = new System.Drawing.Point(491, 325);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(177, 23);
            this.btn_Send.TabIndex = 10;
            this.btn_Send.Text = "Add video";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // lb_Duration
            // 
            this.lb_Duration.AutoSize = true;
            this.lb_Duration.Location = new System.Drawing.Point(13, 43);
            this.lb_Duration.Name = "lb_Duration";
            this.lb_Duration.Size = new System.Drawing.Size(87, 13);
            this.lb_Duration.TabIndex = 11;
            this.lb_Duration.Text = "Duration (frames)";
            // 
            // tb_Duration
            // 
            this.tb_Duration.Location = new System.Drawing.Point(110, 40);
            this.tb_Duration.Name = "tb_Duration";
            this.tb_Duration.Size = new System.Drawing.Size(558, 20);
            this.tb_Duration.TabIndex = 12;
            // 
            // AddVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 352);
            this.Controls.Add(this.tb_Duration);
            this.Controls.Add(this.lb_Duration);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.tb_Rating);
            this.Controls.Add(this.lb_Rating);
            this.Controls.Add(this.tb_Contributors);
            this.Controls.Add(this.lb_Contributors);
            this.Controls.Add(this.tb_Title);
            this.Controls.Add(this.cal_Date);
            this.Controls.Add(this.lb_Date);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.cb_Filename);
            this.Controls.Add(this.lb_filename);
            this.Name = "AddVideoForm";
            this.Text = "AddVideoForm";
            ((System.ComponentModel.ISupportInitialize)(this.tb_Rating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_filename;
        private System.Windows.Forms.ComboBox cb_Filename;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.MonthCalendar cal_Date;
        private System.Windows.Forms.TextBox tb_Title;
        private System.Windows.Forms.Label lb_Contributors;
        private System.Windows.Forms.TextBox tb_Contributors;
        private System.Windows.Forms.Label lb_Rating;
        private System.Windows.Forms.NumericUpDown tb_Rating;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Label lb_Duration;
        private System.Windows.Forms.TextBox tb_Duration;
    }
}