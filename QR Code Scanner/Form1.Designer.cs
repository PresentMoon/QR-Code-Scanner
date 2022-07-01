namespace QR_Code_Scanner
{
    partial class QRCode
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CameraBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScannerBox = new System.Windows.Forms.PictureBox();
            this.strbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DecodeBox = new System.Windows.Forms.RichTextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScannerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CameraBox
            // 
            this.CameraBox.FormattingEnabled = true;
            this.CameraBox.Location = new System.Drawing.Point(124, 40);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(291, 23);
            this.CameraBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Camera";
            // 
            // ScannerBox
            // 
            this.ScannerBox.Location = new System.Drawing.Point(70, 88);
            this.ScannerBox.Name = "ScannerBox";
            this.ScannerBox.Size = new System.Drawing.Size(345, 269);
            this.ScannerBox.TabIndex = 2;
            this.ScannerBox.TabStop = false;
            // 
            // strbtn
            // 
            this.strbtn.Location = new System.Drawing.Point(433, 88);
            this.strbtn.Name = "strbtn";
            this.strbtn.Size = new System.Drawing.Size(96, 23);
            this.strbtn.TabIndex = 3;
            this.strbtn.Text = "Start";
            this.strbtn.UseVisualStyleBackColor = true;
            this.strbtn.Click += new System.EventHandler(this.strbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DecodeBox
            // 
            this.DecodeBox.Location = new System.Drawing.Point(433, 128);
            this.DecodeBox.Name = "DecodeBox";
            this.DecodeBox.Size = new System.Drawing.Size(333, 122);
            this.DecodeBox.TabIndex = 4;
            this.DecodeBox.Text = "";
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(559, 271);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 5;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // QRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.DecodeBox);
            this.Controls.Add(this.strbtn);
            this.Controls.Add(this.ScannerBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CameraBox);
            this.Name = "QRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRCode_FormClosing);
            this.Load += new System.EventHandler(this.QRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScannerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox CameraBox;
        private Label label1;
        private PictureBox ScannerBox;
        private Button strbtn;
        private System.Windows.Forms.Timer timer1;
        private RichTextBox DecodeBox;
        private Button Savebtn;
    }
}