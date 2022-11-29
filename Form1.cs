using HangMan.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Label> bodyParts = new Dictionary<string, Label>();

        private Game game = new Game();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Setup();
        }


        private void Setup()
        {

            // Setup body parts to display properly
            bodyParts.Add("hanger", hangerLabel);
            bodyParts.Add("head", headLabel);
            bodyParts.Add("body", bodyLabel);
            bodyParts.Add("leftArm", leftArmLabel);
            bodyParts.Add("rightArm", rightArmLabel);
            bodyParts.Add("legs", legsLabel);

            // Hide them all
            foreach(var l in bodyParts)
            {
                l.Value.Hide();
            }


            // Initiate new game
            game.Initiate();

            // Set word label and letters used label properly
            UpdateInfo();
            lettersUsedLabel.Text = "";

            // Set tries number
            triesLeftLabel.Text = game.tries.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            RevealLetter(textBox1.Text);

            textBox1.Text = "";
            textBox1.Focus();
        }


        private void UpdateInfo()
        {
            // Update letters found
            wordLabel.Text = "";
            foreach (var c in game.discoveredLetters)
            {
                if (c.Value == false)
                    wordLabel.Text += "- ";
                else
                    wordLabel.Text += c.Key.ToString() + " ";
            }

            // Update used letters label
            lettersUsedLabel.Text = "";
            foreach(char c in game.usedLetters)
            {
                if (!lettersUsedLabel.Text.Contains(c))
                    lettersUsedLabel.Text += c.ToString() + " ";
            }

            // Update tries
            triesLeftLabel.Text = game.tries.ToString();
        }


        private void RevealLetter(string letter)
        {
            
            if(lettersUsedLabel.Text.Contains(letter))
            {
                MessageBox.Show("You've already used the letter " + letter.ToUpper());
                return;
            }

            if(game.GuessLetter(letter))
            {
                MessageBox.Show("Letter " + letter + " found in word! Good job!");
            }
            else
            {
                MessageBox.Show("No '" + letter + "' found in word...");

                NextHangStep();
            }

            UpdateInfo();



            // Check if game is over
            if (game.tries < 0)
            {
                triesLeftLabel.Text = "-";

                Helper.App.YesNoDialog("Would you like to start a new game?", "GAME OVER", () =>
                {
                    game.Initiate();

                    // Hide all body parts
                    foreach (var l in bodyParts)
                    {
                        l.Value.Hide();
                    }

                    UpdateInfo();

                }, () =>
                {
                    MessageBox.Show("Thanks for playing");
                    Application.Exit();
                });
            }

            // Check if won
            if (Helper.Strings.RemoveSpaces(wordLabel.Text).ToLower().Equals(game.GetWord().ToLower()))
                Win();
        }

        private void Win()
        {
            Helper.App.YesNoDialog("Congratulations! You have successfully guessed the word. Total guessed words: " + (++game.score).ToString() +
                ". Would you like to" +
                " play another game?", "GOOD JOB", () =>
                {
                    game.score++;
                    game.Initiate();

                    // Hide all body parts
                    foreach (var l in bodyParts)
                    {
                        l.Value.Hide();
                    }

                    UpdateInfo();
                }, () =>
                {
                    MessageBox.Show("Thank you for playing!");
                    Application.Exit();
                });
        }

        private void NextHangStep()
        {
            switch(game.tries)
            {
                case 5:
                    bodyParts["hanger"].Show();
                    break;
                case 4:
                    bodyParts["head"].Show();
                    break;
                case 3:
                    bodyParts["body"].Show();
                    break;
                case 2:
                    bodyParts["leftArm"].Show();
                    break;
                case 1:
                    bodyParts["rightArm"].Show();
                    break;
                case 0:
                    bodyParts["legs"].Show();
                    break;
                default:
                    break;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Stop playing 'ding' when enter is pressed
                e.Handled = true;
                //

                button1.PerformClick();
            }
        }
    }
}
