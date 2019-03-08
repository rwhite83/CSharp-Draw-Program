namespace Draw
{
    partial class DrawForm
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
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scribbleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourPenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourGradientBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insideColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outsideColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMain.Location = new System.Drawing.Point(0, 40);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(913, 685);
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseDown);
            this.pictureBoxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseMove);
            this.pictureBoxMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.drawingToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 40);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(233, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // drawingToolStripMenuItem
            // 
            this.drawingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.squareToolStripMenuItem,
            this.scribbleToolStripMenuItem});
            this.drawingToolStripMenuItem.Name = "drawingToolStripMenuItem";
            this.drawingToolStripMenuItem.Size = new System.Drawing.Size(115, 38);
            this.drawingToolStripMenuItem.Text = "Drawing";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.squareToolStripMenuItem_Click);
            // 
            // scribbleToolStripMenuItem
            // 
            this.scribbleToolStripMenuItem.Name = "scribbleToolStripMenuItem";
            this.scribbleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.scribbleToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.scribbleToolStripMenuItem.Text = "Scribble";
            this.scribbleToolStripMenuItem.Click += new System.EventHandler(this.scribbleToolStripMenuItem_Click_1);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColourToolStripMenuItem,
            this.colourPenToolStripMenuItem,
            this.colourBrushToolStripMenuItem,
            this.colourGradientBrushToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(82, 38);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // backgroundColourToolStripMenuItem
            // 
            this.backgroundColourToolStripMenuItem.Name = "backgroundColourToolStripMenuItem";
            this.backgroundColourToolStripMenuItem.Size = new System.Drawing.Size(350, 38);
            this.backgroundColourToolStripMenuItem.Text = "Background Colour";
            this.backgroundColourToolStripMenuItem.Click += new System.EventHandler(this.backgroundColourToolStripMenuItem_Click);
            // 
            // colourPenToolStripMenuItem
            // 
            this.colourPenToolStripMenuItem.Name = "colourPenToolStripMenuItem";
            this.colourPenToolStripMenuItem.Size = new System.Drawing.Size(350, 38);
            this.colourPenToolStripMenuItem.Text = "Colour Pen";
            this.colourPenToolStripMenuItem.Click += new System.EventHandler(this.colourPenToolStripMenuItem_Click);
            // 
            // colourBrushToolStripMenuItem
            // 
            this.colourBrushToolStripMenuItem.Name = "colourBrushToolStripMenuItem";
            this.colourBrushToolStripMenuItem.Size = new System.Drawing.Size(350, 38);
            this.colourBrushToolStripMenuItem.Text = "Colour Brush";
            this.colourBrushToolStripMenuItem.Click += new System.EventHandler(this.colourBrushToolStripMenuItem_Click);
            // 
            // colourGradientBrushToolStripMenuItem
            // 
            this.colourGradientBrushToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insideColourToolStripMenuItem,
            this.outsideColourToolStripMenuItem});
            this.colourGradientBrushToolStripMenuItem.Name = "colourGradientBrushToolStripMenuItem";
            this.colourGradientBrushToolStripMenuItem.Size = new System.Drawing.Size(350, 38);
            this.colourGradientBrushToolStripMenuItem.Text = "Colour Gradient Brush";
            // 
            // insideColourToolStripMenuItem
            // 
            this.insideColourToolStripMenuItem.Name = "insideColourToolStripMenuItem";
            this.insideColourToolStripMenuItem.Size = new System.Drawing.Size(275, 38);
            this.insideColourToolStripMenuItem.Text = "Inside Colour";
            this.insideColourToolStripMenuItem.Click += new System.EventHandler(this.insideColourToolStripMenuItem_Click_1);
            // 
            // outsideColourToolStripMenuItem
            // 
            this.outsideColourToolStripMenuItem.Name = "outsideColourToolStripMenuItem";
            this.outsideColourToolStripMenuItem.Size = new System.Drawing.Size(275, 38);
            this.outsideColourToolStripMenuItem.Text = "Outside Colour";
            this.outsideColourToolStripMenuItem.Click += new System.EventHandler(this.outsideColourToolStripMenuItem_Click_1);
            // 
            // DrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 725);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DrawForm";
            this.Text = "DrawForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scribbleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourPenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourGradientBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insideColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outsideColourToolStripMenuItem;
    }
}

