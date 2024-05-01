namespace Dota3InARow
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.timerBombAnimation = new System.Windows.Forms.Timer(this.components);
            this.labelTimeToEnd = new System.Windows.Forms.Label();
            this.labelSheikerTo = new System.Windows.Forms.Label();
            this.labelSheikerFrom = new System.Windows.Forms.Label();
            this.labelVoidTo = new System.Windows.Forms.Label();
            this.labelVoidFrom = new System.Windows.Forms.Label();
            this.labelZevsTo = new System.Windows.Forms.Label();
            this.labelZevsFrom = new System.Windows.Forms.Label();
            this.labelVrkaTo = new System.Windows.Forms.Label();
            this.labelVrkaFrom = new System.Windows.Forms.Label();
            this.labelEnchaTo = new System.Windows.Forms.Label();
            this.labelEnchaFrom = new System.Windows.Forms.Label();
            this.labelTechisTo = new System.Windows.Forms.Label();
            this.labelTechisFrom = new System.Windows.Forms.Label();
            this.labelVengaTo = new System.Windows.Forms.Label();
            this.labelVengaFrom = new System.Windows.Forms.Label();
            this.pictureBoxSkillVoid = new System.Windows.Forms.PictureBox();
            this.pictureBoxSkillSheiker = new System.Windows.Forms.PictureBox();
            this.pictureBoxSkillEncha = new System.Windows.Forms.PictureBox();
            this.pictureBoxSkillZevs = new System.Windows.Forms.PictureBox();
            this.pictureBoxSkillVrka = new System.Windows.Forms.PictureBox();
            this.pictureBoxSkillVenga = new System.Windows.Forms.PictureBox();
            this.pictureBoxMix = new System.Windows.Forms.PictureBox();
            this.labelCountPoints = new System.Windows.Forms.Label();
            this.pictureBoxSkillTechis = new System.Windows.Forms.PictureBox();
            this.timerCountTime = new System.Windows.Forms.Timer(this.components);
            this.timerTimeToAppCountTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxBackGround = new System.Windows.Forms.PictureBox();
            this.timerEndMusic = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkillVoid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkillSheiker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkillEncha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkillZevs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkillVrka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkillVenga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkillTechis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAnimation
            // 
            this.timerAnimation.Interval = 500;
            this.timerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // timerBombAnimation
            // 
            this.timerBombAnimation.Interval = 500;
            this.timerBombAnimation.Tick += new System.EventHandler(this.timerBombAnimation_Tick);
            // 
            // labelTimeToEnd
            // 
            this.labelTimeToEnd.AutoSize = true;
            this.labelTimeToEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeToEnd.Location = new System.Drawing.Point(875, 48);
            this.labelTimeToEnd.Name = "labelTimeToEnd";
            this.labelTimeToEnd.Size = new System.Drawing.Size(266, 31);
            this.labelTimeToEnd.TabIndex = 84;
            this.labelTimeToEnd.Text = "Осталось 15 секунд";
            // 
            // labelSheikerTo
            // 
            this.labelSheikerTo.AutoSize = true;
            this.labelSheikerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSheikerTo.Location = new System.Drawing.Point(1201, 494);
            this.labelSheikerTo.Name = "labelSheikerTo";
            this.labelSheikerTo.Size = new System.Drawing.Size(72, 25);
            this.labelSheikerTo.TabIndex = 83;
            this.labelSheikerTo.Text = "из 150";
            // 
            // labelSheikerFrom
            // 
            this.labelSheikerFrom.AutoSize = true;
            this.labelSheikerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSheikerFrom.Location = new System.Drawing.Point(1161, 494);
            this.labelSheikerFrom.Name = "labelSheikerFrom";
            this.labelSheikerFrom.Size = new System.Drawing.Size(23, 25);
            this.labelSheikerFrom.TabIndex = 82;
            this.labelSheikerFrom.Text = "0";
            // 
            // labelVoidTo
            // 
            this.labelVoidTo.AutoSize = true;
            this.labelVoidTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVoidTo.Location = new System.Drawing.Point(815, 494);
            this.labelVoidTo.Name = "labelVoidTo";
            this.labelVoidTo.Size = new System.Drawing.Size(72, 25);
            this.labelVoidTo.TabIndex = 81;
            this.labelVoidTo.Text = "из 100";
            // 
            // labelVoidFrom
            // 
            this.labelVoidFrom.AutoSize = true;
            this.labelVoidFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVoidFrom.Location = new System.Drawing.Point(775, 494);
            this.labelVoidFrom.Name = "labelVoidFrom";
            this.labelVoidFrom.Size = new System.Drawing.Size(23, 25);
            this.labelVoidFrom.TabIndex = 80;
            this.labelVoidFrom.Text = "0";
            // 
            // labelZevsTo
            // 
            this.labelZevsTo.AutoSize = true;
            this.labelZevsTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZevsTo.Location = new System.Drawing.Point(1221, 336);
            this.labelZevsTo.Name = "labelZevsTo";
            this.labelZevsTo.Size = new System.Drawing.Size(61, 25);
            this.labelZevsTo.TabIndex = 79;
            this.labelZevsTo.Text = "из 50";
            // 
            // labelZevsFrom
            // 
            this.labelZevsFrom.AutoSize = true;
            this.labelZevsFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZevsFrom.Location = new System.Drawing.Point(1160, 337);
            this.labelZevsFrom.Name = "labelZevsFrom";
            this.labelZevsFrom.Size = new System.Drawing.Size(23, 25);
            this.labelZevsFrom.TabIndex = 78;
            this.labelZevsFrom.Text = "0";
            // 
            // labelVrkaTo
            // 
            this.labelVrkaTo.AutoSize = true;
            this.labelVrkaTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVrkaTo.Location = new System.Drawing.Point(826, 336);
            this.labelVrkaTo.Name = "labelVrkaTo";
            this.labelVrkaTo.Size = new System.Drawing.Size(61, 25);
            this.labelVrkaTo.TabIndex = 77;
            this.labelVrkaTo.Text = "из 50";
            // 
            // labelVrkaFrom
            // 
            this.labelVrkaFrom.AutoSize = true;
            this.labelVrkaFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVrkaFrom.Location = new System.Drawing.Point(771, 336);
            this.labelVrkaFrom.Name = "labelVrkaFrom";
            this.labelVrkaFrom.Size = new System.Drawing.Size(23, 25);
            this.labelVrkaFrom.TabIndex = 76;
            this.labelVrkaFrom.Text = "0";
            // 
            // labelEnchaTo
            // 
            this.labelEnchaTo.AutoSize = true;
            this.labelEnchaTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnchaTo.Location = new System.Drawing.Point(1201, 185);
            this.labelEnchaTo.Name = "labelEnchaTo";
            this.labelEnchaTo.Size = new System.Drawing.Size(61, 25);
            this.labelEnchaTo.TabIndex = 75;
            this.labelEnchaTo.Text = "из 25";
            // 
            // labelEnchaFrom
            // 
            this.labelEnchaFrom.AutoSize = true;
            this.labelEnchaFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnchaFrom.Location = new System.Drawing.Point(1160, 186);
            this.labelEnchaFrom.Name = "labelEnchaFrom";
            this.labelEnchaFrom.Size = new System.Drawing.Size(23, 25);
            this.labelEnchaFrom.TabIndex = 74;
            this.labelEnchaFrom.Text = "0";
            // 
            // labelTechisTo
            // 
            this.labelTechisTo.AutoSize = true;
            this.labelTechisTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTechisTo.Location = new System.Drawing.Point(831, 186);
            this.labelTechisTo.Name = "labelTechisTo";
            this.labelTechisTo.Size = new System.Drawing.Size(61, 25);
            this.labelTechisTo.TabIndex = 73;
            this.labelTechisTo.Text = "из 25";
            // 
            // labelTechisFrom
            // 
            this.labelTechisFrom.AutoSize = true;
            this.labelTechisFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTechisFrom.Location = new System.Drawing.Point(775, 186);
            this.labelTechisFrom.Name = "labelTechisFrom";
            this.labelTechisFrom.Size = new System.Drawing.Size(23, 25);
            this.labelTechisFrom.TabIndex = 72;
            this.labelTechisFrom.Text = "0";
            // 
            // labelVengaTo
            // 
            this.labelVengaTo.AutoSize = true;
            this.labelVengaTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVengaTo.Location = new System.Drawing.Point(1037, 185);
            this.labelVengaTo.Name = "labelVengaTo";
            this.labelVengaTo.Size = new System.Drawing.Size(61, 25);
            this.labelVengaTo.TabIndex = 71;
            this.labelVengaTo.Text = "из 10";
            // 
            // labelVengaFrom
            // 
            this.labelVengaFrom.AutoSize = true;
            this.labelVengaFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVengaFrom.Location = new System.Drawing.Point(977, 185);
            this.labelVengaFrom.Name = "labelVengaFrom";
            this.labelVengaFrom.Size = new System.Drawing.Size(23, 25);
            this.labelVengaFrom.TabIndex = 70;
            this.labelVengaFrom.Text = "0";
            // 
            // pictureBoxSkillVoid
            // 
            this.pictureBoxSkillVoid.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSkillVoid.Image")));
            this.pictureBoxSkillVoid.Location = new System.Drawing.Point(772, 522);
            this.pictureBoxSkillVoid.Name = "pictureBoxSkillVoid";
            this.pictureBoxSkillVoid.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxSkillVoid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSkillVoid.TabIndex = 69;
            this.pictureBoxSkillVoid.TabStop = false;
            this.pictureBoxSkillVoid.Click += new System.EventHandler(this.pictureBoxSkillVoid_Click);
            // 
            // pictureBoxSkillSheiker
            // 
            this.pictureBoxSkillSheiker.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSkillSheiker.Image")));
            this.pictureBoxSkillSheiker.Location = new System.Drawing.Point(1162, 522);
            this.pictureBoxSkillSheiker.Name = "pictureBoxSkillSheiker";
            this.pictureBoxSkillSheiker.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxSkillSheiker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSkillSheiker.TabIndex = 68;
            this.pictureBoxSkillSheiker.TabStop = false;
            this.pictureBoxSkillSheiker.Click += new System.EventHandler(this.pictureBoxSkillSheiker_Click);
            // 
            // pictureBoxSkillEncha
            // 
            this.pictureBoxSkillEncha.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSkillEncha.Image")));
            this.pictureBoxSkillEncha.Location = new System.Drawing.Point(1162, 213);
            this.pictureBoxSkillEncha.Name = "pictureBoxSkillEncha";
            this.pictureBoxSkillEncha.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxSkillEncha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSkillEncha.TabIndex = 67;
            this.pictureBoxSkillEncha.TabStop = false;
            this.pictureBoxSkillEncha.Click += new System.EventHandler(this.pictureBoxSkillEncha_Click);
            // 
            // pictureBoxSkillZevs
            // 
            this.pictureBoxSkillZevs.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSkillZevs.Image")));
            this.pictureBoxSkillZevs.Location = new System.Drawing.Point(1162, 364);
            this.pictureBoxSkillZevs.Name = "pictureBoxSkillZevs";
            this.pictureBoxSkillZevs.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxSkillZevs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSkillZevs.TabIndex = 66;
            this.pictureBoxSkillZevs.TabStop = false;
            this.pictureBoxSkillZevs.Click += new System.EventHandler(this.pictureBoxSkillZevs_Click);
            // 
            // pictureBoxSkillVrka
            // 
            this.pictureBoxSkillVrka.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSkillVrka.Image")));
            this.pictureBoxSkillVrka.Location = new System.Drawing.Point(772, 364);
            this.pictureBoxSkillVrka.Name = "pictureBoxSkillVrka";
            this.pictureBoxSkillVrka.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxSkillVrka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSkillVrka.TabIndex = 65;
            this.pictureBoxSkillVrka.TabStop = false;
            this.pictureBoxSkillVrka.Click += new System.EventHandler(this.pictureBoxSkillVrka_Click);
            // 
            // pictureBoxSkillVenga
            // 
            this.pictureBoxSkillVenga.AccessibleDescription = "";
            this.pictureBoxSkillVenga.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSkillVenga.Image")));
            this.pictureBoxSkillVenga.Location = new System.Drawing.Point(978, 213);
            this.pictureBoxSkillVenga.Name = "pictureBoxSkillVenga";
            this.pictureBoxSkillVenga.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxSkillVenga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSkillVenga.TabIndex = 64;
            this.pictureBoxSkillVenga.TabStop = false;
            this.pictureBoxSkillVenga.Click += new System.EventHandler(this.pictureBoxSkillVenga_Click);
            // 
            // pictureBoxMix
            // 
            this.pictureBoxMix.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMix.Image")));
            this.pictureBoxMix.Location = new System.Drawing.Point(875, 124);
            this.pictureBoxMix.Name = "pictureBoxMix";
            this.pictureBoxMix.Size = new System.Drawing.Size(278, 58);
            this.pictureBoxMix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMix.TabIndex = 63;
            this.pictureBoxMix.TabStop = false;
            this.pictureBoxMix.Click += new System.EventHandler(this.pictureBoxMix_Click);
            // 
            // labelCountPoints
            // 
            this.labelCountPoints.AutoSize = true;
            this.labelCountPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPoints.Location = new System.Drawing.Point(875, 90);
            this.labelCountPoints.Name = "labelCountPoints";
            this.labelCountPoints.Size = new System.Drawing.Size(278, 31);
            this.labelCountPoints.TabIndex = 62;
            this.labelCountPoints.Text = "Количество очков - 0";
            // 
            // pictureBoxSkillTechis
            // 
            this.pictureBoxSkillTechis.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSkillTechis.Image")));
            this.pictureBoxSkillTechis.Location = new System.Drawing.Point(772, 213);
            this.pictureBoxSkillTechis.Name = "pictureBoxSkillTechis";
            this.pictureBoxSkillTechis.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxSkillTechis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSkillTechis.TabIndex = 85;
            this.pictureBoxSkillTechis.TabStop = false;
            this.pictureBoxSkillTechis.Click += new System.EventHandler(this.pictureBoxSkillTechis_Click);
            // 
            // timerCountTime
            // 
            this.timerCountTime.Enabled = true;
            this.timerCountTime.Interval = 1000;
            this.timerCountTime.Tick += new System.EventHandler(this.timerCountTime_Tick);
            // 
            // timerTimeToAppCountTimer
            // 
            this.timerTimeToAppCountTimer.Interval = 1000;
            this.timerTimeToAppCountTimer.Tick += new System.EventHandler(this.timerTimeToAppCountTimer_Tick);
            // 
            // pictureBoxBackGround
            // 
            this.pictureBoxBackGround.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackGround.Image")));
            this.pictureBoxBackGround.Location = new System.Drawing.Point(0, -14);
            this.pictureBoxBackGround.Name = "pictureBoxBackGround";
            this.pictureBoxBackGround.Size = new System.Drawing.Size(1386, 790);
            this.pictureBoxBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackGround.TabIndex = 1;
            this.pictureBoxBackGround.TabStop = false;
            this.pictureBoxBackGround.Click += new System.EventHandler(this.pictureBoxBackGround_Click);
            // 
            // timerEndMusic
            // 
            this.timerEndMusic.Tick += new System.EventHandler(this.timerEndMusic_Tick);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBack.Image")));
            this.pictureBoxBack.Location = new System.Drawing.Point(892, 648);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(278, 58);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 87;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.pictureBoxSkillTechis);
            this.Controls.Add(this.labelTimeToEnd);
            this.Controls.Add(this.labelSheikerTo);
            this.Controls.Add(this.labelSheikerFrom);
            this.Controls.Add(this.labelVoidTo);
            this.Controls.Add(this.labelVoidFrom);
            this.Controls.Add(this.labelZevsTo);
            this.Controls.Add(this.labelZevsFrom);
            this.Controls.Add(this.labelVrkaTo);
            this.Controls.Add(this.labelVrkaFrom);
            this.Controls.Add(this.labelEnchaTo);
            this.Controls.Add(this.labelEnchaFrom);
            this.Controls.Add(this.labelTechisTo);
            this.Controls.Add(this.labelTechisFrom);
            this.Controls.Add(this.labelVengaTo);
            this.Controls.Add(this.labelVengaFrom);
            this.Controls.Add(this.pictureBoxSkillVoid);
            this.Controls.Add(this.pictureBoxSkillSheiker);
            this.Controls.Add(this.pictureBoxSkillEncha);
            this.Controls.Add(this.pictureBoxSkillZevs);
            this.Controls.Add(this.pictureBoxSkillVrka);
            this.Controls.Add(this.pictureBoxSkillVenga);
            this.Controls.Add(this.pictureBoxMix);
            this.Controls.Add(this.labelCountPoints);
            this.Controls.Add(this.pictureBoxBackGround);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGame";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGame_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkillVoid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkillSheiker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkillEncha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkillZevs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkillVrka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkillVenga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkillTechis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerAnimation;
        private System.Windows.Forms.Timer timerBombAnimation;
        private System.Windows.Forms.Label labelTimeToEnd;
        public System.Windows.Forms.Label labelSheikerTo;
        public System.Windows.Forms.Label labelSheikerFrom;
        public System.Windows.Forms.Label labelVoidTo;
        public System.Windows.Forms.Label labelVoidFrom;
        public System.Windows.Forms.Label labelZevsTo;
        public System.Windows.Forms.Label labelZevsFrom;
        public System.Windows.Forms.Label labelVrkaTo;
        public System.Windows.Forms.Label labelVrkaFrom;
        public System.Windows.Forms.Label labelEnchaTo;
        public System.Windows.Forms.Label labelEnchaFrom;
        public System.Windows.Forms.Label labelTechisTo;
        public System.Windows.Forms.Label labelTechisFrom;
        public System.Windows.Forms.Label labelVengaTo;
        public System.Windows.Forms.Label labelVengaFrom;
        public System.Windows.Forms.PictureBox pictureBoxSkillVoid;
        public System.Windows.Forms.PictureBox pictureBoxSkillSheiker;
        public System.Windows.Forms.PictureBox pictureBoxSkillEncha;
        public System.Windows.Forms.PictureBox pictureBoxSkillZevs;
        public System.Windows.Forms.PictureBox pictureBoxSkillVrka;
        public System.Windows.Forms.PictureBox pictureBoxSkillVenga;
        private System.Windows.Forms.PictureBox pictureBoxMix;
        private System.Windows.Forms.Label labelCountPoints;
        public System.Windows.Forms.PictureBox pictureBoxSkillTechis;
        private System.Windows.Forms.Timer timerCountTime;
        private System.Windows.Forms.Timer timerTimeToAppCountTimer;
        private System.Windows.Forms.PictureBox pictureBoxBackGround;
        private System.Windows.Forms.Timer timerEndMusic;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}

