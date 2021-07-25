//INFT2012 INDIVIDUAL ASSIGNMENT
//JEREMY ANDERSON c3315176
//Date - 29/05/2020

//===============================================================================
//Code used in this project was sourced from Course Resources or previous assignments and online websites
//Previous assignments were done by myself in previous years in courses such as SENG1110/1120 e.g. Switch statements
//External help for pausing time to allow the AI to "think" was found via this link:
//https://www.codeproject.com/Questions/845104/How-to-pause-execution-of-Csharp-code-using-timer
//Used at 6:24pm on the 29th of May 2020
//And uses this code: Thread.Sleep(1000);

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeremyAndersonAssgt
{
    public partial class frmSixOfOne : Form
    {
        //delcare Graphics Object
        Graphics graPaper;
        //data for type of game e.g. vs AI or player
        bool twoPlayerGame;
        public void setGameType(bool x) { twoPlayerGame = x; }
        //declare and intialise number generator for die roll
        Random rnd = new Random();
        //declare and initialise score objects for players
        int playerOne = 0;
        int playerTwo = 0;
        int playerAI = 0;
        //Default target score and setter for frmGameType
        int targetScore = 50;
        public void setTargetScore(int x) { targetScore = x;  }
        //create a counter for duplicates of numbers
        //RESET AFTER EACH TURN
        int numberOnes = 0,
            numberTwos = 0,
            numberThrees = 0,
            numberFours = 0,
            numberFives = 0,
            numberSixes = 0;

        public frmSixOfOne()
        {
            InitializeComponent();
            //initialise Graphics Object
            graPaper = picbxDice.CreateGraphics();
        }

        //uses rnd to produce a dice roll
        public int rollDice(int x, int y)
        {
            //Roll Dice Data
            int number;
            number = rnd.Next(1, 7);

            //Roll Dice Graphic
            switch (number)
            {
                case 1:
                    rollNumberOne(x, y); numberOnes++;
                    break;
                case 2:
                    rollNumberTwo(x, y); numberTwos++;
                    break;
                case 3:
                    rollNumberThree(x, y); numberThrees++;
                    break;
                case 4:
                    rollNumberFour(x, y); numberFours++;
                    break;
                case 5:
                    rollNumberFive(x, y); numberFives++;
                    break;
                case 6:
                    rollNumberSix(x, y); numberSixes++;
                    break;
            }
            //Return Number for Scoring
            return number;
        }

        //used to calculate games scores
        public void gameLogic()
        {
            //create a temp score object
            int tempScore = 0;

            if (numberOnes == 1)
            {
                //1 x No.1 is Rolled - DO NOTHING
                lablComments.Text = "COMMENTS \n1 x No.1 Rolled\nNo score changes";
            }
            else if (numberOnes == 2)
            {
                //2 x No.1 is Rolled - SET CURRENT PLAYERS SCORE TO ZERO
                lablComments.Text = "COMMENTS \nSnake eyes\n" + lablWhichPlayer.Text + "score set to 0";
                if (lablWhichPlayer.Text == "Player 1")
                    playerOne = 0;
                else if (lablWhichPlayer.Text == "Player 2")
                    playerTwo = 0;
                else
                    playerAI = 0;
            }
            else if (numberOnes == 3)
            {
                //3 x No.1 is Rolled - CURRENT PLAYER LOSES THE GAME
                //If -1 player score is found, player loses
                lablComments.Text = "COMMENTS \nDead drop\n" + lablWhichPlayer.Text + " loses";
                if (lablWhichPlayer.Text == "Player 1")
                    playerOne = -1;
                else if (lablWhichPlayer.Text == "Player 2")
                    playerTwo = -1;
                else
                    playerAI = -1;
            }
            else if (numberOnes == 4 || numberOnes == 5 || numberOnes == 6)
            {
                //(4+) x No.1 is Rolled - CURRENT PLAYER WINS THE GAME
                lablComments.Text = "COMMENTS \nBoojum\n" + lablWhichPlayer.Text + " wins";
                if (lablWhichPlayer.Text == "Player 1")
                    playerOne = targetScore;
                else if (lablWhichPlayer.Text == "Player 2")
                    playerTwo = targetScore;
                else
                    playerAI = targetScore;
            }
            else if (numberOnes == 0 || numberTwos == 3 || numberThrees == 3
            || numberFours == 3 || numberFives == 3 || numberSixes == 3)
            {
                //0 x No.1 or 3 x Any other is Rolled - 2 TIMES SUM ON DICE ADDED TO SCORE
                //calculate score
                tempScore = 2 * ((numberOnes * 1) + (numberTwos * 2) + (numberThrees * 3)
                + (numberFours * 4) + (numberFives * 5) + (numberSixes * 6));
                //add to correct player
                lablComments.Text = "COMMENTS \n" + lablWhichPlayer.Text + " receives " + tempScore;
                if (lablWhichPlayer.Text == "Player 1")
                    playerOne += tempScore;
                else if (lablWhichPlayer.Text == "Player 2")
                    playerTwo += tempScore;
                else
                    playerAI += tempScore;
            }
            else
            {
                //Otherwise - SUM ON DICE ADDED TO SCORE
                //calculate score
                tempScore = ((numberOnes * 1) + (numberTwos * 2) + (numberThrees * 3)
                + (numberFours * 4) + (numberFives * 5) + (numberSixes * 6));
                //add to correct player
                lablComments.Text = "COMMENTS \n" + lablWhichPlayer.Text + " receives " + tempScore;
                if (lablWhichPlayer.Text == "Player 1")
                    playerOne += tempScore;
                else if (lablWhichPlayer.Text == "Player 2")
                    playerTwo += tempScore;
                else
                    playerAI += tempScore;
            }

            //RESET COUNTERS FOR DUPLICATES OF NUMBERS AFTER TURN
            numberOnes = 0; numberTwos = 0; numberThrees = 0;
            numberFours = 0; numberFives = 0; numberSixes = 0;
        }

        //Roll the dice
        public void executeTurn(int NoOfDice)
        {
            switch (NoOfDice)
            {
                case 1:
                    //Roll Dice A
                    graPaper.Clear(Form.DefaultBackColor);
                    rollDice(25, 25);
                    break;
                case 2:
                    //Roll Dice A and B
                    graPaper.Clear(Form.DefaultBackColor);
                    rollDice(25, 25);
                    rollDice(25, 175);
                    break;
                case 3:
                    //Roll Dice A, B and C
                    graPaper.Clear(Form.DefaultBackColor);
                    rollDice(25, 25);
                    rollDice(25, 175);
                    rollDice(175, 25);
                    break;
                case 4:
                    //Roll Dice A, B, C and D
                    graPaper.Clear(Form.DefaultBackColor);
                    rollDice(25, 25);
                    rollDice(25, 175);
                    rollDice(175, 25);
                    rollDice(175, 175);
                    break;
                case 5:
                    //Roll Dice A, B, C, D and E
                    graPaper.Clear(Form.DefaultBackColor);
                    rollDice(25, 25);
                    rollDice(25, 175);
                    rollDice(175, 25);
                    rollDice(175, 175);
                    rollDice(325, 25);
                    break;
                case 6:
                    //Roll All Dice
                    graPaper.Clear(Form.DefaultBackColor);
                    rollDice(25, 25);
                    rollDice(25, 175);
                    rollDice(175, 25);
                    rollDice(175, 175);
                    rollDice(325, 25);
                    rollDice(325, 175);
                    break;
            }
        }


        //When clicked, user executes their turn
        //If AI is playing, their turn is also executed
        private void btnTakeTurn_Click(object sender, EventArgs e)
        {
            //set defaults before executing turn
            int NoOfDice = 0;

            //To catch error if no input exist or input is not an integer
            try
            {
                NoOfDice = Convert.ToInt32(txtbxNoOfDice.Text);
                //check if input is between 1 and 6 for dice roll
                if (NoOfDice > 0 && NoOfDice < 7)
                {
                    //call execute turn to roll the amount of dice
                    executeTurn(NoOfDice);

                    //Now that rolls have take place, use the game logic to calculate scores
                    gameLogic();

                    //Update players score on label
                    if (twoPlayerGame == true){
                        lablScore.Text = "SCORE \nPlayer 1: " + playerOne + "\nPlayer 2: " + playerTwo;
                    } else {
                        lablScore.Text = "SCORE \nPlayer 1: " + playerOne + "\nAI Player: " + playerAI;
                    }

                    //Check if game should end
                    //P1 reaches target score or other player loses
                    if (playerOne >= targetScore || playerTwo == -1 || playerAI == -1)
                    {
                        System.Windows.Forms.MessageBox.Show("PLAYER ONE WINS THE GAME!");
                    }
                    //player one loses the game instantly so P2 or AI wins
                    else if (playerOne == -1)
                    {
                        if (twoPlayerGame == true)
                            //p2 win
                            System.Windows.Forms.MessageBox.Show("PLAYER TWO WINS THE GAME!");
                        else
                            //AI win
                            System.Windows.Forms.MessageBox.Show("THE AI PLAYER WINS THE GAME!");
                    }
                    //P2 reaches target score
                    else if (playerTwo >= targetScore)
                    {
                        System.Windows.Forms.MessageBox.Show("PLAYER TWO WINS THE GAME!");
                    }
                    //AI reaches target score
                    else if (playerAI >= targetScore)
                    {
                        System.Windows.Forms.MessageBox.Show("THE AI PLAYER WINS THE GAME!");
                    }
                    //game does not end
                    else
                    {
                        //check if AI is playing, if so run their turn, otherwise run as normal
                        if (twoPlayerGame == false)
                        {
                            //AI IS PLAYING
                            lablWhichPlayer.Text = "AI Player";
                            System.Windows.Forms.MessageBox.Show("AI Player is taking their turn!");
                            Thread.Sleep(1000);
                            //AI selects number of dice to roll
                            int numberAI = rnd.Next(1, 7);
                            //AI rolls selected amount of dice and turn occurs
                            executeTurn(numberAI);
                            //AI score is calculated
                            gameLogic();
                            //update score
                            lablScore.Text = "SCORE \nPlayer 1: " + playerOne + "\nAI Player: " + playerAI;
                            //update Label to go to player 1
                            lablWhichPlayer.Text = "Player 1";

                        } else {
                            //update NORMAL PLAYER LABELS
                            if (lablWhichPlayer.Text == "Player 1")
                                lablWhichPlayer.Text = "Player 2";
                            else
                                lablWhichPlayer.Text = "Player 1";
                        }
                    }
                }
                else
                {
                    //Return a pop-up for incorrect entry outside of 1-6 boundary
                    System.Windows.Forms.MessageBox.Show("ERROR 2: Please enter a valid integer between 1 and 6!");
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("ERROR 1: Please enter a valid integer between 1 and 6!");
            }

        }

        //DIE ROLL
        //ROLL NUMBER ONE
        public void rollNumberOne(int x, int y)
        {
            graPaper.FillRectangle(Brushes.White, x, y, 100, 100);
            graPaper.FillEllipse(Brushes.Black, x + 40, y + 40, 20, 20);
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //ROLL NUMBER TWO
        public void rollNumberTwo(int x, int y)
        {
            graPaper.FillRectangle(Brushes.White, x, y, 100, 100);
            graPaper.FillEllipse(Brushes.Black, x + 10, y + 10, 20, 20);
            graPaper.FillEllipse(Brushes.Black, x + 70, y + 70, 20, 20);
        }
        //ROLL NUMBER THREE
        public void rollNumberThree(int x, int y)
        {
            graPaper.FillRectangle(Brushes.White, x, y, 100, 100);
            graPaper.FillEllipse(Brushes.Black, x + 40, y + 40, 20, 20);
            graPaper.FillEllipse(Brushes.Black, x + 10, y + 10, 20, 20);
            graPaper.FillEllipse(Brushes.Black, x + 70, y + 70, 20, 20);
        }
        //ROLL NUMBER FOUR
        public void rollNumberFour(int x, int y)
        {
            graPaper.FillRectangle(Brushes.White, x, y, 100, 100);
            graPaper.FillEllipse(Brushes.Black, x + 10, y + 10, 20, 20);
            graPaper.FillEllipse(Brushes.Black, x + 70, y + 10, 20, 20);
            graPaper.FillEllipse(Brushes.Black, x + 10, y + 70, 20, 20);
            graPaper.FillEllipse(Brushes.Black, x + 70, y + 70, 20, 20);
        }
        //ROLL NUMBER FIVE
        public void rollNumberFive(int x, int y)
        {
            graPaper.FillRectangle(Brushes.White, x, y, 100, 100);
            graPaper.FillEllipse(Brushes.Black, x + 40, y + 40, 20, 20);
            graPaper.FillEllipse(Brushes.Black, x + 10, y + 10, 20, 20);
            graPaper.FillEllipse(Brushes.Black, x + 70, y + 10, 20, 20);
            graPaper.FillEllipse(Brushes.Black, x + 10, y + 70, 20, 20);
            graPaper.FillEllipse(Brushes.Black, x + 70, y + 70, 20, 20);
        }
        //ROLL NUMBER SIX
        public void rollNumberSix(int x, int y)
        {
            graPaper.FillRectangle(Brushes.White, x, y, 100, 100);
            graPaper.FillEllipse(Brushes.Black, x + 10, y + 40, 20, 20);
            graPaper.FillEllipse(Brushes.Black, x + 70, y + 40, 20, 20);
            graPaper.FillEllipse(Brushes.Black, x + 10, y + 10, 20, 20);
            graPaper.FillEllipse(Brushes.Black, x + 70, y + 10, 20, 20);
            graPaper.FillEllipse(Brushes.Black, x + 10, y + 70, 20, 20);
            graPaper.FillEllipse(Brushes.Black, x + 70, y + 70, 20, 20);
        }
    }
}
