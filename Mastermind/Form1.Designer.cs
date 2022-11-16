namespace Mastermind
{
  partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.highScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label1 = new System.Windows.Forms.Label();
      this.CyanButton = new System.Windows.Forms.Button();
      this.GreenButton = new System.Windows.Forms.Button();
      this.YellowButton = new System.Windows.Forms.Button();
      this.BlueButton = new System.Windows.Forms.Button();
      this.RedButton = new System.Windows.Forms.Button();
      this.PinkButton = new System.Windows.Forms.Button();
      this.OrangeButton = new System.Windows.Forms.Button();
      this.MagentaButton = new System.Windows.Forms.Button();
      this.UndoButton = new System.Windows.Forms.Button();
      this.CheckButton = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(295, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highScoresToolStripMenuItem,
            this.rulesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // highScoresToolStripMenuItem
      // 
      this.highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
      this.highScoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.highScoresToolStripMenuItem.Text = "&High Scores";
      this.highScoresToolStripMenuItem.Click += new System.EventHandler(this.highScoresToolStripMenuItem_Click);
      // 
      // rulesToolStripMenuItem
      // 
      this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
      this.rulesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.rulesToolStripMenuItem.Text = "&Rules";
      this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.exitToolStripMenuItem.Text = "&Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(6, 596);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Choose Colour :";
      // 
      // CyanButton
      // 
      this.CyanButton.BackColor = System.Drawing.Color.Cyan;
      this.CyanButton.Location = new System.Drawing.Point(103, 591);
      this.CyanButton.Name = "CyanButton";
      this.CyanButton.Size = new System.Drawing.Size(24, 23);
      this.CyanButton.TabIndex = 3;
      this.CyanButton.UseVisualStyleBackColor = false;
      this.CyanButton.Click += new System.EventHandler(this.CyanButton_Click);
      // 
      // GreenButton
      // 
      this.GreenButton.BackColor = System.Drawing.Color.Green;
      this.GreenButton.Location = new System.Drawing.Point(125, 591);
      this.GreenButton.Name = "GreenButton";
      this.GreenButton.Size = new System.Drawing.Size(24, 23);
      this.GreenButton.TabIndex = 4;
      this.GreenButton.UseVisualStyleBackColor = false;
      this.GreenButton.Click += new System.EventHandler(this.GreenButton_Click);
      // 
      // YellowButton
      // 
      this.YellowButton.BackColor = System.Drawing.Color.Yellow;
      this.YellowButton.Location = new System.Drawing.Point(147, 591);
      this.YellowButton.Name = "YellowButton";
      this.YellowButton.Size = new System.Drawing.Size(24, 23);
      this.YellowButton.TabIndex = 5;
      this.YellowButton.UseVisualStyleBackColor = false;
      this.YellowButton.Click += new System.EventHandler(this.YellowButton_Click);
      // 
      // BlueButton
      // 
      this.BlueButton.BackColor = System.Drawing.Color.Blue;
      this.BlueButton.Location = new System.Drawing.Point(169, 591);
      this.BlueButton.Name = "BlueButton";
      this.BlueButton.Size = new System.Drawing.Size(24, 23);
      this.BlueButton.TabIndex = 6;
      this.BlueButton.UseVisualStyleBackColor = false;
      this.BlueButton.Click += new System.EventHandler(this.BlueButton_Click);
      // 
      // RedButton
      // 
      this.RedButton.BackColor = System.Drawing.Color.Red;
      this.RedButton.Location = new System.Drawing.Point(191, 591);
      this.RedButton.Name = "RedButton";
      this.RedButton.Size = new System.Drawing.Size(24, 23);
      this.RedButton.TabIndex = 7;
      this.RedButton.UseVisualStyleBackColor = false;
      this.RedButton.Click += new System.EventHandler(this.RedButton_Click);
      // 
      // PinkButton
      // 
      this.PinkButton.BackColor = System.Drawing.Color.Pink;
      this.PinkButton.Location = new System.Drawing.Point(213, 591);
      this.PinkButton.Name = "PinkButton";
      this.PinkButton.Size = new System.Drawing.Size(24, 23);
      this.PinkButton.TabIndex = 8;
      this.PinkButton.UseVisualStyleBackColor = false;
      this.PinkButton.Click += new System.EventHandler(this.PinkButton_Click);
      // 
      // OrangeButton
      // 
      this.OrangeButton.BackColor = System.Drawing.Color.Orange;
      this.OrangeButton.Location = new System.Drawing.Point(235, 591);
      this.OrangeButton.Name = "OrangeButton";
      this.OrangeButton.Size = new System.Drawing.Size(24, 23);
      this.OrangeButton.TabIndex = 9;
      this.OrangeButton.UseVisualStyleBackColor = false;
      this.OrangeButton.Click += new System.EventHandler(this.OrangeButton_Click);
      // 
      // MagentaButton
      // 
      this.MagentaButton.BackColor = System.Drawing.Color.Magenta;
      this.MagentaButton.Location = new System.Drawing.Point(257, 591);
      this.MagentaButton.Name = "MagentaButton";
      this.MagentaButton.Size = new System.Drawing.Size(24, 23);
      this.MagentaButton.TabIndex = 10;
      this.MagentaButton.UseVisualStyleBackColor = false;
      this.MagentaButton.Click += new System.EventHandler(this.MagentaButton_Click);
      // 
      // UndoButton
      // 
      this.UndoButton.Location = new System.Drawing.Point(103, 620);
      this.UndoButton.Name = "UndoButton";
      this.UndoButton.Size = new System.Drawing.Size(75, 23);
      this.UndoButton.TabIndex = 11;
      this.UndoButton.Text = "Undo";
      this.UndoButton.UseVisualStyleBackColor = true;
      this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
      // 
      // CheckButton
      // 
      this.CheckButton.Location = new System.Drawing.Point(206, 620);
      this.CheckButton.Name = "CheckButton";
      this.CheckButton.Size = new System.Drawing.Size(75, 23);
      this.CheckButton.TabIndex = 12;
      this.CheckButton.Text = "Check EntryForm";
      this.CheckButton.UseVisualStyleBackColor = true;
      this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Tan;
      this.ClientSize = new System.Drawing.Size(295, 668);
      this.Controls.Add(this.CheckButton);
      this.Controls.Add(this.UndoButton);
      this.Controls.Add(this.MagentaButton);
      this.Controls.Add(this.OrangeButton);
      this.Controls.Add(this.PinkButton);
      this.Controls.Add(this.RedButton);
      this.Controls.Add(this.BlueButton);
      this.Controls.Add(this.YellowButton);
      this.Controls.Add(this.GreenButton);
      this.Controls.Add(this.CyanButton);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Mastermind";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem highScoresToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button CyanButton;
    private System.Windows.Forms.Button GreenButton;
    private System.Windows.Forms.Button YellowButton;
    private System.Windows.Forms.Button BlueButton;
    private System.Windows.Forms.Button RedButton;
    private System.Windows.Forms.Button PinkButton;
    private System.Windows.Forms.Button OrangeButton;
    private System.Windows.Forms.Button MagentaButton;
    private System.Windows.Forms.Button UndoButton;
    private System.Windows.Forms.Button CheckButton;
  }
}

