using System.Windows.Forms;

namespace WindowsFormsBoat
{
    partial class FormParking
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
            this.btnParkingBoat = new System.Windows.Forms.Button();
            this.btnParkingMotorBoat = new System.Windows.Forms.Button();
            this.pictureBoxParcing = new System.Windows.Forms.PictureBox();
            this.groupBoxForPickUp = new System.Windows.Forms.GroupBox();
            this.btnPickUp = new System.Windows.Forms.Button();
            this.labelNumberSpaceForBoat = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParcing)).BeginInit();
            this.groupBoxForPickUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnParkingBoat
            // 
            this.btnParkingBoat.Location = new System.Drawing.Point(763, 12);
            this.btnParkingBoat.Name = "btnParkingBoat";
            this.btnParkingBoat.Size = new System.Drawing.Size(139, 68);
            this.btnParkingBoat.TabIndex = 0;
            this.btnParkingBoat.Text = "Припарковать лодку";
            this.btnParkingBoat.UseVisualStyleBackColor = true;
            this.btnParkingBoat.Click += new System.EventHandler(this.buttonSetBoat_Click);
            // 
            // btnParkingMotorBoat
            // 
            this.btnParkingMotorBoat.Location = new System.Drawing.Point(763, 86);
            this.btnParkingMotorBoat.Name = "btnParkingMotorBoat";
            this.btnParkingMotorBoat.Size = new System.Drawing.Size(139, 63);
            this.btnParkingMotorBoat.TabIndex = 1;
            this.btnParkingMotorBoat.Text = "Припарковать катер";
            this.btnParkingMotorBoat.UseVisualStyleBackColor = true;
            this.btnParkingMotorBoat.Click += new System.EventHandler(this.buttonSetMotorBoat_Click);
            // 
            // pictureBoxParcing
            // 
            this.pictureBoxParcing.Location = new System.Drawing.Point(1, 0);
            this.pictureBoxParcing.Name = "pictureBoxParcing";
            this.pictureBoxParcing.Size = new System.Drawing.Size(733, 559);
            this.pictureBoxParcing.TabIndex = 2;
            this.pictureBoxParcing.TabStop = false;
            // 
            // groupBoxForPickUp
            // 
            this.groupBoxForPickUp.Controls.Add(this.btnPickUp);
            this.groupBoxForPickUp.Controls.Add(this.labelNumberSpaceForBoat);
            this.groupBoxForPickUp.Controls.Add(this.maskedTextBox);
            this.groupBoxForPickUp.Location = new System.Drawing.Point(763, 184);
            this.groupBoxForPickUp.Name = "groupBoxForPickUp";
            this.groupBoxForPickUp.Size = new System.Drawing.Size(139, 101);
            this.groupBoxForPickUp.TabIndex = 3;
            this.groupBoxForPickUp.TabStop = false;
            this.groupBoxForPickUp.Text = "Забрать лодку";
            // 
            // btnPickUp
            // 
            this.btnPickUp.Location = new System.Drawing.Point(31, 72);
            this.btnPickUp.Name = "btnPickUp";
            this.btnPickUp.Size = new System.Drawing.Size(90, 29);
            this.btnPickUp.TabIndex = 2;
            this.btnPickUp.Text = "Забрать";
            this.btnPickUp.UseVisualStyleBackColor = true;
            this.btnPickUp.Click += new System.EventHandler(this.buttonTakeBoat_Click);
            // 
            // labelNumberSpaceForBoat
            // 
            this.labelNumberSpaceForBoat.AutoSize = true;
            this.labelNumberSpaceForBoat.Location = new System.Drawing.Point(17, 28);
            this.labelNumberSpaceForBoat.Name = "labelNumberSpaceForBoat";
            this.labelNumberSpaceForBoat.Size = new System.Drawing.Size(65, 20);
            this.labelNumberSpaceForBoat.TabIndex = 1;
            this.labelNumberSpaceForBoat.Text = "Место: ";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(92, 25);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(41, 26);
            this.maskedTextBox.TabIndex = 0;
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 558);
            this.Controls.Add(this.groupBoxForPickUp);
            this.Controls.Add(this.pictureBoxParcing);
            this.Controls.Add(this.btnParkingMotorBoat);
            this.Controls.Add(this.btnParkingBoat);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParcing)).EndInit();
            this.groupBoxForPickUp.ResumeLayout(false);
            this.groupBoxForPickUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnParkingBoat;
        private System.Windows.Forms.Button btnParkingMotorBoat;
        private System.Windows.Forms.PictureBox pictureBoxParcing;
        private System.Windows.Forms.GroupBox groupBoxForPickUp;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelNumberSpaceForBoat;
        private System.Windows.Forms.Button btnPickUp;
        private MaskInputRejectedEventHandler maskedTextBox_MaskInputRejected;
    }
}