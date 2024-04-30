using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

// # of impossible_words: 466550
// # of words_alpha: 370105
// # of words: 10000

namespace Hangman
{
	public partial class frmHangman : Form
	{
		private char[] SplitWord;
		private List<char> guesses = new List<char>();
		private string word;
		private int mistakes = 0;
		private string difficulty = "";

		public frmHangman()
		{
			InitializeComponent();
		}

		private void btnNormal_Click(object sender, EventArgs e)
		{
			setupGUI();
			difficulty = "Normal";
		}

		private void btnHard_Click(object sender, EventArgs e)
		{
			setupGUI();
			difficulty = "Hard";
		}

		private void btnImpossible_Click(object sender, EventArgs e)
		{
			setupGUI();
			difficulty = "Impossible";
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (btnStart.Text == "Start")
			{
				txtGuess.Enabled = true;
				txtGuess.Focus();
				btnStart.Text = "Restart";
				
				getWord();

				SplitWord = word.ToCharArray();

				lblWord.Text = "";

				foreach (char letter in SplitWord) 
				{
					lblWord.Text += "_ ";
				}
			}
			else
			{
				btnStart.Text = "Start";
				lblWord.ForeColor = Color.White;
				lblWord.Text = "";
				lblWrongGuesses.Text = "Guesses:";
				txtGuess.Enabled = false;
				SplitWord = null;
				guesses = new List<char>();
				word = "";
				mistakes = 0;

				RestartGUI();
			}
		}

		private void txtGuess_KeyPress(object sender, KeyPressEventArgs e)
		{
			Char keypressed = e.KeyChar;
			try
			{
				if (keypressed == '\r')
				{
					char letterguess = Convert.ToChar(txtGuess.Text);
					bool mistake = true;

					if (guesses.Contains(letterguess)) //if letter already guessed, no penalty because I am nice
					{
						mistake = false;
					}
					else //if letter not already guessed
					{ 
						showLetters(letterguess, ref mistake); // if the guessed letter is in the word, show all instances of it in the GUI
					}

					if (mistake)
					{
						updateGUI(letterguess); // add letter to guesses and show a new part of the stick figure
					}

					guesses.Add(letterguess);
					txtGuess.Text = "";
				}
			}
			catch (FormatException)
			{

			}
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			Graphics title = e.Graphics;
			title.DrawString("Hangman", new Font("Segoe Print", 36, FontStyle.Bold), new SolidBrush(Color.Black), 269, 4);
			title.DrawString("Hangman", new Font("Segoe Print", 36, FontStyle.Bold), new SolidBrush(Color.White), 265, 0);
		}



		private void showLetters(char letterguess, ref bool mistake)
		{
			int counter = 0;
			foreach (char letter in SplitWord)
			{
				if (char.ToLower(letterguess) == SplitWord[counter])
				{
					lblWord.Text = lblWord.Text.Remove(counter * 2, 1); // multiply by 2 as there are spaces between the underscores
					lblWord.Text = lblWord.Text.Insert(counter * 2, letter.ToString());
					mistake = false;
					if (!lblWord.Text.Contains("_")) //if there are no missing letter remaining
					{
						lblWord.ForeColor = Color.Green;
						txtGuess.Enabled = false;
					}
				}
						
				counter++;
			}
		}

		private void updateGUI(char letterguess)
		{
			mistakes++;
			switch (mistakes)
			{
				case 1:
					headCover.Hide();
					break;
				case 2:
					bodyCover.Hide();
					break;
				case 3:
					armCover1.Hide();
					break;
				case 4:
					armCover2.Hide();
					break;
				case 5:
					legCover1.Hide();
					break;
				case 6:
					legCover2.Hide();
					break;
				case 7:
					eyeCover1.Hide();
					break;
				case 8:
					eyeCover2.Hide();
					break;
				default: //if the user fails with no remaining parts left
					lblWord.ForeColor = Color.Red;
					lblWord.Text = "";
					foreach (char letter in SplitWord)
					{
						lblWord.Text += letter + " ";
					}
					txtGuess.Enabled = false;
					break;
			}
			if (mistakes % 2 != 0) //if it is an odd numbered mistake, ensures guesses list alternates columns
			{
				lblWrongGuesses.Text += "\n  " + letterguess;
			}
			else //even numbered mistake
			{
				lblWrongGuesses.Text += "   " + letterguess;
			}
		}

		private void getWord()
		{
			Random rnd = new Random();

			switch (difficulty)
			{
				case "Normal":
					word = File.ReadLines("words.txt").Skip(rnd.Next(9999)).Take(1).First().ToLower();
					txtGuess.Mask = "L";
					break;
				case "Hard":
					word = File.ReadLines("words_alpha.txt").Skip(rnd.Next(370104)).Take(1).First().ToLower();
					txtGuess.Mask = "L";
					break;
				default:
					word = File.ReadLines("impossible_words.txt").Skip(rnd.Next(466549)).Take(1).First().ToLower();
					txtGuess.Mask = "C"; //allows user to enter numbers and symbols, some are used in this word list
					break;
			}
		}

		private void setupGUI() //brings up game menu
		{
			lblWord.Show();
			btnStart.Show();
			txtGuess.Show();
			lblWrongGuesses.Show();

			picHangman.Show();
			picHangman.SendToBack();
			lblWord.SendToBack();

			headCover.Show();
			bodyCover.Show();
			armCover1.Show();
			armCover2.Show();
			legCover1.Show();
			legCover2.Show();
			eyeCover1.Show();
			eyeCover2.Show();

			btnHard.Hide();
			btnNormal.Hide();
			btnImpossible.Hide();
			lblDifficulty.Hide();
		}

		private void RestartGUI() //brings up difficulty selection menu
		{
			lblWord.Hide();
			btnStart.Hide();
			txtGuess.Hide();
			lblWrongGuesses.Hide();

			picHangman.Hide();

			headCover.Hide();
			bodyCover.Hide();
			armCover1.Hide();
			armCover2.Hide();
			legCover1.Hide();
			legCover2.Hide();
			eyeCover1.Hide();
			eyeCover2.Hide();

			btnHard.Show();
			btnNormal.Show();
			btnImpossible.Show();
			lblDifficulty.Show();
		}
	}
}
