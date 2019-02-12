namespace GuessingGame
{
    partial class frmGameLevel
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
            this.lblChooseLevel = new System.Windows.Forms.Label();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblHundred = new System.Windows.Forms.Label();
            this.lblThousand = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChooseLevel
            // 
            this.lblChooseLevel.AutoSize = true;
            this.lblChooseLevel.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseLevel.ForeColor = System.Drawing.Color.Black;
            this.lblChooseLevel.Location = new System.Drawing.Point(40, 11);
            this.lblChooseLevel.Name = "lblChooseLevel";
            this.lblChooseLevel.Size = new System.Drawing.Size(261, 30);
            this.lblChooseLevel.TabIndex = 0;
            this.lblChooseLevel.Text = "Choose a Level to Play";
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.LightGreen;
            this.btnEasy.Font = new System.Drawing.Font("Sitka Small", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.Location = new System.Drawing.Point(2, 66);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(106, 37);
            this.btnEasy.TabIndex = 1;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.Color.Orange;
            this.btnMedium.Font = new System.Drawing.Font("Sitka Small", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.Location = new System.Drawing.Point(114, 66);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(106, 37);
            this.btnMedium.TabIndex = 2;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.Crimson;
            this.btnHard.Font = new System.Drawing.Font("Sitka Small", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.Location = new System.Drawing.Point(226, 66);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(106, 37);
            this.btnHard.TabIndex = 3;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(33, 114);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(45, 23);
            this.lblTen.TabIndex = 4;
            this.lblTen.Text = "1 - 10";
            // 
            // lblHundred
            // 
            this.lblHundred.AutoSize = true;
            this.lblHundred.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHundred.Location = new System.Drawing.Point(140, 114);
            this.lblHundred.Name = "lblHundred";
            this.lblHundred.Size = new System.Drawing.Size(55, 23);
            this.lblHundred.TabIndex = 5;
            this.lblHundred.Text = "1 - 100";
            // 
            // lblThousand
            // 
            this.lblThousand.AutoSize = true;
            this.lblThousand.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThousand.Location = new System.Drawing.Point(247, 114);
            this.lblThousand.Name = "lblThousand";
            this.lblThousand.Size = new System.Drawing.Size(65, 23);
            this.lblThousand.TabIndex = 6;
            this.lblThousand.Text = "1 - 1000";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(111, 169);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 30);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmGameLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblThousand);
            this.Controls.Add(this.lblHundred);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.lblChooseLevel);
            this.Name = "frmGameLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Level";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseLevel;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblHundred;
        private System.Windows.Forms.Label lblThousand;
        private System.Windows.Forms.Button btnExit;
    }
}