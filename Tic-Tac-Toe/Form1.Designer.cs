namespace Tic_Tac_Toe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.turn = new System.Windows.Forms.Label();
            this.winner = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pctTL = new System.Windows.Forms.PictureBox();
            this.pctTM = new System.Windows.Forms.PictureBox();
            this.pctTR = new System.Windows.Forms.PictureBox();
            this.pctML = new System.Windows.Forms.PictureBox();
            this.pctMM = new System.Windows.Forms.PictureBox();
            this.pctMR = new System.Windows.Forms.PictureBox();
            this.pctBL = new System.Windows.Forms.PictureBox();
            this.pctBM = new System.Windows.Forms.PictureBox();
            this.pctBR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(366, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 96);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tic-Tac-Toe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(121, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 73);
            this.label2.TabIndex = 10;
            this.label2.Text = "Turn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(135, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 73);
            this.label3.TabIndex = 11;
            this.label3.Text = "____";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(93, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 73);
            this.label4.TabIndex = 12;
            this.label4.Text = "Winner";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(107, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 73);
            this.label5.TabIndex = 13;
            this.label5.Text = "______";
            // 
            // turn
            // 
            this.turn.AutoSize = true;
            this.turn.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.turn.Location = new System.Drawing.Point(104, 210);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(197, 58);
            this.turn.TabIndex = 14;
            this.turn.Tag = "1";
            this.turn.Text = "Player 1";
            // 
            // winner
            // 
            this.winner.AutoSize = true;
            this.winner.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winner.ForeColor = System.Drawing.Color.Lime;
            this.winner.Location = new System.Drawing.Point(86, 413);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(263, 58);
            this.winner.TabIndex = 15;
            this.winner.Tag = "-1";
            this.winner.Text = "In Progress";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(109, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 51);
            this.button1.TabIndex = 16;
            this.button1.Text = "Restart Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pctTL
            // 
            this.pctTL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pctTL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctTL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctTL.Image = global::Tic_Tac_Toe.Properties.Resources.Question;
            this.pctTL.Location = new System.Drawing.Point(446, 163);
            this.pctTL.Name = "pctTL";
            this.pctTL.Size = new System.Drawing.Size(124, 105);
            this.pctTL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctTL.TabIndex = 0;
            this.pctTL.TabStop = false;
            this.pctTL.Tag = "Q";
            this.pctTL.Click += new System.EventHandler(this.picture_Click);
            // 
            // pctTM
            // 
            this.pctTM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctTM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctTM.Image = global::Tic_Tac_Toe.Properties.Resources.Question;
            this.pctTM.Location = new System.Drawing.Point(613, 163);
            this.pctTM.Name = "pctTM";
            this.pctTM.Size = new System.Drawing.Size(124, 105);
            this.pctTM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctTM.TabIndex = 1;
            this.pctTM.TabStop = false;
            this.pctTM.Tag = "Q";
            this.pctTM.Click += new System.EventHandler(this.picture_Click);
            // 
            // pctTR
            // 
            this.pctTR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctTR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctTR.Image = global::Tic_Tac_Toe.Properties.Resources.Question;
            this.pctTR.Location = new System.Drawing.Point(778, 163);
            this.pctTR.Name = "pctTR";
            this.pctTR.Size = new System.Drawing.Size(124, 105);
            this.pctTR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctTR.TabIndex = 2;
            this.pctTR.TabStop = false;
            this.pctTR.Tag = "Q";
            this.pctTR.Click += new System.EventHandler(this.picture_Click);
            // 
            // pctML
            // 
            this.pctML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctML.Image = global::Tic_Tac_Toe.Properties.Resources.Question;
            this.pctML.Location = new System.Drawing.Point(446, 331);
            this.pctML.Name = "pctML";
            this.pctML.Size = new System.Drawing.Size(124, 105);
            this.pctML.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctML.TabIndex = 3;
            this.pctML.TabStop = false;
            this.pctML.Tag = "Q";
            this.pctML.Click += new System.EventHandler(this.picture_Click);
            // 
            // pctMM
            // 
            this.pctMM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctMM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMM.Image = global::Tic_Tac_Toe.Properties.Resources.Question;
            this.pctMM.Location = new System.Drawing.Point(613, 331);
            this.pctMM.Name = "pctMM";
            this.pctMM.Size = new System.Drawing.Size(124, 105);
            this.pctMM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctMM.TabIndex = 4;
            this.pctMM.TabStop = false;
            this.pctMM.Tag = "Q";
            this.pctMM.Click += new System.EventHandler(this.picture_Click);
            // 
            // pctMR
            // 
            this.pctMR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctMR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMR.Image = global::Tic_Tac_Toe.Properties.Resources.Question;
            this.pctMR.Location = new System.Drawing.Point(778, 331);
            this.pctMR.Name = "pctMR";
            this.pctMR.Size = new System.Drawing.Size(124, 105);
            this.pctMR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctMR.TabIndex = 5;
            this.pctMR.TabStop = false;
            this.pctMR.Tag = "Q";
            this.pctMR.Click += new System.EventHandler(this.picture_Click);
            // 
            // pctBL
            // 
            this.pctBL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctBL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctBL.Image = global::Tic_Tac_Toe.Properties.Resources.Question;
            this.pctBL.Location = new System.Drawing.Point(446, 493);
            this.pctBL.Name = "pctBL";
            this.pctBL.Size = new System.Drawing.Size(124, 105);
            this.pctBL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBL.TabIndex = 6;
            this.pctBL.TabStop = false;
            this.pctBL.Tag = "Q";
            this.pctBL.Click += new System.EventHandler(this.picture_Click);
            // 
            // pctBM
            // 
            this.pctBM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctBM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctBM.Image = global::Tic_Tac_Toe.Properties.Resources.Question;
            this.pctBM.Location = new System.Drawing.Point(613, 493);
            this.pctBM.Name = "pctBM";
            this.pctBM.Size = new System.Drawing.Size(124, 105);
            this.pctBM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBM.TabIndex = 7;
            this.pctBM.TabStop = false;
            this.pctBM.Tag = "Q";
            this.pctBM.Click += new System.EventHandler(this.picture_Click);
            // 
            // pctBR
            // 
            this.pctBR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctBR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctBR.Image = global::Tic_Tac_Toe.Properties.Resources.Question;
            this.pctBR.Location = new System.Drawing.Point(778, 493);
            this.pctBR.Name = "pctBR";
            this.pctBR.Size = new System.Drawing.Size(124, 105);
            this.pctBR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBR.TabIndex = 8;
            this.pctBR.TabStop = false;
            this.pctBR.Tag = "Q";
            this.pctBR.Click += new System.EventHandler(this.picture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1268, 675);
            this.Controls.Add(this.pctBR);
            this.Controls.Add(this.pctBM);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pctBL);
            this.Controls.Add(this.winner);
            this.Controls.Add(this.pctMR);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.pctMM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pctML);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pctTR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pctTM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctTL);
            this.Controls.Add(this.label3);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pctTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label turn;
        private System.Windows.Forms.Label winner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pctTL;
        private System.Windows.Forms.PictureBox pctTM;
        private System.Windows.Forms.PictureBox pctTR;
        private System.Windows.Forms.PictureBox pctML;
        private System.Windows.Forms.PictureBox pctMM;
        private System.Windows.Forms.PictureBox pctMR;
        private System.Windows.Forms.PictureBox pctBL;
        private System.Windows.Forms.PictureBox pctBM;
        private System.Windows.Forms.PictureBox pctBR;
    }
}

