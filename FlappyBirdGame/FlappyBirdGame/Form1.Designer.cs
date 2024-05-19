namespace FlappyBirdGame
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
			this.pictureBox_top = new System.Windows.Forms.PictureBox();
			this.pictureBox_bird = new System.Windows.Forms.PictureBox();
			this.pictureBox_ground = new System.Windows.Forms.PictureBox();
			this.pictureBox_down = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.timer_GameControl = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_top)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ground)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_down)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox_top
			// 
			this.pictureBox_top.Image = global::FlappyBirdGame.Properties.Resources.pipedown;
			this.pictureBox_top.Location = new System.Drawing.Point(681, -1);
			this.pictureBox_top.Name = "pictureBox_top";
			this.pictureBox_top.Size = new System.Drawing.Size(118, 200);
			this.pictureBox_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_top.TabIndex = 0;
			this.pictureBox_top.TabStop = false;
			// 
			// pictureBox_bird
			// 
			this.pictureBox_bird.Image = global::FlappyBirdGame.Properties.Resources.bird;
			this.pictureBox_bird.Location = new System.Drawing.Point(46, 274);
			this.pictureBox_bird.Name = "pictureBox_bird";
			this.pictureBox_bird.Size = new System.Drawing.Size(94, 78);
			this.pictureBox_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_bird.TabIndex = 1;
			this.pictureBox_bird.TabStop = false;
			// 
			// pictureBox_ground
			// 
			this.pictureBox_ground.Image = global::FlappyBirdGame.Properties.Resources.ground;
			this.pictureBox_ground.Location = new System.Drawing.Point(-4, 549);
			this.pictureBox_ground.Name = "pictureBox_ground";
			this.pictureBox_ground.Size = new System.Drawing.Size(812, 191);
			this.pictureBox_ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_ground.TabIndex = 2;
			this.pictureBox_ground.TabStop = false;
			// 
			// pictureBox_down
			// 
			this.pictureBox_down.Image = global::FlappyBirdGame.Properties.Resources.pipe;
			this.pictureBox_down.Location = new System.Drawing.Point(457, 377);
			this.pictureBox_down.Name = "pictureBox_down";
			this.pictureBox_down.Size = new System.Drawing.Size(121, 180);
			this.pictureBox_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_down.TabIndex = 3;
			this.pictureBox_down.TabStop = false;
			this.pictureBox_down.Click += new System.EventHandler(this.pictureBox_down_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 39);
			this.label1.TabIndex = 4;
			this.label1.Text = "SCORE:";
			// 
			// timer_GameControl
			// 
			this.timer_GameControl.Enabled = true;
			this.timer_GameControl.Interval = 20;
			this.timer_GameControl.Tick += new System.EventHandler(this.gameTimer);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(800, 731);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox_down);
			this.Controls.Add(this.pictureBox_ground);
			this.Controls.Add(this.pictureBox_bird);
			this.Controls.Add(this.pictureBox_top);
			this.Name = "Form1";
			this.Text = "Flappy Bird Game";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_Down);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_UP);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_top)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ground)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_down)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox_top;
		private System.Windows.Forms.PictureBox pictureBox_bird;
		private System.Windows.Forms.PictureBox pictureBox_ground;
		private System.Windows.Forms.PictureBox pictureBox_down;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer_GameControl;
	}
}

