namespace GuessingGame
{
    partial class frmGuessTheNumber
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
            this.lblGuessTheNumber = new System.Windows.Forms.Label();
            this.gbGuess = new System.Windows.Forms.GroupBox();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblGuess = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblTries = new System.Windows.Forms.Label();
            this.gbGuess.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGuessTheNumber
            // 
            this.lblGuessTheNumber.AutoSize = true;
            this.lblGuessTheNumber.Font = new System.Drawing.Font("Ink Free", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessTheNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblGuessTheNumber.Location = new System.Drawing.Point(1, 9);
            this.lblGuessTheNumber.Name = "lblGuessTheNumber";
            this.lblGuessTheNumber.Size = new System.Drawing.Size(481, 65);
            this.lblGuessTheNumber.TabIndex = 0;
            this.lblGuessTheNumber.Text = "Guess the Number!";
            // 
            // gbGuess
            // 
            this.gbGuess.Controls.Add(this.txtGuess);
            this.gbGuess.Controls.Add(this.lblGuess);
            this.gbGuess.Location = new System.Drawing.Point(13, 88);
            this.gbGuess.Name = "gbGuess";
            this.gbGuess.Size = new System.Drawing.Size(457, 56);
            this.gbGuess.TabIndex = 1;
            this.gbGuess.TabStop = false;
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.Location = new System.Drawing.Point(345, 13);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 33);
            this.txtGuess.TabIndex = 1;
            this.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess.Location = new System.Drawing.Point(6, 16);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(330, 26);
            this.lblGuess.TabIndex = 0;
            this.lblGuess.Text = "Guess a number between 1 and 100:";
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.White;
            this.btnGuess.Font = new System.Drawing.Font("Sitka Small", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGuess.Location = new System.Drawing.Point(154, 175);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(175, 76);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(13, 270);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(457, 23);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Enter a number above, and click \'Guess\'.";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTries
            // 
            this.lblTries.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTries.ForeColor = System.Drawing.Color.Red;
            this.lblTries.Location = new System.Drawing.Point(17, 321);
            this.lblTries.Name = "lblTries";
            this.lblTries.Size = new System.Drawing.Size(453, 23);
            this.lblTries.TabIndex = 4;
            this.lblTries.Text = "You have 7 tries remaining";
            this.lblTries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGuessTheNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.gbGuess);
            this.Controls.Add(this.lblGuessTheNumber);
            this.Name = "frmGuessTheNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess the Number";
            this.Load += new System.EventHandler(this.frmGuessTheNumber_Load);
            this.gbGuess.ResumeLayout(false);
            this.gbGuess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuessTheNumber;
        private System.Windows.Forms.GroupBox gbGuess;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblTries;
    }
}

