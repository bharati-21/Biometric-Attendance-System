namespace CorporateCoders
{
    partial class FormNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewUser));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBoxLogo2 = new System.Windows.Forms.PictureBox();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblHead = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // pictureBoxLogo2
            // 
            this.pictureBoxLogo2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxLogo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo2.Image")));
            this.pictureBoxLogo2.Location = new System.Drawing.Point(385, 14);
            this.pictureBoxLogo2.Name = "pictureBoxLogo2";
            this.pictureBoxLogo2.Size = new System.Drawing.Size(380, 205);
            this.pictureBoxLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo2.TabIndex = 51;
            this.pictureBoxLogo2.TabStop = false;
            // 
            // btnEnroll
            // 
            this.btnEnroll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.btnEnroll.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.ForeColor = System.Drawing.Color.White;
            this.btnEnroll.Location = new System.Drawing.Point(511, 377);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(167, 77);
            this.btnEnroll.TabIndex = 50;
            this.btnEnroll.Text = "ENROLL";
            this.btnEnroll.UseVisualStyleBackColor = false;
            this.btnEnroll.Click += new System.EventHandler(this.BtnEnroll_Click);
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // lblHead
            // 
            this.lblHead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.Maroon;
            this.lblHead.Location = new System.Drawing.Point(309, 301);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(534, 37);
            this.lblHead.TabIndex = 54;
            this.lblHead.Text = "Click the button to enroll fingerprint";
            // 
            // FormNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1169, 754);
            this.Controls.Add(this.pictureBoxLogo2);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.lblHead);
            this.Name = "FormNewUser";
            this.Text = "New User";
            this.Load += new System.EventHandler(this.FormNewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBoxLogo2;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.Label lblHead;
    }
}