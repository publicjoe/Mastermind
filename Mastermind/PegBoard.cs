using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Mastermind
{
  /// <summary>
  /// Description of PegBoard.
  /// </summary>
  public class PegBoard
  {
    private int[,] Grid = new int[4,12];
    private Rectangle BoardFrame = new Rectangle( 30, 40, 180, 500 );
    private Rectangle Hole = new Rectangle(0, 0, 20, 20);
    private Rectangle Peg = new Rectangle(0, 0, 24, 24);
    private const int SPACING = 20;
    private const int MARGIN = 50;
    
    public PegBoard()
    {
      InitializeBoard();
    }
    
    public void Draw( Graphics g )
    {
      // Draw border
      ControlPaint.DrawBorder3D(g, BoardFrame, Border3DStyle.Bump);
      
      // Draw pegs
      for (int i = 0; i < Grid.GetLength(0); i++)
      {
        for (int j = 0; j < Grid.GetLength(1); j++)
        {
          if (Grid[i,j] == 0)
          {
            // Holes
            Rectangle r = new Rectangle(Hole.Left, Hole.Top, Hole.Width, Hole.Height);
            r.Offset(i* (Hole.Width + SPACING), j* (Hole.Height + SPACING));
            r.Offset(MARGIN, MARGIN+10);
            g.DrawEllipse(Pens.Sienna, r);
            g.FillEllipse(Brushes.Sienna, r);
          }
          else
          {
            // Pegs
            Rectangle rect = new Rectangle(Peg.Left, Peg.Top, Peg.Width, Peg.Height);
            rect.Offset(i* (Hole.Width + SPACING) - 2, j* (Hole.Height + SPACING) - 2);
            rect.Offset(MARGIN, MARGIN+10);

            Color c = Color.Black;

            switch(Grid[i,j])
            {
              case 1:   c = Color.Aqua;      break;
              case 2:   c = Color.Green;     break;
              case 3:   c = Color.Yellow;    break;
              case 4:   c = Color.Blue;      break;
              case 5:   c = Color.Red;       break;
              case 6:   c = Color.Pink;      break;
              case 7:   c = Color.Orange;    break;
              case 8:   c = Color.Violet;    break;
              default:  /* Do Nothing */     break;
            }
            
            GraphicsPath path = new GraphicsPath();
    
            path.AddEllipse(rect);
        
            PathGradientBrush pgbrush = new PathGradientBrush(path);
            pgbrush.CenterPoint = new Point( (rect.Right - rect.Left) /3 + rect.Left,
                                             (rect.Bottom - rect.Top) /3 + rect.Top );
            pgbrush.CenterColor = Color.White;
            pgbrush.SurroundColors = new Color[] { c };
            
            g.FillRectangle( pgbrush,rect );
            g.DrawEllipse( new Pen(c), rect );
          }
        }
      }
    }

    public void InitializeBoard()
    {
      for (int i = 0; i < Grid.GetLength(0); i++)
      {
        for (int j = 0; j < Grid.GetLength(1); j++)
        {
          Grid[i,j] = 0;
        }
      }
    }
    
    public void UpdateGrid( int i, int j, int colour )
    {
      Grid[i,j] = colour;
    }
  }
}
