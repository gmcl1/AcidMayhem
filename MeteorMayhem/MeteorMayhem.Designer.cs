namespace MeteorMayhem
{
    partial class MeteorMayhem
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
            this.tmrGameTick = new System.Windows.Forms.Timer(this.components);
            this.lblMenuBar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picResumePause = new System.Windows.Forms.PictureBox();
            this.picRestart = new System.Windows.Forms.PictureBox();
            this.picPoints = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.picAcid1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tmrSecond = new System.Windows.Forms.Timer(this.components);
            this.tmr5Second = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResumePause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAcid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrGameTick
            // 
            this.tmrGameTick.Interval = 20;
            this.tmrGameTick.Tick += new System.EventHandler(this.tmrGameTick_Tick);
            // 
            // lblMenuBar
            // 
            this.lblMenuBar.AutoSize = true;
            this.lblMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(156)))), ((int)(((byte)(47)))));
            this.lblMenuBar.Location = new System.Drawing.Point(-8, -1);
            this.lblMenuBar.Name = "lblMenuBar";
            this.lblMenuBar.Padding = new System.Windows.Forms.Padding(1200, 10, 5, 10);
            this.lblMenuBar.Size = new System.Drawing.Size(1205, 36);
            this.lblMenuBar.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(156)))), ((int)(((byte)(47)))));
            this.label1.Font = new System.Drawing.Font("Blazma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Acid Mayhem";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Blazma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.White;
            this.lblPoints.Location = new System.Drawing.Point(23, 47);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(21, 23);
            this.lblPoints.TabIndex = 17;
            this.lblPoints.Text = "0";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(156)))), ((int)(((byte)(47)))));
            this.picExit.Image = global::MeteorMayhem.Properties.Resources.logout;
            this.picExit.Location = new System.Drawing.Point(424, 7);
            this.picExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(28, 21);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 20;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // picResumePause
            // 
            this.picResumePause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(156)))), ((int)(((byte)(47)))));
            this.picResumePause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picResumePause.Image = global::MeteorMayhem.Properties.Resources.pause_play;
            this.picResumePause.Location = new System.Drawing.Point(352, 7);
            this.picResumePause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picResumePause.Name = "picResumePause";
            this.picResumePause.Size = new System.Drawing.Size(28, 21);
            this.picResumePause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResumePause.TabIndex = 19;
            this.picResumePause.TabStop = false;
            this.picResumePause.Click += new System.EventHandler(this.picResumePause_Click);
            // 
            // picRestart
            // 
            this.picRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(156)))), ((int)(((byte)(47)))));
            this.picRestart.Image = global::MeteorMayhem.Properties.Resources.rotate;
            this.picRestart.Location = new System.Drawing.Point(387, 7);
            this.picRestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picRestart.Name = "picRestart";
            this.picRestart.Size = new System.Drawing.Size(32, 21);
            this.picRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRestart.TabIndex = 18;
            this.picRestart.TabStop = false;
            this.picRestart.Click += new System.EventHandler(this.picRestart_Click);
            // 
            // picPoints
            // 
            this.picPoints.Image = global::MeteorMayhem.Properties.Resources.acid_icon;
            this.picPoints.Location = new System.Drawing.Point(11, 52);
            this.picPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPoints.Name = "picPoints";
            this.picPoints.Size = new System.Drawing.Size(11, 14);
            this.picPoints.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoints.TabIndex = 16;
            this.picPoints.TabStop = false;
            this.picPoints.Tag = "";
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::MeteorMayhem.Properties.Resources.hazmat;
            this.picPlayer.Location = new System.Drawing.Point(217, 630);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(32, 48);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 13;
            this.picPlayer.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::MeteorMayhem.Properties.Resources.acid_icon;
            this.pictureBox12.Location = new System.Drawing.Point(413, 308);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(20, 20);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 23;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "acid45";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MeteorMayhem.Properties.Resources.acid_icon;
            this.pictureBox3.Location = new System.Drawing.Point(413, 158);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "acid4";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::MeteorMayhem.Properties.Resources.acid_icon;
            this.pictureBox11.Location = new System.Drawing.Point(276, 271);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(20, 20);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 22;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "acid34";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MeteorMayhem.Properties.Resources.acid_icon;
            this.pictureBox2.Location = new System.Drawing.Point(276, 121);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "acid3";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::MeteorMayhem.Properties.Resources.acid_icon;
            this.pictureBox10.Location = new System.Drawing.Point(155, 308);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(20, 20);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 21;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "acid23";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MeteorMayhem.Properties.Resources.acid_icon;
            this.pictureBox1.Location = new System.Drawing.Point(155, 158);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "acid2";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::MeteorMayhem.Properties.Resources.acid_icon;
            this.pictureBox9.Location = new System.Drawing.Point(75, 251);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(20, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "acid12";
            // 
            // picAcid1
            // 
            this.picAcid1.Image = global::MeteorMayhem.Properties.Resources.acid_icon;
            this.picAcid1.Location = new System.Drawing.Point(75, 101);
            this.picAcid1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAcid1.Name = "picAcid1";
            this.picAcid1.Size = new System.Drawing.Size(20, 20);
            this.picAcid1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAcid1.TabIndex = 0;
            this.picAcid1.TabStop = false;
            this.picAcid1.Tag = "acid1";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MeteorMayhem.Properties.Resources.Layer_1;
            this.pictureBox4.Location = new System.Drawing.Point(304, 185);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(13, 15);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "bonus";
            // 
            // tmrSecond
            // 
            this.tmrSecond.Enabled = true;
            this.tmrSecond.Interval = 1000;
            this.tmrSecond.Tick += new System.EventHandler(this.tmrSecond_Tick);
            // 
            // tmr5Second
            // 
            this.tmr5Second.Enabled = true;
            this.tmr5Second.Interval = 5000;
            this.tmr5Second.Tick += new System.EventHandler(this.tmr5Second_Tick);
            // 
            // MeteorMayhem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(467, 753);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picResumePause);
            this.Controls.Add(this.picRestart);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.picPoints);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.lblMenuBar);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.picAcid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MeteorMayhem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Load += new System.EventHandler(this.MeteorMayhem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MeteorMayhem_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MeteorMayhem_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResumePause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAcid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.PictureBox picAcid1;
        private System.Windows.Forms.Timer tmrGameTick;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Label lblMenuBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picPoints;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.PictureBox picRestart;
        private System.Windows.Forms.PictureBox picResumePause;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer tmrSecond;
        private System.Windows.Forms.Timer tmr5Second;
    }
}

