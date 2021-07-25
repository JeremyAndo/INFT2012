//INFT2012 INDIVIDUAL ASSIGNMENT
//JEREMY ANDERSON c3315176
//Date - 29/05/2020

namespace JeremyAndersonAssgt
{
    partial class frmSixOfOne
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
            this.picbxDice = new System.Windows.Forms.PictureBox();
            this.btnTakeTurn = new System.Windows.Forms.Button();
            this.lablPlayerTurn = new System.Windows.Forms.Label();
            this.txtbxNoOfDice = new System.Windows.Forms.TextBox();
            this.lablNoOfDice = new System.Windows.Forms.Label();
            this.lablWhichPlayer = new System.Windows.Forms.Label();
            this.lablScore = new System.Windows.Forms.Label();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.lablComments = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice)).BeginInit();
            this.SuspendLayout();
            // 
            // picbxDice
            // 
            this.picbxDice.Location = new System.Drawing.Point(50, 50);
            this.picbxDice.Name = "picbxDice";
            this.picbxDice.Size = new System.Drawing.Size(500, 300);
            this.picbxDice.TabIndex = 0;
            this.picbxDice.TabStop = false;
            // 
            // btnTakeTurn
            // 
            this.btnTakeTurn.Location = new System.Drawing.Point(677, 159);
            this.btnTakeTurn.Name = "btnTakeTurn";
            this.btnTakeTurn.Size = new System.Drawing.Size(75, 23);
            this.btnTakeTurn.TabIndex = 1;
            this.btnTakeTurn.Text = "Take Turn";
            this.btnTakeTurn.UseVisualStyleBackColor = true;
            this.btnTakeTurn.Click += new System.EventHandler(this.btnTakeTurn_Click);
            // 
            // lablPlayerTurn
            // 
            this.lablPlayerTurn.AutoSize = true;
            this.lablPlayerTurn.Location = new System.Drawing.Point(575, 74);
            this.lablPlayerTurn.Name = "lablPlayerTurn";
            this.lablPlayerTurn.Size = new System.Drawing.Size(113, 13);
            this.lablPlayerTurn.TabIndex = 2;
            this.lablPlayerTurn.Text = "Time to take your turn:";
            // 
            // txtbxNoOfDice
            // 
            this.txtbxNoOfDice.Location = new System.Drawing.Point(698, 111);
            this.txtbxNoOfDice.Name = "txtbxNoOfDice";
            this.txtbxNoOfDice.Size = new System.Drawing.Size(54, 20);
            this.txtbxNoOfDice.TabIndex = 3;
            // 
            // lablNoOfDice
            // 
            this.lablNoOfDice.AutoSize = true;
            this.lablNoOfDice.Location = new System.Drawing.Point(578, 111);
            this.lablNoOfDice.Name = "lablNoOfDice";
            this.lablNoOfDice.Size = new System.Drawing.Size(98, 26);
            this.lablNoOfDice.TabIndex = 4;
            this.lablNoOfDice.Text = "How many dice do \r\nyou wish to roll?";
            // 
            // lablWhichPlayer
            // 
            this.lablWhichPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lablWhichPlayer.AutoSize = true;
            this.lablWhichPlayer.ForeColor = System.Drawing.Color.Red;
            this.lablWhichPlayer.Location = new System.Drawing.Point(707, 74);
            this.lablWhichPlayer.Name = "lablWhichPlayer";
            this.lablWhichPlayer.Size = new System.Drawing.Size(45, 13);
            this.lablWhichPlayer.TabIndex = 5;
            this.lablWhichPlayer.Text = "Player 1";
            this.lablWhichPlayer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lablScore
            // 
            this.lablScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lablScore.AutoSize = true;
            this.lablScore.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablScore.Location = new System.Drawing.Point(573, 197);
            this.lablScore.Name = "lablScore";
            this.lablScore.Size = new System.Drawing.Size(88, 25);
            this.lablScore.TabIndex = 6;
            this.lablScore.Text = "SCORE\r\n";
            // 
            // btnExitApp
            // 
            this.btnExitApp.Location = new System.Drawing.Point(578, 159);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(75, 23);
            this.btnExitApp.TabIndex = 7;
            this.btnExitApp.Text = "Quit Game";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // lablComments
            // 
            this.lablComments.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lablComments.AutoSize = true;
            this.lablComments.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablComments.Location = new System.Drawing.Point(573, 294);
            this.lablComments.Name = "lablComments";
            this.lablComments.Size = new System.Drawing.Size(142, 25);
            this.lablComments.TabIndex = 8;
            this.lablComments.Text = "COMMENTS";
            // 
            // frmSixOfOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.lablComments);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.lablScore);
            this.Controls.Add(this.lablWhichPlayer);
            this.Controls.Add(this.lablNoOfDice);
            this.Controls.Add(this.txtbxNoOfDice);
            this.Controls.Add(this.lablPlayerTurn);
            this.Controls.Add(this.btnTakeTurn);
            this.Controls.Add(this.picbxDice);
            this.Name = "frmSixOfOne";
            this.Text = "Six Of One - Game";
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxDice;
        private System.Windows.Forms.Button btnTakeTurn;
        private System.Windows.Forms.Label lablPlayerTurn;
        private System.Windows.Forms.TextBox txtbxNoOfDice;
        private System.Windows.Forms.Label lablNoOfDice;
        private System.Windows.Forms.Label lablWhichPlayer;
        private System.Windows.Forms.Label lablScore;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Label lablComments;
    }
}

