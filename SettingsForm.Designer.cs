namespace bss_video_automation
{
    partial class SettingsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.page_Caspar = new System.Windows.Forms.TabPage();
            this.tb_CasparServerAddress = new System.Windows.Forms.TextBox();
            this.lb_CasparServerChannel = new System.Windows.Forms.Label();
            this.lb_CasparServerPort = new System.Windows.Forms.Label();
            this.lb_CasparServerAddress = new System.Windows.Forms.Label();
            this.tb_CasparServerPort = new System.Windows.Forms.TextBox();
            this.tb_CasparChannel = new System.Windows.Forms.NumericUpDown();
            this.btn_TestConnection = new System.Windows.Forms.Button();
            this.lb_Logo = new System.Windows.Forms.Label();
            this.lb_TestResult = new System.Windows.Forms.Label();
            this.tb_LogoSrc = new System.Windows.Forms.TextBox();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.page_Caspar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CasparChannel)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.page_Caspar);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(422, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // page_Caspar
            // 
            this.page_Caspar.Controls.Add(this.btn_Apply);
            this.page_Caspar.Controls.Add(this.tb_LogoSrc);
            this.page_Caspar.Controls.Add(this.lb_TestResult);
            this.page_Caspar.Controls.Add(this.lb_Logo);
            this.page_Caspar.Controls.Add(this.btn_TestConnection);
            this.page_Caspar.Controls.Add(this.tb_CasparChannel);
            this.page_Caspar.Controls.Add(this.tb_CasparServerPort);
            this.page_Caspar.Controls.Add(this.tb_CasparServerAddress);
            this.page_Caspar.Controls.Add(this.lb_CasparServerChannel);
            this.page_Caspar.Controls.Add(this.lb_CasparServerPort);
            this.page_Caspar.Controls.Add(this.lb_CasparServerAddress);
            this.page_Caspar.Location = new System.Drawing.Point(4, 22);
            this.page_Caspar.Name = "page_Caspar";
            this.page_Caspar.Padding = new System.Windows.Forms.Padding(3);
            this.page_Caspar.Size = new System.Drawing.Size(414, 470);
            this.page_Caspar.TabIndex = 0;
            this.page_Caspar.Text = "CasparCG";
            this.page_Caspar.UseVisualStyleBackColor = true;
            // 
            // tb_CasparServerAddress
            // 
            this.tb_CasparServerAddress.Location = new System.Drawing.Point(146, 4);
            this.tb_CasparServerAddress.Name = "tb_CasparServerAddress";
            this.tb_CasparServerAddress.Size = new System.Drawing.Size(262, 20);
            this.tb_CasparServerAddress.TabIndex = 3;
            // 
            // lb_CasparServerChannel
            // 
            this.lb_CasparServerChannel.AutoSize = true;
            this.lb_CasparServerChannel.Location = new System.Drawing.Point(7, 85);
            this.lb_CasparServerChannel.Name = "lb_CasparServerChannel";
            this.lb_CasparServerChannel.Size = new System.Drawing.Size(100, 13);
            this.lb_CasparServerChannel.TabIndex = 2;
            this.lb_CasparServerChannel.Text = "CasparCG Channel:";
            // 
            // lb_CasparServerPort
            // 
            this.lb_CasparServerPort.AutoSize = true;
            this.lb_CasparServerPort.Location = new System.Drawing.Point(7, 30);
            this.lb_CasparServerPort.Name = "lb_CasparServerPort";
            this.lb_CasparServerPort.Size = new System.Drawing.Size(114, 13);
            this.lb_CasparServerPort.TabIndex = 1;
            this.lb_CasparServerPort.Text = "CasparCG Server Port:";
            // 
            // lb_CasparServerAddress
            // 
            this.lb_CasparServerAddress.AutoSize = true;
            this.lb_CasparServerAddress.Location = new System.Drawing.Point(7, 7);
            this.lb_CasparServerAddress.Name = "lb_CasparServerAddress";
            this.lb_CasparServerAddress.Size = new System.Drawing.Size(133, 13);
            this.lb_CasparServerAddress.TabIndex = 0;
            this.lb_CasparServerAddress.Text = "CasparCG Server Address:";
            // 
            // tb_CasparServerPort
            // 
            this.tb_CasparServerPort.Location = new System.Drawing.Point(146, 27);
            this.tb_CasparServerPort.Name = "tb_CasparServerPort";
            this.tb_CasparServerPort.Size = new System.Drawing.Size(98, 20);
            this.tb_CasparServerPort.TabIndex = 4;
            // 
            // tb_CasparChannel
            // 
            this.tb_CasparChannel.Location = new System.Drawing.Point(146, 83);
            this.tb_CasparChannel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tb_CasparChannel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tb_CasparChannel.Name = "tb_CasparChannel";
            this.tb_CasparChannel.Size = new System.Drawing.Size(98, 20);
            this.tb_CasparChannel.TabIndex = 5;
            this.tb_CasparChannel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_TestConnection
            // 
            this.btn_TestConnection.Location = new System.Drawing.Point(286, 53);
            this.btn_TestConnection.Name = "btn_TestConnection";
            this.btn_TestConnection.Size = new System.Drawing.Size(122, 23);
            this.btn_TestConnection.TabIndex = 6;
            this.btn_TestConnection.Text = "Test Connection";
            this.btn_TestConnection.UseVisualStyleBackColor = true;
            this.btn_TestConnection.Click += new System.EventHandler(this.btn_TestConnection_Click);
            // 
            // lb_Logo
            // 
            this.lb_Logo.AutoSize = true;
            this.lb_Logo.Location = new System.Drawing.Point(7, 110);
            this.lb_Logo.Name = "lb_Logo";
            this.lb_Logo.Size = new System.Drawing.Size(34, 13);
            this.lb_Logo.TabIndex = 7;
            this.lb_Logo.Text = "Logo:";
            // 
            // lb_TestResult
            // 
            this.lb_TestResult.AutoSize = true;
            this.lb_TestResult.Location = new System.Drawing.Point(286, 84);
            this.lb_TestResult.Name = "lb_TestResult";
            this.lb_TestResult.Size = new System.Drawing.Size(0, 13);
            this.lb_TestResult.TabIndex = 8;
            // 
            // tb_LogoSrc
            // 
            this.tb_LogoSrc.Location = new System.Drawing.Point(146, 107);
            this.tb_LogoSrc.Name = "tb_LogoSrc";
            this.tb_LogoSrc.Size = new System.Drawing.Size(262, 20);
            this.tb_LogoSrc.TabIndex = 9;
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(289, 441);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(118, 23);
            this.btn_Apply.TabIndex = 10;
            this.btn_Apply.Text = "Apply changes";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 521);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.tabControl1.ResumeLayout(false);
            this.page_Caspar.ResumeLayout(false);
            this.page_Caspar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CasparChannel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage page_Caspar;
        private System.Windows.Forms.Label lb_CasparServerPort;
        private System.Windows.Forms.Label lb_CasparServerAddress;
        private System.Windows.Forms.TextBox tb_CasparServerAddress;
        private System.Windows.Forms.Label lb_CasparServerChannel;
        private System.Windows.Forms.NumericUpDown tb_CasparChannel;
        private System.Windows.Forms.TextBox tb_CasparServerPort;
        private System.Windows.Forms.TextBox tb_LogoSrc;
        private System.Windows.Forms.Label lb_TestResult;
        private System.Windows.Forms.Label lb_Logo;
        private System.Windows.Forms.Button btn_TestConnection;
        private System.Windows.Forms.Button btn_Apply;
    }
}