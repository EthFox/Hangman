namespace Hangman
{
	partial class frmHangman
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
			this.btnStart = new System.Windows.Forms.Button();
			this.lblWord = new System.Windows.Forms.Label();
			this.txtGuess = new System.Windows.Forms.MaskedTextBox();
			this.picHangman = new System.Windows.Forms.PictureBox();
			this.eyeCover1 = new System.Windows.Forms.PictureBox();
			this.eyeCover2 = new System.Windows.Forms.PictureBox();
			this.legCover1 = new System.Windows.Forms.PictureBox();
			this.legCover2 = new System.Windows.Forms.PictureBox();
			this.bodyCover = new System.Windows.Forms.PictureBox();
			this.armCover1 = new System.Windows.Forms.PictureBox();
			this.armCover2 = new System.Windows.Forms.PictureBox();
			this.headCover = new System.Windows.Forms.PictureBox();
			this.btnHard = new System.Windows.Forms.Button();
			this.lblWrongGuesses = new System.Windows.Forms.Label();
			this.lblDifficulty = new System.Windows.Forms.Label();
			this.btnNormal = new System.Windows.Forms.Button();
			this.btnImpossible = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picHangman)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eyeCover1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eyeCover2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.legCover1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.legCover2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bodyCover)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.armCover1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.armCover2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.headCover)).BeginInit();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.btnStart.FlatAppearance.BorderSize = 3;
			this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStart.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.ForeColor = System.Drawing.Color.White;
			this.btnStart.Location = new System.Drawing.Point(353, 406);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(94, 41);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Visible = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// lblWord
			// 
			this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWord.ForeColor = System.Drawing.SystemColors.Window;
			this.lblWord.Location = new System.Drawing.Point(-4, 67);
			this.lblWord.Name = "lblWord";
			this.lblWord.Size = new System.Drawing.Size(810, 134);
			this.lblWord.TabIndex = 1;
			this.lblWord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblWord.Visible = false;
			// 
			// txtGuess
			// 
			this.txtGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.txtGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtGuess.Enabled = false;
			this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGuess.ForeColor = System.Drawing.SystemColors.Window;
			this.txtGuess.Location = new System.Drawing.Point(385, 356);
			this.txtGuess.Mask = "L";
			this.txtGuess.Name = "txtGuess";
			this.txtGuess.Size = new System.Drawing.Size(39, 44);
			this.txtGuess.TabIndex = 2;
			this.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtGuess.Visible = false;
			this.txtGuess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuess_KeyPress);
			// 
			// picHangman
			// 
			this.picHangman.Image = global::Hangman.Properties.Resources.Hangman2;
			this.picHangman.Location = new System.Drawing.Point(441, 174);
			this.picHangman.Name = "picHangman";
			this.picHangman.Size = new System.Drawing.Size(400, 314);
			this.picHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picHangman.TabIndex = 3;
			this.picHangman.TabStop = false;
			this.picHangman.Visible = false;
			// 
			// eyeCover1
			// 
			this.eyeCover1.Location = new System.Drawing.Point(692, 239);
			this.eyeCover1.Name = "eyeCover1";
			this.eyeCover1.Size = new System.Drawing.Size(11, 14);
			this.eyeCover1.TabIndex = 4;
			this.eyeCover1.TabStop = false;
			this.eyeCover1.Visible = false;
			// 
			// eyeCover2
			// 
			this.eyeCover2.Location = new System.Drawing.Point(708, 239);
			this.eyeCover2.Name = "eyeCover2";
			this.eyeCover2.Size = new System.Drawing.Size(11, 14);
			this.eyeCover2.TabIndex = 5;
			this.eyeCover2.TabStop = false;
			this.eyeCover2.Visible = false;
			// 
			// legCover1
			// 
			this.legCover1.Location = new System.Drawing.Point(672, 344);
			this.legCover1.Name = "legCover1";
			this.legCover1.Size = new System.Drawing.Size(32, 41);
			this.legCover1.TabIndex = 6;
			this.legCover1.TabStop = false;
			this.legCover1.Visible = false;
			// 
			// legCover2
			// 
			this.legCover2.Location = new System.Drawing.Point(706, 344);
			this.legCover2.Name = "legCover2";
			this.legCover2.Size = new System.Drawing.Size(32, 41);
			this.legCover2.TabIndex = 7;
			this.legCover2.TabStop = false;
			this.legCover2.Visible = false;
			// 
			// bodyCover
			// 
			this.bodyCover.Location = new System.Drawing.Point(703, 269);
			this.bodyCover.Name = "bodyCover";
			this.bodyCover.Size = new System.Drawing.Size(4, 95);
			this.bodyCover.TabIndex = 8;
			this.bodyCover.TabStop = false;
			this.bodyCover.Visible = false;
			// 
			// armCover1
			// 
			this.armCover1.Location = new System.Drawing.Point(654, 279);
			this.armCover1.Name = "armCover1";
			this.armCover1.Size = new System.Drawing.Size(50, 39);
			this.armCover1.TabIndex = 9;
			this.armCover1.TabStop = false;
			this.armCover1.Visible = false;
			// 
			// armCover2
			// 
			this.armCover2.Location = new System.Drawing.Point(706, 279);
			this.armCover2.Name = "armCover2";
			this.armCover2.Size = new System.Drawing.Size(50, 39);
			this.armCover2.TabIndex = 10;
			this.armCover2.TabStop = false;
			this.armCover2.Visible = false;
			// 
			// headCover
			// 
			this.headCover.Location = new System.Drawing.Point(679, 228);
			this.headCover.Name = "headCover";
			this.headCover.Size = new System.Drawing.Size(53, 46);
			this.headCover.TabIndex = 11;
			this.headCover.TabStop = false;
			this.headCover.Visible = false;
			// 
			// btnHard
			// 
			this.btnHard.FlatAppearance.BorderSize = 0;
			this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHard.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHard.ForeColor = System.Drawing.Color.White;
			this.btnHard.Location = new System.Drawing.Point(331, 218);
			this.btnHard.Name = "btnHard";
			this.btnHard.Size = new System.Drawing.Size(138, 60);
			this.btnHard.TabIndex = 12;
			this.btnHard.Text = "Hard";
			this.btnHard.UseVisualStyleBackColor = true;
			this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
			// 
			// lblWrongGuesses
			// 
			this.lblWrongGuesses.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWrongGuesses.ForeColor = System.Drawing.SystemColors.Window;
			this.lblWrongGuesses.Location = new System.Drawing.Point(12, 174);
			this.lblWrongGuesses.Name = "lblWrongGuesses";
			this.lblWrongGuesses.Size = new System.Drawing.Size(169, 273);
			this.lblWrongGuesses.TabIndex = 13;
			this.lblWrongGuesses.Text = "Guesses:";
			this.lblWrongGuesses.Visible = false;
			// 
			// lblDifficulty
			// 
			this.lblDifficulty.AutoSize = true;
			this.lblDifficulty.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDifficulty.ForeColor = System.Drawing.Color.White;
			this.lblDifficulty.Location = new System.Drawing.Point(243, 81);
			this.lblDifficulty.Name = "lblDifficulty";
			this.lblDifficulty.Size = new System.Drawing.Size(315, 57);
			this.lblDifficulty.TabIndex = 14;
			this.lblDifficulty.Text = "Select A Difficulty";
			// 
			// btnNormal
			// 
			this.btnNormal.FlatAppearance.BorderSize = 0;
			this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNormal.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNormal.ForeColor = System.Drawing.Color.White;
			this.btnNormal.Location = new System.Drawing.Point(187, 218);
			this.btnNormal.Name = "btnNormal";
			this.btnNormal.Size = new System.Drawing.Size(138, 60);
			this.btnNormal.TabIndex = 15;
			this.btnNormal.Text = "Normal";
			this.btnNormal.UseVisualStyleBackColor = true;
			this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
			// 
			// btnImpossible
			// 
			this.btnImpossible.FlatAppearance.BorderSize = 0;
			this.btnImpossible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImpossible.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImpossible.ForeColor = System.Drawing.Color.White;
			this.btnImpossible.Location = new System.Drawing.Point(475, 218);
			this.btnImpossible.Name = "btnImpossible";
			this.btnImpossible.Size = new System.Drawing.Size(138, 60);
			this.btnImpossible.TabIndex = 16;
			this.btnImpossible.Text = "Impossible";
			this.btnImpossible.UseVisualStyleBackColor = true;
			this.btnImpossible.Click += new System.EventHandler(this.btnImpossible_Click);
			// 
			// frmHangman
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnImpossible);
			this.Controls.Add(this.btnNormal);
			this.Controls.Add(this.lblDifficulty);
			this.Controls.Add(this.btnHard);
			this.Controls.Add(this.lblWrongGuesses);
			this.Controls.Add(this.headCover);
			this.Controls.Add(this.armCover2);
			this.Controls.Add(this.armCover1);
			this.Controls.Add(this.bodyCover);
			this.Controls.Add(this.legCover2);
			this.Controls.Add(this.legCover1);
			this.Controls.Add(this.eyeCover2);
			this.Controls.Add(this.eyeCover1);
			this.Controls.Add(this.picHangman);
			this.Controls.Add(this.txtGuess);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.lblWord);
			this.Name = "frmHangman";
			this.Text = "Hangman Game";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			((System.ComponentModel.ISupportInitialize)(this.picHangman)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.eyeCover1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.eyeCover2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.legCover1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.legCover2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bodyCover)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.armCover1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.armCover2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.headCover)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label lblWord;
		private System.Windows.Forms.MaskedTextBox txtGuess;
		private System.Windows.Forms.PictureBox picHangman;
		private System.Windows.Forms.PictureBox eyeCover1;
		private System.Windows.Forms.PictureBox eyeCover2;
		private System.Windows.Forms.PictureBox legCover1;
		private System.Windows.Forms.PictureBox legCover2;
		private System.Windows.Forms.PictureBox bodyCover;
		private System.Windows.Forms.PictureBox armCover1;
		private System.Windows.Forms.PictureBox armCover2;
		private System.Windows.Forms.PictureBox headCover;
		private System.Windows.Forms.Button btnHard;
		private System.Windows.Forms.Label lblWrongGuesses;
		private System.Windows.Forms.Label lblDifficulty;
		private System.Windows.Forms.Button btnNormal;
		private System.Windows.Forms.Button btnImpossible;
	}
}

