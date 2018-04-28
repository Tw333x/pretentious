namespace Pretentious
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.FilePathText = new System.Windows.Forms.TextBox();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.FileLabel = new System.Windows.Forms.Label();
            this.SelectButton = new System.Windows.Forms.Button();
            this.BindButton = new System.Windows.Forms.Button();
            this.OpenFileDIAG = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDIAG = new System.Windows.Forms.SaveFileDialog();
            this.SelectPayloadButton = new System.Windows.Forms.Button();
            this.PayloadLabel = new System.Windows.Forms.Label();
            this.PayloadText = new System.Windows.Forms.TextBox();
            this.PayloadDIAG = new System.Windows.Forms.OpenFileDialog();
            this.StartPathText = new System.Windows.Forms.TextBox();
            this.StartLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FilePathText
            // 
            this.FilePathText.Enabled = false;
            this.FilePathText.Location = new System.Drawing.Point(12, 156);
            this.FilePathText.Name = "FilePathText";
            this.FilePathText.Size = new System.Drawing.Size(211, 20);
            this.FilePathText.TabIndex = 0;
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::Pretentious.Properties.Resources.logo;
            this.LogoBox.Location = new System.Drawing.Point(12, 12);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(211, 122);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoBox.TabIndex = 1;
            this.LogoBox.TabStop = false;
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.ForeColor = System.Drawing.Color.White;
            this.FileLabel.Location = new System.Drawing.Point(12, 138);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(26, 13);
            this.FileLabel.TabIndex = 2;
            this.FileLabel.Text = "File:";
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.Color.Transparent;
            this.SelectButton.Location = new System.Drawing.Point(148, 186);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 23);
            this.SelectButton.TabIndex = 3;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // BindButton
            // 
            this.BindButton.BackColor = System.Drawing.Color.Transparent;
            this.BindButton.Location = new System.Drawing.Point(15, 314);
            this.BindButton.Name = "BindButton";
            this.BindButton.Size = new System.Drawing.Size(211, 23);
            this.BindButton.TabIndex = 4;
            this.BindButton.Text = "Bind";
            this.BindButton.UseVisualStyleBackColor = false;
            this.BindButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // SelectPayloadButton
            // 
            this.SelectPayloadButton.BackColor = System.Drawing.Color.Transparent;
            this.SelectPayloadButton.Location = new System.Drawing.Point(148, 247);
            this.SelectPayloadButton.Name = "SelectPayloadButton";
            this.SelectPayloadButton.Size = new System.Drawing.Size(75, 23);
            this.SelectPayloadButton.TabIndex = 7;
            this.SelectPayloadButton.Text = "Select";
            this.SelectPayloadButton.UseVisualStyleBackColor = false;
            this.SelectPayloadButton.Click += new System.EventHandler(this.SelectPayloadButton_Click);
            // 
            // PayloadLabel
            // 
            this.PayloadLabel.AutoSize = true;
            this.PayloadLabel.ForeColor = System.Drawing.Color.White;
            this.PayloadLabel.Location = new System.Drawing.Point(12, 199);
            this.PayloadLabel.Name = "PayloadLabel";
            this.PayloadLabel.Size = new System.Drawing.Size(48, 13);
            this.PayloadLabel.TabIndex = 6;
            this.PayloadLabel.Text = "Payload:";
            // 
            // PayloadText
            // 
            this.PayloadText.Enabled = false;
            this.PayloadText.Location = new System.Drawing.Point(12, 217);
            this.PayloadText.Name = "PayloadText";
            this.PayloadText.Size = new System.Drawing.Size(211, 20);
            this.PayloadText.TabIndex = 5;
            // 
            // StartPathText
            // 
            this.StartPathText.Location = new System.Drawing.Point(15, 284);
            this.StartPathText.Name = "StartPathText";
            this.StartPathText.Size = new System.Drawing.Size(211, 20);
            this.StartPathText.TabIndex = 8;
            this.StartPathText.Text = "{APPDATA}";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.ForeColor = System.Drawing.Color.White;
            this.StartLabel.Location = new System.Drawing.Point(12, 266);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(57, 13);
            this.StartLabel.TabIndex = 9;
            this.StartLabel.Text = "Start Path:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(235, 356);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.StartPathText);
            this.Controls.Add(this.SelectPayloadButton);
            this.Controls.Add(this.PayloadLabel);
            this.Controls.Add(this.PayloadText);
            this.Controls.Add(this.BindButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.FilePathText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretentious";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FilePathText;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button BindButton;
        private System.Windows.Forms.OpenFileDialog OpenFileDIAG;
        private System.Windows.Forms.SaveFileDialog SaveFileDIAG;
        private System.Windows.Forms.Button SelectPayloadButton;
        private System.Windows.Forms.Label PayloadLabel;
        private System.Windows.Forms.TextBox PayloadText;
        private System.Windows.Forms.OpenFileDialog PayloadDIAG;
        private System.Windows.Forms.TextBox StartPathText;
        private System.Windows.Forms.Label StartLabel;
    }
}

