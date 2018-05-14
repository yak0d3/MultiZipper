namespace MultiZipper
{
    partial class multizipper_form
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
            this.statLabel = new System.Windows.Forms.Label();
            this.browseBtn1 = new System.Windows.Forms.Button();
            this.browseBtn2 = new System.Windows.Forms.Button();
            this.maindirLabel = new System.Windows.Forms.Label();
            this.outputsLabel = new System.Windows.Forms.Label();
            this.extensionLabel = new System.Windows.Forms.Label();
            this.extBox = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statLabel
            // 
            this.statLabel.AutoSize = true;
            this.statLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.statLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.statLabel.Location = new System.Drawing.Point(12, 244);
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(35, 20);
            this.statLabel.TabIndex = 0;
            this.statLabel.Text = "Idle";
            // 
            // browseBtn1
            // 
            this.browseBtn1.Location = new System.Drawing.Point(11, 41);
            this.browseBtn1.Name = "browseBtn1";
            this.browseBtn1.Size = new System.Drawing.Size(146, 23);
            this.browseBtn1.TabIndex = 1;
            this.browseBtn1.Text = "BROWSE";
            this.browseBtn1.UseVisualStyleBackColor = true;
            this.browseBtn1.Click += new System.EventHandler(this.browseBtn1_Click);
            // 
            // browseBtn2
            // 
            this.browseBtn2.Location = new System.Drawing.Point(10, 93);
            this.browseBtn2.Name = "browseBtn2";
            this.browseBtn2.Size = new System.Drawing.Size(146, 23);
            this.browseBtn2.TabIndex = 2;
            this.browseBtn2.Text = "BROWSE";
            this.browseBtn2.UseVisualStyleBackColor = true;
            this.browseBtn2.Click += new System.EventHandler(this.browseBtn2_Click);
            // 
            // maindirLabel
            // 
            this.maindirLabel.AutoSize = true;
            this.maindirLabel.Location = new System.Drawing.Point(12, 20);
            this.maindirLabel.Name = "maindirLabel";
            this.maindirLabel.Size = new System.Drawing.Size(78, 13);
            this.maindirLabel.TabIndex = 3;
            this.maindirLabel.Text = "Main Directory:";
            // 
            // outputsLabel
            // 
            this.outputsLabel.AutoSize = true;
            this.outputsLabel.Location = new System.Drawing.Point(11, 72);
            this.outputsLabel.Name = "outputsLabel";
            this.outputsLabel.Size = new System.Drawing.Size(92, 13);
            this.outputsLabel.TabIndex = 4;
            this.outputsLabel.Text = "Outputs Directory:";
            // 
            // extensionLabel
            // 
            this.extensionLabel.AutoSize = true;
            this.extensionLabel.Location = new System.Drawing.Point(11, 124);
            this.extensionLabel.Name = "extensionLabel";
            this.extensionLabel.Size = new System.Drawing.Size(105, 13);
            this.extensionLabel.TabIndex = 5;
            this.extensionLabel.Text = "Extension (optional): ";
            // 
            // extBox
            // 
            this.extBox.Location = new System.Drawing.Point(14, 145);
            this.extBox.Name = "extBox";
            this.extBox.Size = new System.Drawing.Size(143, 20);
            this.extBox.TabIndex = 6;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(13, 176);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(144, 23);
            this.startBtn.TabIndex = 7;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(13, 205);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(144, 23);
            this.stopBtn.TabIndex = 8;
            this.stopBtn.Text = "STOP";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // multizipper_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 311);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.extBox);
            this.Controls.Add(this.extensionLabel);
            this.Controls.Add(this.outputsLabel);
            this.Controls.Add(this.maindirLabel);
            this.Controls.Add(this.browseBtn2);
            this.Controls.Add(this.browseBtn1);
            this.Controls.Add(this.statLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "multizipper_form";
            this.Text = "MultiZipper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statLabel;
        private System.Windows.Forms.Button browseBtn1;
        private System.Windows.Forms.Button browseBtn2;
        private System.Windows.Forms.Label maindirLabel;
        private System.Windows.Forms.Label outputsLabel;
        private System.Windows.Forms.Label extensionLabel;
        private System.Windows.Forms.TextBox extBox;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
    }
}

