namespace WindowsFormsBoat
{
    partial class FormBoat
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoat));
            this.pictureBoat = new System.Windows.Forms.PictureBox();
            this.btUp = new System.Windows.Forms.Button();
            this.btLeft = new System.Windows.Forms.Button();
            this.btRigth = new System.Windows.Forms.Button();
            this.btDown = new System.Windows.Forms.Button();
            this.buttonCreateBoat = new System.Windows.Forms.Button();
            this.buttonCreateMotorBoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoat)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoat
            // 
            this.pictureBoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoat.Location = new System.Drawing.Point(0, 0);
            this.pictureBoat.Name = "pictureBoat";
            this.pictureBoat.Size = new System.Drawing.Size(878, 444);
            this.pictureBoat.TabIndex = 0;
            this.pictureBoat.TabStop = false;
            this.pictureBoat.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // btUp
            // 
            this.btUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btUp.BackgroundImage")));
            this.btUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btUp.Location = new System.Drawing.Point(724, 342);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(66, 42);
            this.btUp.TabIndex = 1;
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // btLeft
            // 
            this.btLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btLeft.BackgroundImage")));
            this.btLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btLeft.Location = new System.Drawing.Point(652, 390);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(66, 42);
            this.btLeft.TabIndex = 2;
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // btRigth
            // 
            this.btRigth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRigth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRigth.BackgroundImage")));
            this.btRigth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRigth.Location = new System.Drawing.Point(796, 390);
            this.btRigth.Name = "btRigth";
            this.btRigth.Size = new System.Drawing.Size(66, 42);
            this.btRigth.TabIndex = 3;
            this.btRigth.UseVisualStyleBackColor = true;
            this.btRigth.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // btDown
            // 
            this.btDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDown.BackgroundImage")));
            this.btDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDown.Location = new System.Drawing.Point(724, 390);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(66, 42);
            this.btDown.TabIndex = 4;
            this.btDown.UseVisualStyleBackColor = true;
            this.btDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateBoat
            // 
            this.buttonCreateBoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateBoat.Location = new System.Drawing.Point(32, 12);
            this.buttonCreateBoat.Name = "buttonCreateBoat";
            this.buttonCreateBoat.Size = new System.Drawing.Size(127, 47);
            this.buttonCreateBoat.TabIndex = 5;
            this.buttonCreateBoat.Text = "Create Boat";
            this.buttonCreateBoat.UseVisualStyleBackColor = true;
            this.buttonCreateBoat.Click += new System.EventHandler(this.buttonCreatBoat_Click);
            // 
            // buttonCreateMotorBoat
            // 
            this.buttonCreateMotorBoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateMotorBoat.Location = new System.Drawing.Point(165, 12);
            this.buttonCreateMotorBoat.Name = "buttonCreateMotorBoat";
            this.buttonCreateMotorBoat.Size = new System.Drawing.Size(176, 47);
            this.buttonCreateMotorBoat.TabIndex = 6;
            this.buttonCreateMotorBoat.Text = "Create MotorBoat";
            this.buttonCreateMotorBoat.UseVisualStyleBackColor = true;
            this.buttonCreateMotorBoat.Click += new System.EventHandler(this.createMotorBoat_Click);
            // 
            // FormBoat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(878, 444);
            this.Controls.Add(this.buttonCreateMotorBoat);
            this.Controls.Add(this.buttonCreateBoat);
            this.Controls.Add(this.btDown);
            this.Controls.Add(this.btRigth);
            this.Controls.Add(this.btLeft);
            this.Controls.Add(this.btUp);
            this.Controls.Add(this.pictureBoat);
            this.Name = "FormBoat";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoat;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btRigth;
        private System.Windows.Forms.Button btDown;
        private System.Windows.Forms.Button buttonCreateBoat;
        private System.Windows.Forms.Button buttonCreateMotorBoat;
    }
}
