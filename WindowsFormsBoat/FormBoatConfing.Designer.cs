namespace WindowsFormsBoat
{
    partial class FormBoatConfig
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
            this.labelMaxSpeedBoat = new System.Windows.Forms.Label();
            this.groupBoxParametrs = new System.Windows.Forms.GroupBox();
            this.checkBoxCabin = new System.Windows.Forms.CheckBox();
            this.checkBoxMotors = new System.Windows.Forms.CheckBox();
            this.checkBoxLines = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeightBoat = new System.Windows.Forms.Label();
            this.groupBoxBoat = new System.Windows.Forms.GroupBox();
            this.labelMotorBoat = new System.Windows.Forms.Label();
            this.labelBoat = new System.Windows.Forms.Label();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelMediumBlue = new System.Windows.Forms.Panel();
            this.panelFicuse = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelTurquoise = new System.Windows.Forms.Panel();
            this.panelLime = new System.Windows.Forms.Panel();
            this.panelCoral = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.buttonAddBoat = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelBoat = new System.Windows.Forms.Panel();
            this.pictureBoxBoat = new System.Windows.Forms.PictureBox();
            this.groupBoxParametrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.groupBoxBoat.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.panelBoat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMaxSpeedBoat
            // 
            this.labelMaxSpeedBoat.Location = new System.Drawing.Point(32, 39);
            this.labelMaxSpeedBoat.Name = "labelMaxSpeedBoat";
            this.labelMaxSpeedBoat.Size = new System.Drawing.Size(133, 22);
            this.labelMaxSpeedBoat.TabIndex = 0;
            this.labelMaxSpeedBoat.Text = "Макс. скорость";
            // 
            // groupBoxParametrs
            // 
            this.groupBoxParametrs.Controls.Add(this.checkBoxCabin);
            this.groupBoxParametrs.Controls.Add(this.checkBoxMotors);
            this.groupBoxParametrs.Controls.Add(this.checkBoxLines);
            this.groupBoxParametrs.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParametrs.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxParametrs.Controls.Add(this.labelWeightBoat);
            this.groupBoxParametrs.Controls.Add(this.labelMaxSpeedBoat);
            this.groupBoxParametrs.Location = new System.Drawing.Point(12, 281);
            this.groupBoxParametrs.Name = "groupBoxParametrs";
            this.groupBoxParametrs.Size = new System.Drawing.Size(548, 157);
            this.groupBoxParametrs.TabIndex = 1;
            this.groupBoxParametrs.TabStop = false;
            this.groupBoxParametrs.Text = "groupBox1";
            // 
            // checkBoxCabin
            // 
            this.checkBoxCabin.AutoSize = true;
            this.checkBoxCabin.Location = new System.Drawing.Point(383, 81);
            this.checkBoxCabin.Name = "checkBoxCabin";
            this.checkBoxCabin.Size = new System.Drawing.Size(90, 24);
            this.checkBoxCabin.TabIndex = 6;
            this.checkBoxCabin.Text = "Кабина";
            this.checkBoxCabin.UseVisualStyleBackColor = true;
            // 
            // checkBoxMotors
            // 
            this.checkBoxMotors.AutoSize = true;
            this.checkBoxMotors.Location = new System.Drawing.Point(383, 135);
            this.checkBoxMotors.Name = "checkBoxMotors";
            this.checkBoxMotors.Size = new System.Drawing.Size(95, 24);
            this.checkBoxMotors.TabIndex = 5;
            this.checkBoxMotors.Text = "Моторы";
            this.checkBoxMotors.UseVisualStyleBackColor = true;
            // 
            // checkBoxLines
            // 
            this.checkBoxLines.AutoSize = true;
            this.checkBoxLines.Location = new System.Drawing.Point(383, 37);
            this.checkBoxLines.Name = "checkBoxLines";
            this.checkBoxLines.Size = new System.Drawing.Size(83, 24);
            this.checkBoxLines.TabIndex = 4;
            this.checkBoxLines.Text = "Линии";
            this.checkBoxLines.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(201, 124);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(201, 39);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownSpeed.TabIndex = 2;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeightBoat
            // 
            this.labelWeightBoat.Location = new System.Drawing.Point(32, 119);
            this.labelWeightBoat.Name = "labelWeightBoat";
            this.labelWeightBoat.Size = new System.Drawing.Size(122, 31);
            this.labelWeightBoat.TabIndex = 1;
            this.labelWeightBoat.Text = "Вес лодки";
            // 
            // groupBoxBoat
            // 
            this.groupBoxBoat.Controls.Add(this.labelMotorBoat);
            this.groupBoxBoat.Controls.Add(this.labelBoat);
            this.groupBoxBoat.Location = new System.Drawing.Point(22, 25);
            this.groupBoxBoat.Name = "groupBoxBoat";
            this.groupBoxBoat.Size = new System.Drawing.Size(223, 224);
            this.groupBoxBoat.TabIndex = 2;
            this.groupBoxBoat.TabStop = false;
            this.groupBoxBoat.Text = "Тип лодки";
            // 
            // labelMotorBoat
            // 
            this.labelMotorBoat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMotorBoat.Location = new System.Drawing.Point(26, 127);
            this.labelMotorBoat.Name = "labelMotorBoat";
            this.labelMotorBoat.Size = new System.Drawing.Size(167, 46);
            this.labelMotorBoat.TabIndex = 1;
            this.labelMotorBoat.Text = "Моторная лодка";
            this.labelMotorBoat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelMotorBoat_MouseDown);
            // 
            // labelBoat
            // 
            this.labelBoat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBoat.Location = new System.Drawing.Point(26, 39);
            this.labelBoat.Name = "labelBoat";
            this.labelBoat.Size = new System.Drawing.Size(167, 47);
            this.labelBoat.TabIndex = 0;
            this.labelBoat.Text = "Лодка";
            this.labelBoat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBoat_MouseDown);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelMediumBlue);
            this.groupBoxColors.Controls.Add(this.panelFicuse);
            this.groupBoxColors.Controls.Add(this.panelPink);
            this.groupBoxColors.Controls.Add(this.panelTurquoise);
            this.groupBoxColors.Controls.Add(this.panelLime);
            this.groupBoxColors.Controls.Add(this.panelCoral);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Location = new System.Drawing.Point(581, 12);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(339, 250);
            this.groupBoxColors.TabIndex = 3;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(195, 22);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(144, 20);
            this.labelDopColor.TabIndex = 3;
            this.labelDopColor.Text = "Дополнительный ";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(6, 22);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(118, 20);
            this.labelMainColor.TabIndex = 2;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(104, 140);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(41, 38);
            this.panelYellow.TabIndex = 1;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelMediumBlue
            // 
            this.panelMediumBlue.BackColor = System.Drawing.Color.MediumBlue;
            this.panelMediumBlue.Location = new System.Drawing.Point(18, 140);
            this.panelMediumBlue.Name = "panelMediumBlue";
            this.panelMediumBlue.Size = new System.Drawing.Size(41, 38);
            this.panelMediumBlue.TabIndex = 1;
            this.panelMediumBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelFicuse
            // 
            this.panelFicuse.BackColor = System.Drawing.Color.DarkViolet;
            this.panelFicuse.Location = new System.Drawing.Point(195, 140);
            this.panelFicuse.Name = "panelFicuse";
            this.panelFicuse.Size = new System.Drawing.Size(41, 38);
            this.panelFicuse.TabIndex = 1;
            this.panelFicuse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.HotPink;
            this.panelPink.Location = new System.Drawing.Point(195, 52);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(41, 38);
            this.panelPink.TabIndex = 1;
            this.panelPink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelTurquoise
            // 
            this.panelTurquoise.BackColor = System.Drawing.Color.Turquoise;
            this.panelTurquoise.Location = new System.Drawing.Point(272, 140);
            this.panelTurquoise.Name = "panelTurquoise";
            this.panelTurquoise.Size = new System.Drawing.Size(41, 38);
            this.panelTurquoise.TabIndex = 1;
            this.panelTurquoise.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelLime
            // 
            this.panelLime.BackColor = System.Drawing.Color.Lime;
            this.panelLime.Location = new System.Drawing.Point(104, 52);
            this.panelLime.Name = "panelLime";
            this.panelLime.Size = new System.Drawing.Size(41, 38);
            this.panelLime.TabIndex = 1;
            // 
            // panelCoral
            // 
            this.panelCoral.BackColor = System.Drawing.Color.Coral;
            this.panelCoral.Location = new System.Drawing.Point(272, 52);
            this.panelCoral.Name = "panelCoral";
            this.panelCoral.Size = new System.Drawing.Size(41, 38);
            this.panelCoral.TabIndex = 1;
            this.panelCoral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(18, 52);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(41, 38);
            this.panelRed.TabIndex = 0;
            // 
            // buttonAddBoat
            // 
            this.buttonAddBoat.Location = new System.Drawing.Point(627, 299);
            this.buttonAddBoat.Name = "buttonAddBoat";
            this.buttonAddBoat.Size = new System.Drawing.Size(162, 43);
            this.buttonAddBoat.TabIndex = 4;
            this.buttonAddBoat.Text = "Добавить";
            this.buttonAddBoat.UseVisualStyleBackColor = true;
            this.buttonAddBoat.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(627, 388);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(162, 43);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // panelBoat
            // 
            this.panelBoat.AllowDrop = true;
            this.panelBoat.Controls.Add(this.pictureBoxBoat);
            this.panelBoat.Location = new System.Drawing.Point(251, -1);
            this.panelBoat.Name = "panelBoat";
            this.panelBoat.Size = new System.Drawing.Size(324, 276);
            this.panelBoat.TabIndex = 6;
            this.panelBoat.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelBoat_DragDrop);
            this.panelBoat.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelBoat_DragEnter);
            // 
            // pictureBoxBoat
            // 
            this.pictureBoxBoat.Location = new System.Drawing.Point(19, 14);
            this.pictureBoxBoat.Name = "pictureBoxBoat";
            this.pictureBoxBoat.Size = new System.Drawing.Size(280, 236);
            this.pictureBoxBoat.TabIndex = 0;
            this.pictureBoxBoat.TabStop = false;
            // 
            // FormBoatConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Controls.Add(this.panelBoat);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddBoat);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.groupBoxBoat);
            this.Controls.Add(this.groupBoxParametrs);
            this.Name = "FormBoatConfig";
            this.Text = "FormBoatConfing";
            this.groupBoxParametrs.ResumeLayout(false);
            this.groupBoxParametrs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.groupBoxBoat.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.panelBoat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxParametrs;
        private System.Windows.Forms.CheckBox checkBoxCabin;
        private System.Windows.Forms.CheckBox checkBoxMotors;
        private System.Windows.Forms.CheckBox checkBoxLines;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label labelWeightBoat;
        private System.Windows.Forms.GroupBox groupBoxBoat;
        private System.Windows.Forms.Label labelMotorBoat;
        private System.Windows.Forms.Label labelBoat;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelMediumBlue;
        private System.Windows.Forms.Panel panelFicuse;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelTurquoise;
        private System.Windows.Forms.Panel panelLime;
        private System.Windows.Forms.Panel panelCoral;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Button buttonAddBoat;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelBoat;
        private System.Windows.Forms.PictureBox pictureBoxBoat;
        private System.Windows.Forms.Label labelMaxSpeedBoat;
    }
}
