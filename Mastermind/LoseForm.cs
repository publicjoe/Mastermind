using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Mastermind
{
  public partial class LoseForm : Form
  {
    private Rectangle Hole = new Rectangle(0, 0, 20, 20);
    private Rectangle Peg = new Rectangle(0, 0, 24, 24);
    private const int SPACING = 20;
    private const int MARGIN = 40;

    int[] TheRow = new int[4];

    public LoseForm()
    {
      InitializeComponent();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      Graphics g = e.Graphics;

      // Draw pegs
      for (int i = 0; i < 4; i++)
      {
        Rectangle rect = new Rectangle(Peg.Left, Peg.Top, Peg.Width, Peg.Height);
        rect.Offset(i * (Hole.Width + SPACING) - 2, 0);
        rect.Offset(MARGIN, MARGIN);

        Color c = Color.Black;

        switch (TheRow[i])
        {
          case 1: c = Color.Aqua; break;
          case 2: c = Color.Green; break;
          case 3: c = Color.Yellow; break;
          case 4: c = Color.Blue; break;
          case 5: c = Color.Red; break;
          case 6: c = Color.Pink; break;
          case 7: c = Color.Orange; break;
          case 8: c = Color.Violet; break;
          default:  /* Do Nothing */ break;
        }

        GraphicsPath path = new GraphicsPath();

        path.AddEllipse(rect);

        PathGradientBrush pgbrush = new PathGradientBrush(path);
        pgbrush.CenterPoint = new Point((rect.Right - rect.Left) / 3 + rect.Left,
                                         (rect.Bottom - rect.Top) / 3 + rect.Top);
        pgbrush.CenterColor = Color.White;
        pgbrush.SurroundColors = new Color[] { c };

        g.FillRectangle(pgbrush, rect);
        g.DrawEllipse(new Pen(c), rect);
      }
    }
    
    public void UpdateRow( int i, int colour )
    {
      TheRow[i] = colour;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}