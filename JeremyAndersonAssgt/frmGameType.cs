//INFT2012 INDIVIDUAL ASSIGNMENT
//JEREMY ANDERSON c3315176
//Date - 29/05/2020

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeremyAndersonAssgt
{
    public partial class frmGameType : Form
    {
        public frmGameType()
        {
            InitializeComponent();
        }

        private void btnTwoPlayer_Click(object sender, EventArgs e)
        {
            //check if score is valid, if not, ask for re-entry
            try
            {
                int score = Convert.ToInt32(txtbxTargetScore.Text);
                if (score >= 50 && score <= 100)
                {
                    this.Hide();
                    frmSixOfOne game = new frmSixOfOne();
                    game.setGameType(true);
                    game.setTargetScore(score);
                    game.Show();
                } else {
                    System.Windows.Forms.MessageBox.Show("Enter a valid target score!");
                }
            } catch {
                System.Windows.Forms.MessageBox.Show("Enter a valid target score!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check if score is valid, if not, ask for re-entry
            try
            {
                int score = Convert.ToInt32(txtbxTargetScore.Text);
                if (score >= 50 && score <= 100)
                {
                    this.Hide();
                    frmSixOfOne game = new frmSixOfOne();
                    game.setGameType(false);
                    game.setTargetScore(score);
                    game.Show();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Enter a valid target score!");
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Enter a valid target score!");
            }
        }
    }
}
