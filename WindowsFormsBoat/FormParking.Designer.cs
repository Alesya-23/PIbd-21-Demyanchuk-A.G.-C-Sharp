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
            this.pictureBoxParcing = new System.Windows.Forms.PictureBox();
            this.groupBoxForPickUp = new System.Windows.Forms.GroupBox();
            this.btnPickUp = new System.Windows.Forms.Button();
            this.labelNumberSpaceForBoat = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.btnDeleteParking = new System.Windows.Forms.Button();
            this.lblParking = new System.Windows.Forms.Label();
            this.maskedTextBoxParking = new System.Windows.Forms.MaskedTextBox();
            this.btnAddParking = new System.Windows.Forms.Button();
            this.buttonAddBoats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParcing)).BeginInit();
            this.groupBoxForPickUp.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBoxForPickUp.Location = new System.Drawing.Point(772, 424);
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
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.ItemHeight = 20;
            this.listBoxParkings.Location = new System.Drawing.Point(772, 98);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(139, 84);
            this.listBoxParkings.TabIndex = 4;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // btnDeleteParking
            // 
            this.btnDeleteParking.Location = new System.Drawing.Point(761, 188);
            this.btnDeleteParking.Name = "btnDeleteParking";
            this.btnDeleteParking.Size = new System.Drawing.Size(160, 32);
            this.btnDeleteParking.TabIndex = 5;
            this.btnDeleteParking.Text = "Удалить парковку";
            this.btnDeleteParking.UseVisualStyleBackColor = true;
            this.btnDeleteParking.Click += new System.EventHandler(this.buttonDelParking_Click);
            // 
            // lblParking
            // 
            this.lblParking.AutoSize = true;
            this.lblParking.Location = new System.Drawing.Point(768, 9);
            this.lblParking.Name = "lblParking";
            this.lblParking.Size = new System.Drawing.Size(86, 20);
            this.lblParking.TabIndex = 6;
            this.lblParking.Text = "Парковки:";
            // 
            // maskedTextBoxParking
            // 
            this.maskedTextBoxParking.Location = new System.Drawing.Point(772, 32);
            this.maskedTextBoxParking.Name = "maskedTextBoxParking";
            this.maskedTextBoxParking.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBoxParking.TabIndex = 7;
            // 
            // btnAddParking
            // 
            this.btnAddParking.Location = new System.Drawing.Point(761, 64);
            this.btnAddParking.Name = "btnAddParking";
            this.btnAddParking.Size = new System.Drawing.Size(160, 32);
            this.btnAddParking.TabIndex = 8;
            this.btnAddParking.Text = "Добавить парковку";
            this.btnAddParking.UseVisualStyleBackColor = true;
            this.btnAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // buttonAddBoats
            // 
            this.buttonAddBoats.AutoSize = true;
            this.buttonAddBoats.Location = new System.Drawing.Point(773, 268);
            this.buttonAddBoats.Name = "buttonAddBoats";
            this.buttonAddBoats.Size = new System.Drawing.Size(143, 68);
            this.buttonAddBoats.TabIndex = 9;
            this.buttonAddBoats.Text = "Добавить лодку";
            this.buttonAddBoats.UseVisualStyleBackColor = true;
            this.buttonAddBoats.Click += new System.EventHandler(this.buttonAddBoat);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 558);
            this.Controls.Add(this.buttonAddBoats);
            this.Controls.Add(this.btnAddParking);
            this.Controls.Add(this.maskedTextBoxParking);
            this.Controls.Add(this.lblParking);
            this.Controls.Add(this.btnDeleteParking);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.groupBoxForPickUp);
            this.Controls.Add(this.pictureBoxParcing);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParcing)).EndInit();
            this.groupBoxForPickUp.ResumeLayout(false);
            this.groupBoxForPickUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxParcing;
        private System.Windows.Forms.GroupBox groupBoxForPickUp;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelNumberSpaceForBoat;
        private System.Windows.Forms.Button btnPickUp;
        private MaskInputRejectedEventHandler maskedTextBox_MaskInputRejected;
        private ListBox listBoxParkings;
        private Button btnDeleteParking;
        private Label lblParking;
        private MaskedTextBox maskedTextBoxParking;
        private Button btnAddParking;
        private Button buttonAddBoats;
    }
}