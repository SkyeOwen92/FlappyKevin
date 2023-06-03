namespace FlappyKyle
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
            this.Kevin = new System.Windows.Forms.PictureBox();
            this.pt = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.pb = new System.Windows.Forms.PictureBox();
            this.scoreTxt = new System.Windows.Forms.Label();
            this.GameClock = new System.Windows.Forms.Timer(this.components);
            this.pt1 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.HighScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Kevin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // Kevin
            // 
            this.Kevin.BackColor = System.Drawing.Color.Transparent;
            this.Kevin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Kevin.Image = global::FlappyKyle.Properties.Resources.Clipped_image_20230603_012052;
            this.Kevin.Location = new System.Drawing.Point(148, 222);
            this.Kevin.Name = "Kevin";
            this.Kevin.Size = new System.Drawing.Size(67, 72);
            this.Kevin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kevin.TabIndex = 0;
            this.Kevin.TabStop = false;
            // 
            // pt
            // 
            this.pt.Image = global::FlappyKyle.Properties.Resources.pipedown;
            this.pt.Location = new System.Drawing.Point(400, -100);
            this.pt.Name = "pt";
            this.pt.Size = new System.Drawing.Size(125, 300);
            this.pt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt.TabIndex = 1;
            this.pt.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.Transparent;
            this.Ground.Image = global::FlappyKyle.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-1, 506);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(574, 112);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            // 
            // pb
            // 
            this.pb.Image = global::FlappyKyle.Properties.Resources.pipe;
            this.pb.Location = new System.Drawing.Point(400, 350);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(125, 300);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 5;
            this.pb.TabStop = false;
            // 
            // scoreTxt
            // 
            this.scoreTxt.AutoSize = true;
            this.scoreTxt.BackColor = System.Drawing.Color.Transparent;
            this.scoreTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreTxt.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTxt.Location = new System.Drawing.Point(22, 541);
            this.scoreTxt.Name = "scoreTxt";
            this.scoreTxt.Size = new System.Drawing.Size(120, 29);
            this.scoreTxt.TabIndex = 6;
            this.scoreTxt.Text = "Score: 0 ";
            // 
            // GameClock
            // 
            this.GameClock.Enabled = true;
            this.GameClock.Interval = 20;
            this.GameClock.Tick += new System.EventHandler(this.timerEvent);
            // 
            // pt1
            // 
            this.pt1.Image = global::FlappyKyle.Properties.Resources.pipedown;
            this.pt1.Location = new System.Drawing.Point(800, -50);
            this.pt1.Name = "pt1";
            this.pt1.Size = new System.Drawing.Size(125, 300);
            this.pt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt1.TabIndex = 7;
            this.pt1.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Image = global::FlappyKyle.Properties.Resources.pipe;
            this.pb1.Location = new System.Drawing.Point(800, 400);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(125, 300);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 8;
            this.pb1.TabStop = false;
            // 
            // HighScore
            // 
            this.HighScore.AutoSize = true;
            this.HighScore.BackColor = System.Drawing.Color.Transparent;
            this.HighScore.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScore.Location = new System.Drawing.Point(200, 589);
            this.HighScore.Name = "HighScore";
            this.HighScore.Size = new System.Drawing.Size(95, 16);
            this.HighScore.TabIndex = 9;
            this.HighScore.Text = "High Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(550, 614);
            this.Controls.Add(this.HighScore);
            this.Controls.Add(this.Kevin);
            this.Controls.Add(this.scoreTxt);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.pt);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pt1);
            this.Name = "Form1";
            this.Text = "Flappy Kevin";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsPressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IsReleased);
            ((System.ComponentModel.ISupportInitialize)(this.Kevin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Kevin;
        private System.Windows.Forms.PictureBox pt;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Label scoreTxt;
        private System.Windows.Forms.Timer GameClock;
        private System.Windows.Forms.PictureBox pt1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label HighScore;
    }
}

