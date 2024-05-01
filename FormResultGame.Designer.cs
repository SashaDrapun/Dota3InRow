namespace Dota3InARow
{
    partial class FormResultGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResultGame));
            this.pictureBoxBackGround = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            this.labelInputName = new System.Windows.Forms.Label();
            this.labelCountPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBackGround
            // 
            this.pictureBoxBackGround.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackGround.Image")));
            this.pictureBoxBackGround.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackGround.Name = "pictureBoxBackGround";
            this.pictureBoxBackGround.Size = new System.Drawing.Size(816, 238);
            this.pictureBoxBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackGround.TabIndex = 67;
            this.pictureBoxBackGround.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(231, 159);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(272, 39);
            this.buttonSave.TabIndex = 106;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.Location = new System.Drawing.Point(231, 133);
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.Size = new System.Drawing.Size(272, 20);
            this.textBoxNickname.TabIndex = 105;
            // 
            // labelInputName
            // 
            this.labelInputName.AutoSize = true;
            this.labelInputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputName.Location = new System.Drawing.Point(85, 90);
            this.labelInputName.Name = "labelInputName";
            this.labelInputName.Size = new System.Drawing.Size(673, 31);
            this.labelInputName.TabIndex = 104;
            this.labelInputName.Text = "Введите под каким никнеймом сохранить результат";
            // 
            // labelCountPoints
            // 
            this.labelCountPoints.AutoSize = true;
            this.labelCountPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPoints.Location = new System.Drawing.Point(225, 34);
            this.labelCountPoints.Name = "labelCountPoints";
            this.labelCountPoints.Size = new System.Drawing.Size(278, 31);
            this.labelCountPoints.TabIndex = 103;
            this.labelCountPoints.Text = "Количество очков - 0";
            // 
            // FormResultGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 238);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxNickname);
            this.Controls.Add(this.labelInputName);
            this.Controls.Add(this.labelCountPoints);
            this.Controls.Add(this.pictureBoxBackGround);
            this.Name = "FormResultGame";
            this.Text = "FormResultGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackGround;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxNickname;
        private System.Windows.Forms.Label labelInputName;
        private System.Windows.Forms.Label labelCountPoints;
    }
}