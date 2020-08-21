namespace CorporateCoders
{
    partial class GiveAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiveAttendance));
            this.pictureBoxLogo2 = new System.Windows.Forms.PictureBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo2
            // 
            this.pictureBoxLogo2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxLogo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo2.Image")));
            this.pictureBoxLogo2.Location = new System.Drawing.Point(391, 19);
            this.pictureBoxLogo2.Name = "pictureBoxLogo2";
            this.pictureBoxLogo2.Size = new System.Drawing.Size(380, 205);
            this.pictureBoxLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo2.TabIndex = 44;
            this.pictureBoxLogo2.TabStop = false;
            // 
            // lblHead
            // 
            this.lblHead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.Maroon;
            this.lblHead.Location = new System.Drawing.Point(255, 324);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(652, 37);
            this.lblHead.TabIndex = 45;
            this.lblHead.Text = "CLICK BUTTON TO GIVE ATTENDANCE";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(40)))));
            this.btnStart.Location = new System.Drawing.Point(512, 398);
            this.btnStart.Margin = new System.Windows.Forms.Padding(10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(142, 51);
            this.btnStart.TabIndex = 46;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // GiveAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1162, 751);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.pictureBoxLogo2);
            this.Name = "GiveAttendance";
            this.Text = "Give Attendance (Verify)";
            this.Load += new System.EventHandler(this.GiveAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo2;
        private System.Windows.Forms.Label lblHead;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnStart;
    }
}