namespace Test_Game
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
            this.picturePlayer = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.pictureMoving = new System.Windows.Forms.PictureBox();
            this.PictureShot = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMoving)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureShot)).BeginInit();
            this.SuspendLayout();
            // 
            // picturePlayer
            // 
            this.picturePlayer.BackColor = System.Drawing.SystemColors.ControlText;
            this.picturePlayer.Location = new System.Drawing.Point(165, 261);
            this.picturePlayer.Name = "picturePlayer";
            this.picturePlayer.Size = new System.Drawing.Size(49, 50);
            this.picturePlayer.TabIndex = 0;
            this.picturePlayer.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelEnd.Location = new System.Drawing.Point(136, 117);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(101, 13);
            this.labelEnd.TabIndex = 1;
            this.labelEnd.Text = "To exit hit \"escape\"";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelStart.Location = new System.Drawing.Point(136, 87);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(94, 13);
            this.labelStart.TabIndex = 2;
            this.labelStart.Text = "To start hit \"enter\"";
            // 
            // pictureMoving
            // 
            this.pictureMoving.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureMoving.Location = new System.Drawing.Point(137, 12);
            this.pictureMoving.Name = "pictureMoving";
            this.pictureMoving.Size = new System.Drawing.Size(100, 50);
            this.pictureMoving.TabIndex = 3;
            this.pictureMoving.TabStop = false;
            // 
            // PictureShot
            // 
            this.PictureShot.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PictureShot.Location = new System.Drawing.Point(165, 195);
            this.PictureShot.Name = "PictureShot";
            this.PictureShot.Size = new System.Drawing.Size(33, 50);
            this.PictureShot.TabIndex = 4;
            this.PictureShot.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, -2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 323);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.PictureShot);
            this.Controls.Add(this.pictureMoving);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.picturePlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMoving)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureShot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePlayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.PictureBox pictureMoving;
        private System.Windows.Forms.PictureBox PictureShot;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

