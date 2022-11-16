/*
 * This class is based on Mike Gold's beta code class that can be found at
 * http://www.c-sharpcorner.com/Graphics/MastermindMG.asp
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mastermind
{
  /// <summary>
  /// Description of ScoreBoard.
  /// </summary>
  public class ScoreBoard
  {
    private int TheMargin = 240;
    private int TheSpacing = 12;
    private int YMargin = 62;
    private int[,,] ScorePegs = new int[2,2,12];
    private int ROWSPACING = 40;
    private int SCOREPEG = 5;
    
    private Rectangle BoardFrame = new Rectangle( 220, 40, 60, 500 );
    
    public ScoreBoard()
    {
      InitializeBoard();
    }

    public void InitializeBoard()
    {
      for (int i = 0; i < ScorePegs.GetLength(0); i++)
      {
        for (int j = 0; j < ScorePegs.GetLength(1); j++)
        {
          for (int k = 0; k < ScorePegs.GetLength(2); k++)
          {
            ScorePegs[i, j, k] = 0;
          }
        }
      }
    }
    
    public void Draw( Graphics g )
    {
      ControlPaint.DrawBorder3D(g, BoardFrame, Border3DStyle.Bump);
      
      for (int i = 0; i < ScorePegs.GetLength(0); i++)
      {
        for (int j = 0; j < ScorePegs.GetLength(1); j++)
        {
          for (int k = 0; k < ScorePegs.GetLength(2); k++)
          {
            if (ScorePegs[i, j, k] ==  0)
            {
              // draw the empty peg
              g.DrawEllipse(Pens.Sienna, (i*TheSpacing) + TheMargin, j*TheSpacing + k * ROWSPACING + YMargin, SCOREPEG, SCOREPEG);
            }
            else if (ScorePegs[i,j,k] == 1)
            {
              // draw the white pegs
              g.FillEllipse(Brushes.White, (i*TheSpacing) + TheMargin, j*TheSpacing + k * ROWSPACING  + YMargin, SCOREPEG, SCOREPEG);
              g.DrawEllipse(Pens.White, (i*TheSpacing) + TheMargin, j*TheSpacing + k * ROWSPACING + YMargin, SCOREPEG, SCOREPEG);
            }
            else if (ScorePegs[i,j,k] == 2)
            {
              // draw the black pegs
              g.DrawEllipse(Pens.Black, (i*TheSpacing) + TheMargin, j*TheSpacing + k * ROWSPACING + YMargin, SCOREPEG, SCOREPEG);
              g.FillEllipse(Brushes.Black, (i*TheSpacing) + TheMargin, j*TheSpacing + k * ROWSPACING  + YMargin, SCOREPEG, SCOREPEG);
            }
          }
        }
      }
    }
    
    public void UpdateScore( int iRow, int iScore )
    {
      switch( iScore )
      {
        case 1:
        {
          ScorePegs[0,0,iRow] = 1;  ScorePegs[0,1,iRow] = 0;  ScorePegs[1,0,iRow] = 0;  ScorePegs[1,1,iRow] = 0;
        }
        break;
        
        case 2:
        {
          ScorePegs[0,0,iRow] = 1;  ScorePegs[0,1,iRow] = 1;  ScorePegs[1,0,iRow] = 0;  ScorePegs[1,1,iRow] = 0;
        }
        break;
        
        case 3:
        {
          ScorePegs[0,0,iRow] = 1;  ScorePegs[0,1,iRow] = 1;  ScorePegs[1,0,iRow] = 1;  ScorePegs[1,1,iRow] = 0;
        }
        break;
        
        case 4:
        {
          ScorePegs[0,0,iRow] = 1;  ScorePegs[0,1,iRow] = 1;  ScorePegs[1,0,iRow] = 1;  ScorePegs[1,1,iRow] = 1;
        }
        break;
        
        case 10:
        {
          ScorePegs[0,0,iRow] = 2;  ScorePegs[0,1,iRow] = 0;  ScorePegs[1,0,iRow] = 0;  ScorePegs[1,1,iRow] = 0;
        }
        break;
        
        case 11:
        {
          ScorePegs[0,0,iRow] = 2;  ScorePegs[0,1,iRow] = 1;  ScorePegs[1,0,iRow] = 0;  ScorePegs[1,1,iRow] = 0;
        }
        break;
        
        case 12:
        {
          ScorePegs[0,0,iRow] = 2;  ScorePegs[0,1,iRow] = 1;  ScorePegs[1,0,iRow] = 1;  ScorePegs[1,1,iRow] = 0;
        }
        break;
        
        case 13:
        {
          ScorePegs[0,0,iRow] = 2;  ScorePegs[0,1,iRow] = 1;  ScorePegs[1,0,iRow] = 1;  ScorePegs[1,1,iRow] = 1;
        }
        break;
        
        case 20:
        {
          ScorePegs[0,0,iRow] = 2;  ScorePegs[0,1,iRow] = 2;  ScorePegs[1,0,iRow] = 0;  ScorePegs[1,1,iRow] = 0;
        }
        break;
        
        case 21:
        {
          ScorePegs[0,0,iRow] = 2;  ScorePegs[0,1,iRow] = 2;  ScorePegs[1,0,iRow] = 1;  ScorePegs[1,1,iRow] = 0;
        }
        break;
        
        case 22:
        {
          ScorePegs[0,0,iRow] = 2;  ScorePegs[0,1,iRow] = 2;  ScorePegs[1,0,iRow] = 1;  ScorePegs[1,1,iRow] = 1;
        }
        break;
        
        case 30:
        {
          ScorePegs[0,0,iRow] = 2;  ScorePegs[0,1,iRow] = 2;  ScorePegs[1,0,iRow] = 2;  ScorePegs[1,1,iRow] = 0;
        }
        break;
        
        case 31:
        {
          ScorePegs[0,0,iRow] = 2;  ScorePegs[0,1,iRow] = 2;  ScorePegs[1,0,iRow] = 2;  ScorePegs[1,1,iRow] = 1;
        }
        break;
        
        case 40:
        {
          ScorePegs[0,0,iRow] = 2;  ScorePegs[0,1,iRow] = 2;  ScorePegs[1,0,iRow] = 2;  ScorePegs[1,1,iRow] = 2;
        }
        break;
        
        default:
        break;
      }
    }
  }
}
