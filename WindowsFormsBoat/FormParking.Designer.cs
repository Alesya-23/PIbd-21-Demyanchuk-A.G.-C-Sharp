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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParcing)).BeginInit();
            this.groupBoxForPickUp.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParcing
            // 
            this.pictureBoxParcing.Location = new System.Drawing.Point(-1, 39);
            this.pictureBoxParcing.Name = "pictureBoxParcing";
            this.pictureBoxParcing.Size = new System.Drawing.Size(735, 520);
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
            this.listBoxParkings.Location = new System.Drawing.Point(773, 136);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(139, 84);
            this.listBoxParkings.TabIndex = 4;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // btnDeleteParking
            // 
            this.btnDeleteParking.Location = new System.Drawing.Point(761, 230);
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
            this.lblParking.Location = new System.Drawing.Point(769, 39);
            this.lblParking.Name = "lblParking";
            this.lblParking.Size = new System.Drawing.Size(86, 20);
            this.lblParking.TabIndex = 6;
            this.lblParking.Text = "Парковки:";
            // 
            // maskedTextBoxParking
            // 
            this.maskedTextBoxParking.Location = new System.Drawing.Point(773, 66);
            this.maskedTextBoxParking.Name = "maskedTextBoxParking";
            this.maskedTextBoxParking.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBoxParking.TabIndex = 7;
            // 
            // btnAddParking
            // 
            this.btnAddParking.Location = new System.Drawing.Point(756, 98);
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
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "«txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "«txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(773, 356);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(139, 49);
            this.buttonSort.TabIndex = 11;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 599);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonAddBoats);
            this.Controls.Add(this.btnAddParking);
            this.Controls.Add(this.maskedTextBoxParking);
            this.Controls.Add(this.lblParking);
            this.Controls.Add(this.btnDeleteParking);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.groupBoxForPickUp);
            this.Controls.Add(this.pictureBoxParcing);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParcing)).EndInit();
            this.groupBoxForPickUp.ResumeLayout(false);
            this.groupBoxForPickUp.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxParcing;
        private System.Windows.Forms.GroupBox groupBoxForPickUp;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelNumberSpaceForBoat;
        private System.Windows.Forms.Button btnPickUp;
        private ListBox listBoxParkings;
        private Button btnDeleteParking;
        private Label lblParking;
        private MaskedTextBox maskedTextBoxParking;
        private Button btnAddParking;
        private Button buttonAddBoats;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private Button buttonSort;
    }
}
