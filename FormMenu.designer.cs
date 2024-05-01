namespace Dota3InARow
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.pictureBoxBackGround = new System.Windows.Forms.PictureBox();
            this.radioButtonVeryHigh = new System.Windows.Forms.RadioButton();
            this.radioButtonHigh = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.pictureBoxSkullBreaker = new System.Windows.Forms.PictureBox();
            this.pictureBoxStartGame = new System.Windows.Forms.PictureBox();
            this.pictureBoxRecords = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkullBreaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBackGround
            // 
            this.pictureBoxBackGround.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackGround.Image")));
            this.pictureBoxBackGround.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackGround.Name = "pictureBoxBackGround";
            this.pictureBoxBackGround.Size = new System.Drawing.Size(1386, 790);
            this.pictureBoxBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackGround.TabIndex = 2;
            this.pictureBoxBackGround.TabStop = false;
            // 
            // radioButtonVeryHigh
            // 
            this.radioButtonVeryHigh.AutoSize = true;
            this.radioButtonVeryHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonVeryHigh.Location = new System.Drawing.Point(609, 364);
            this.radioButtonVeryHigh.Name = "radioButtonVeryHigh";
            this.radioButtonVeryHigh.Size = new System.Drawing.Size(252, 43);
            this.radioButtonVeryHigh.TabIndex = 95;
            this.radioButtonVeryHigh.TabStop = true;
            this.radioButtonVeryHigh.Text = "Very High skill";
            this.radioButtonVeryHigh.UseVisualStyleBackColor = true;
            // 
            // radioButtonHigh
            // 
            this.radioButtonHigh.AutoSize = true;
            this.radioButtonHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonHigh.Location = new System.Drawing.Point(609, 306);
            this.radioButtonHigh.Name = "radioButtonHigh";
            this.radioButtonHigh.Size = new System.Drawing.Size(173, 43);
            this.radioButtonHigh.TabIndex = 94;
            this.radioButtonHigh.TabStop = true;
            this.radioButtonHigh.Text = "High skill";
            this.radioButtonHigh.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonNormal.Location = new System.Drawing.Point(609, 247);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(212, 43);
            this.radioButtonNormal.TabIndex = 93;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normal skill";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // pictureBoxSkullBreaker
            // 
            this.pictureBoxSkullBreaker.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSkullBreaker.Image")));
            this.pictureBoxSkullBreaker.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSkullBreaker.InitialImage")));
            this.pictureBoxSkullBreaker.Location = new System.Drawing.Point(428, 138);
            this.pictureBoxSkullBreaker.Name = "pictureBoxSkullBreaker";
            this.pictureBoxSkullBreaker.Size = new System.Drawing.Size(606, 103);
            this.pictureBoxSkullBreaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSkullBreaker.TabIndex = 92;
            this.pictureBoxSkullBreaker.TabStop = false;
            // 
            // pictureBoxStartGame
            // 
            this.pictureBoxStartGame.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStartGame.Image")));
            this.pictureBoxStartGame.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxStartGame.InitialImage")));
            this.pictureBoxStartGame.Location = new System.Drawing.Point(428, 12);
            this.pictureBoxStartGame.Name = "pictureBoxStartGame";
            this.pictureBoxStartGame.Size = new System.Drawing.Size(606, 103);
            this.pictureBoxStartGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStartGame.TabIndex = 91;
            this.pictureBoxStartGame.TabStop = false;
            this.pictureBoxStartGame.Click += new System.EventHandler(this.pictureBoxStartGame_Click);
            // 
            // pictureBoxRecords
            // 
            this.pictureBoxRecords.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRecords.Image")));
            this.pictureBoxRecords.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRecords.InitialImage")));
            this.pictureBoxRecords.Location = new System.Drawing.Point(428, 413);
            this.pictureBoxRecords.Name = "pictureBoxRecords";
            this.pictureBoxRecords.Size = new System.Drawing.Size(606, 103);
            this.pictureBoxRecords.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRecords.TabIndex = 96;
            this.pictureBoxRecords.TabStop = false;
            this.pictureBoxRecords.Click += new System.EventHandler(this.pictureBoxRecords_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.InitialImage")));
            this.pictureBoxExit.Location = new System.Drawing.Point(428, 531);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(606, 103);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 97;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.pictureBoxRecords);
            this.Controls.Add(this.radioButtonVeryHigh);
            this.Controls.Add(this.radioButtonHigh);
            this.Controls.Add(this.radioButtonNormal);
            this.Controls.Add(this.pictureBoxSkullBreaker);
            this.Controls.Add(this.pictureBoxStartGame);
            this.Controls.Add(this.pictureBoxBackGround);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkullBreaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackGround;
        private System.Windows.Forms.RadioButton radioButtonVeryHigh;
        private System.Windows.Forms.RadioButton radioButtonHigh;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.PictureBox pictureBoxSkullBreaker;
        private System.Windows.Forms.PictureBox pictureBoxStartGame;
        private System.Windows.Forms.PictureBox pictureBoxRecords;
        private System.Windows.Forms.PictureBox pictureBoxExit;
    }
}

