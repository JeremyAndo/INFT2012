//INFT2012 INDIVIDUAL ASSIGNMENT
//JEREMY ANDERSON c3315176
//Date - 29/05/2020

namespace JeremyAndersonAssgt
{
    partial class frmGameType
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
            this.lablGameType = new System.Windows.Forms.Label();
            this.lablWelcome = new System.Windows.Forms.Label();
            this.btnTwoPlayer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lablTargetScore = new System.Windows.Forms.Label();
            this.txtbxTargetScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lablGameType
            // 
            this.lablGameType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lablGameType.AutoSize = true;
            this.lablGameType.Location = new System.Drawing.Point(64, 52);
            this.lablGameType.Name = "lablGameType";
            this.lablGameType.Size = new System.Drawing.Size(187, 26);
            this.lablGameType.TabIndex = 0;
            this.lablGameType.Text = "Enter the target score for the player(s) \r\nthen select the game type!";
            this.lablGameType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lablWelcome
            // 
            this.lablWelcome.AutoSize = true;
            this.lablWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablWelcome.Location = new System.Drawing.Point(73, 22);
            this.lablWelcome.Name = "lablWelcome";
            this.lablWelcome.Size = new System.Drawing.Size(168, 13);
            this.lablWelcome.TabIndex = 1;
            this.lablWelcome.Text = "WELCOME TO SIX OF ONE!";
            // 
            // btnTwoPlayer
            // 
            this.btnTwoPlayer.Location = new System.Drawing.Point(56, 145);
            this.btnTwoPlayer.Name = "btnTwoPlayer";
            this.btnTwoPlayer.Size = new System.Drawing.Size(75, 75);
            this.btnTwoPlayer.TabIndex = 2;
            this.btnTwoPlayer.Text = "2 PLAYER GAME";
            this.btnTwoPlayer.UseVisualStyleBackColor = true;
            this.btnTwoPlayer.Click += new System.EventHandler(this.btnTwoPlayer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "PLAYER VS AI GAME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lablTargetScore
            // 
            this.lablTargetScore.AutoSize = true;
            this.lablTargetScore.Location = new System.Drawing.Point(56, 101);
            this.lablTargetScore.Name = "lablTargetScore";
            this.lablTargetScore.Size = new System.Drawing.Size(107, 26);
            this.lablTargetScore.TabIndex = 4;
            this.lablTargetScore.Text = "Target Score\r\n(Min - Max:  50 - 100)";
            // 
            // txtbxTargetScore
            // 
            this.txtbxTargetScore.Location = new System.Drawing.Point(190, 98);
            this.txtbxTargetScore.Name = "txtbxTargetScore";
            this.txtbxTargetScore.Size = new System.Drawing.Size(43, 20);
            this.txtbxTargetScore.TabIndex = 5;
            // 
            // frmGameType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.txtbxTargetScore);
            this.Controls.Add(this.lablTargetScore);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTwoPlayer);
            this.Controls.Add(this.lablWelcome);
            this.Controls.Add(this.lablGameType);
            this.Name = "frmGameType";
            this.Text = "Six Of One - Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lablGameType;
        private System.Windows.Forms.Label lablWelcome;
        private System.Windows.Forms.Button btnTwoPlayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lablTargetScore;
        private System.Windows.Forms.TextBox txtbxTargetScore;
    }
}