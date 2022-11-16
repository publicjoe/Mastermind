using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Publicjoe.Windows;

namespace Mastermind
{
  public partial class Form1 : Form
  {
    private PegBoard ThePegBoard = new PegBoard();
    private ScoreBoard TheScoreBoard = new ScoreBoard();

    private int[] TheRow = new int[4];
    private int[] TheGuess = new int[4];
    private int currentRow = 0;
    private int currentPeg = 0;

    private int HighScore = 0;
    private int currentScore = 120;

    private HighScoreTable highScoreTable = new HighScoreTable();

    public Form1()
    {
      InitializeComponent();
      InitializeGuess();

      // Load high score table...
      highScoreTable.Load(Application.StartupPath + @"\score.txt");
    }

    private void InitializeGuess()
    {
      DateTime aTime = new DateTime(1000);
      aTime = DateTime.Now;
      int nSeed = (int)(aTime.Millisecond);
      Random RandomPick = new Random(nSeed);

      TheRow[0] = RandomPick.Next(1, 8);
      TheRow[1] = RandomPick.Next(1, 8);
      TheRow[2] = RandomPick.Next(1, 8);
      TheRow[3] = RandomPick.Next(1, 8);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      Graphics g = e.Graphics;
      ThePegBoard.Draw(g);
      TheScoreBoard.Draw(g);

      g.DrawString("Current : " + currentScore.ToString(), new Font("Tahoma", 8, System.Drawing.FontStyle.Bold), new SolidBrush(Color.Black), 8, 555);
      g.DrawString("Total : " + HighScore.ToString(), new Font("Tahoma", 8, System.Drawing.FontStyle.Bold), new SolidBrush(Color.Black), 8, 575);
    }

    private void CyanButton_Click(object sender, EventArgs e)
    {
      if (currentPeg < 4)
      {
        TheGuess[currentPeg] = 1;
        ThePegBoard.UpdateGrid(currentPeg, currentRow, 1);
        currentPeg++;
        Invalidate();
      }
    }

    private void GreenButton_Click(object sender, EventArgs e)
    {
      if (currentPeg < 4)
      {
        TheGuess[currentPeg] = 2;
        ThePegBoard.UpdateGrid(currentPeg, currentRow, 2);
        currentPeg++;
        Invalidate();
      }
    }

    private void YellowButton_Click(object sender, EventArgs e)
    {
      if (currentPeg < 4)
      {
        TheGuess[currentPeg] = 3;
        ThePegBoard.UpdateGrid(currentPeg, currentRow, 3);
        currentPeg++;
        Invalidate();
      }
    }

    private void BlueButton_Click(object sender, EventArgs e)
    {
      if (currentPeg < 4)
      {
        TheGuess[currentPeg] = 4;
        ThePegBoard.UpdateGrid(currentPeg, currentRow, 4);
        currentPeg++;
        Invalidate();
      }
    }

    private void RedButton_Click(object sender, EventArgs e)
    {
      if (currentPeg < 4)
      {
        TheGuess[currentPeg] = 5;
        ThePegBoard.UpdateGrid(currentPeg, currentRow, 5);
        currentPeg++;
        Invalidate();
      }
    }

    private void PinkButton_Click(object sender, EventArgs e)
    {
      if (currentPeg < 4)
      {
        TheGuess[currentPeg] = 6;
        ThePegBoard.UpdateGrid(currentPeg, currentRow, 6);
        currentPeg++;
        Invalidate();
      }
    }

    private void OrangeButton_Click(object sender, EventArgs e)
    {
      if (currentPeg < 4)
      {
        TheGuess[currentPeg] = 7;
        ThePegBoard.UpdateGrid(currentPeg, currentRow, 7);
        currentPeg++;
        Invalidate();
      }
    }

    private void MagentaButton_Click(object sender, EventArgs e)
    {
      if (currentPeg < 4)
      {
        TheGuess[currentPeg] = 8;
        ThePegBoard.UpdateGrid(currentPeg, currentRow, 8);
        currentPeg++;
        Invalidate();
      }
    }

    private void UndoButton_Click(object sender, EventArgs e)
    {
      if (currentPeg > 0)
      {
        currentPeg--;
        TheGuess[currentPeg] = 0;
        ThePegBoard.UpdateGrid(currentPeg, currentRow, 0);
        Invalidate();
      }
    }

    private void CheckButton_Click(object sender, EventArgs e)
    {
      if (currentPeg == 4)
      {
        int[] UsedPegs = new int[4];
        int[] UsedGuess = new int[4];
        for (int i = 0; i < 4; i++)
        {
          UsedPegs[i] = 0;
          UsedGuess[i] = 0;
        }

        int score = 0;

        // Look for exact matches
        for (int i = 0; i < 4; i++)
        {
          if (TheRow[i] == TheGuess[i])
          {
            score += 10;
            UsedPegs[i] = 1;
            UsedGuess[i] = 1;
          }
        }

        // Look for any partial matches
        for (int i = 0; i < 4; i++)
        {
          for (int j = 0; j < 4; j++)
          {
            if ((UsedPegs[i] == 0) &&
                (UsedGuess[j] == 0) &&
                (TheRow[i] == TheGuess[j]))
            {
              score++;
              UsedPegs[i] = 1;
              UsedGuess[j] = 1;
              break;
            }
          }
        }

        // Update Score Pegs
        TheScoreBoard.UpdateScore(currentRow, score);

        // Check for win
        if (score == 40)
        {
          currentRow = 0;
          currentPeg = 0;
          Invalidate();

          MessageBox.Show("Congratulations! You Won!");

          InitializeGuess();
          ThePegBoard.InitializeBoard();
          TheScoreBoard.InitializeBoard();

          HighScore += currentScore;
          currentScore = 120;
          Invalidate();
        }
        else
        {
          // Move to next row
          currentRow++;
          currentPeg = 0;
          Invalidate();
          currentScore -= 10;

          if (currentRow == 12)
          {
            LoseForm Loser = new LoseForm();

            for (int i = 0; i < 4; i++)
            {
              Loser.UpdateRow(i, TheRow[i]);
              Loser.StartPosition = FormStartPosition.CenterScreen;
              Loser.Show();
            }

            InitializeGuess();
            ThePegBoard.InitializeBoard();
            TheScoreBoard.InitializeBoard();
            currentRow = 0;
            currentPeg = 0;
            currentScore = 120;
            Invalidate();
          }
        }
      }
    }

    private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
    {
      HighScoreForm HighScoreForm = new HighScoreForm(highScoreTable);
      HighScoreForm.StartPosition = FormStartPosition.CenterScreen;
      HighScoreForm.Show();
    }

    private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      (new RulesForm()).ShowDialog();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    protected override void OnClosing(CancelEventArgs e)
    {
      CheckHighScore();
      base.OnClosing(e);
    }

    private void CheckHighScore()
    {
      highScoreTable.Load(Application.StartupPath + @"\score.txt");

      int scoreIndex = highScoreTable.GetIndexOfScore(HighScore);

      if (scoreIndex > -1)
      {
        string name = "";
        using (EntryForm aForm = new EntryForm())
        {
          aForm.StartPosition = FormStartPosition.CenterScreen;

          if (aForm.ShowDialog() == DialogResult.OK)
          {
            name = aForm.textBox1.Text;

            highScoreTable.Update(name, HighScore);
          }
        }
      }
    }
  }
}