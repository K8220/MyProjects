namespace Limiting_movement
{
    partial class Form1
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
            this.generalTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoss = new System.Windows.Forms.PictureBox();
            this.pictureBoxSword = new System.Windows.Forms.PictureBox();
            this.pictureBoxNPC = new System.Windows.Forms.PictureBox();
            this.pictureBoxWallBottom = new System.Windows.Forms.PictureBox();
            this.pictureBoxWallRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxWallLeft = new System.Windows.Forms.PictureBox();
            this.pictureBox_player = new System.Windows.Forms.PictureBox();
            this.pictureBoxWallTop = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWallBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWallRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWallLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWallTop)).BeginInit();
            this.SuspendLayout();
            // 
            // generalTimer
            // 
            this.generalTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = " ";
            // 
            // pictureBoss
            // 
            this.pictureBoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoss.BackgroundImage = global::Limiting_movement.Properties.Resources._224765554735579136;
            this.pictureBoss.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoss.Location = new System.Drawing.Point(95, 169);
            this.pictureBoss.Name = "pictureBoss";
            this.pictureBoss.Size = new System.Drawing.Size(112, 80);
            this.pictureBoss.TabIndex = 8;
            this.pictureBoss.TabStop = false;
            // 
            // pictureBoxSword
            // 
            this.pictureBoxSword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBoxSword.Location = new System.Drawing.Point(23, 27);
            this.pictureBoxSword.Name = "pictureBoxSword";
            this.pictureBoxSword.Size = new System.Drawing.Size(15, 50);
            this.pictureBoxSword.TabIndex = 7;
            this.pictureBoxSword.TabStop = false;
            // 
            // pictureBoxNPC
            // 
            this.pictureBoxNPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBoxNPC.BackgroundImage = global::Limiting_movement.Properties.Resources._2256255351101849621;
            this.pictureBoxNPC.Location = new System.Drawing.Point(224, 27);
            this.pictureBoxNPC.Name = "pictureBoxNPC";
            this.pictureBoxNPC.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxNPC.TabIndex = 5;
            this.pictureBoxNPC.TabStop = false;
            // 
            // pictureBoxWallBottom
            // 
            this.pictureBoxWallBottom.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxWallBottom.Location = new System.Drawing.Point(6, 254);
            this.pictureBoxWallBottom.Name = "pictureBoxWallBottom";
            this.pictureBoxWallBottom.Size = new System.Drawing.Size(275, 50);
            this.pictureBoxWallBottom.TabIndex = 4;
            this.pictureBoxWallBottom.TabStop = false;
            // 
            // pictureBoxWallRight
            // 
            this.pictureBoxWallRight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxWallRight.Location = new System.Drawing.Point(266, -34);
            this.pictureBoxWallRight.Name = "pictureBoxWallRight";
            this.pictureBoxWallRight.Size = new System.Drawing.Size(46, 303);
            this.pictureBoxWallRight.TabIndex = 3;
            this.pictureBoxWallRight.TabStop = false;
            // 
            // pictureBoxWallLeft
            // 
            this.pictureBoxWallLeft.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxWallLeft.Location = new System.Drawing.Point(-87, 2);
            this.pictureBoxWallLeft.Name = "pictureBoxWallLeft";
            this.pictureBoxWallLeft.Size = new System.Drawing.Size(104, 267);
            this.pictureBoxWallLeft.TabIndex = 2;
            this.pictureBoxWallLeft.TabStop = false;
            // 
            // pictureBox_player
            // 
            this.pictureBox_player.BackColor = System.Drawing.Color.Blue;
            this.pictureBox_player.Location = new System.Drawing.Point(128, 88);
            this.pictureBox_player.Name = "pictureBox_player";
            this.pictureBox_player.Size = new System.Drawing.Size(36, 36);
            this.pictureBox_player.TabIndex = 1;
            this.pictureBox_player.TabStop = false;
            // 
            // pictureBoxWallTop
            // 
            this.pictureBoxWallTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxWallTop.Location = new System.Drawing.Point(-23, -42);
            this.pictureBoxWallTop.Name = "pictureBoxWallTop";
            this.pictureBoxWallTop.Size = new System.Drawing.Size(335, 50);
            this.pictureBoxWallTop.TabIndex = 0;
            this.pictureBoxWallTop.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(95, 246);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(112, 23);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBoss);
            this.Controls.Add(this.pictureBoxSword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxNPC);
            this.Controls.Add(this.pictureBoxWallBottom);
            this.Controls.Add(this.pictureBoxWallRight);
            this.Controls.Add(this.pictureBoxWallLeft);
            this.Controls.Add(this.pictureBox_player);
            this.Controls.Add(this.pictureBoxWallTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWallBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWallRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWallLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWallTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxWallTop;
        private System.Windows.Forms.PictureBox pictureBox_player;
        private System.Windows.Forms.PictureBox pictureBoxWallLeft;
        private System.Windows.Forms.PictureBox pictureBoxWallRight;
        private System.Windows.Forms.PictureBox pictureBoxWallBottom;
        private System.Windows.Forms.Timer generalTimer;
        private System.Windows.Forms.PictureBox pictureBoxNPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxSword;
        private System.Windows.Forms.PictureBox pictureBoss;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

