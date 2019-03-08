using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class DrawForm : Form, IDisposable
    {

        public DrawForm()
        {
            InitializeComponent();
        }

        Graphics myGraphic;
        Pen myPen = new Pen(Color.Black, 1);
        Brush myBrush = new SolidBrush(Color.White);
        //Brush myFunkyBrush = new LinearGradientBrush(Color.Black, Color.White);
        Point start = new Point(0, 0);
        Point end = new Point(0, 0);
        bool drawing = false;
        string pickedTool = "";
        int rectWidth;
        int rectHeight;
        Rectangle testRectangle;

        Color gradientInsideColour = Color.White;
        Color gradientOutsideColour = Color.Black;

        private void pictureBoxMain_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            switch (pickedTool)
            {
                case "rectangle":
                    {
                        myGraphic = pictureBoxMain.CreateGraphics();
                        Point startRectGradient = new Point(rectWidth, rectHeight);
                        Point endRectGradient = new Point(e.X - rectWidth, e.Y - rectHeight);
                        Rectangle hipNewRectangle = new Rectangle(rectWidth, e.Y - rectHeight, e.X - rectWidth, rectHeight);
                        myGraphic.FillRectangle(myBrush, (new Rectangle(rectWidth, rectHeight, e.X - rectWidth, e.Y - rectHeight)));
                        myGraphic.DrawRectangle(myPen, rectWidth, rectHeight, e.X - rectWidth, e.Y - rectHeight);
                        break;
                    }
            }
        }

        private void pictureBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            start.X = e.X;
            start.Y = e.Y;
            rectWidth = e.X;
            rectHeight = e.Y;
            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
            }
            switch (pickedTool)
            {
                case "rectangle":
                    {
                        break;
                    }
            }
        }

        private void pictureBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
            switch (pickedTool)
            {
                case "":
                    {
                        break;
                    }
                case "pen":
                    {
                        if (drawing)
                        {
                            end = e.Location;
                            myGraphic = pictureBoxMain.CreateGraphics();
                            myGraphic.DrawLine(myPen, start, end);
                        }
                        start = end;
                        break;
                    }
                case "rectangle":
                    {
                        if (drawing)
                        {
                            testRectangle = new Rectangle(rectWidth, rectHeight, e.X - rectWidth, e.Y - rectHeight);
                            Refresh();
                            myGraphic = pictureBoxMain.CreateGraphics();
                            myGraphic.DrawRectangle(myPen, testRectangle);
                        }
                        start = end;
                        break;
                    }
                case "square":
                    {
                        if (drawing)
                        {
                            end = e.Location;
                            myGraphic = pictureBoxMain.CreateGraphics();
                            myGraphic.DrawRectangle(myPen, e.X, e.Y, 50, 50);

                        }
                        start = end;
                        break;
                    }
                case "circle":
                    {
                        if (drawing)
                        {
                            end = e.Location;
                            myGraphic = pictureBoxMain.CreateGraphics();
                            //myGraphic.FillEllipse(myBrush, e.X, e.Y, 50, 50);
                            LinearGradientBrush myFunkyBrush = new LinearGradientBrush(new Point(rectWidth, rectWidth), 
                                new Point(e.X - rectWidth, e.Y - rectHeight), gradientInsideColour, gradientOutsideColour);
                            Rectangle hipNewRectangle = new Rectangle(rectWidth, rectHeight, e.X - rectWidth, e.Y - rectHeight);
                            myGraphic.FillEllipse(myFunkyBrush, e.X, e.Y, 50, 50);
                        }
                        start = end;
                        break;
                    }
                    
            }
        }

        public void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backgroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMain.BackColor = colorDialog1.Color;
            }
        }

        private void colourPenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                myPen.Color = colorDialog1.Color;
            }
        }

        private void colourBrushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Brush newBrush = new SolidBrush(colorDialog1.Color);
                myBrush = newBrush;
            }
        }

        private void scribbleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pickedTool = "pen";
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pickedTool = "rectangle";
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pickedTool = "square";
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pickedTool = "circle";
        }

        private void insideColourToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                gradientInsideColour = colorDialog1.Color;
            }
        }

        private void outsideColourToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                gradientOutsideColour = colorDialog1.Color;
            }
        }
    }
}
