using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Draw
{
    public partial class DrawForm : Form, IDisposable
    {
        /// <summary>
        /// Initializes Components
        /// </summary>
        public DrawForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Graphics and brush objects initialized
        /// </summary>
        Graphics myGraphic;
        GraphicsPath graphicsPath;
        Pen myPen = new Pen(Color.Black, 1);
        Brush myBrush = new SolidBrush(Color.White);
        PathGradientBrush pathGradientBrush;

        /// <summary>
        /// dummy string for picked tool, and defaulting drawing bool to false
        /// </summary>
        bool drawing = false;
        string pickedTool = "";

        /// <summary>
        /// declaring all of the points and ints for cardinalities which will be needed
        /// </summary>
        Point start = new Point(0, 0);
        Point end = new Point(0, 0);
        int rectWidth;
        int rectHeight;
        int rectStartX;
        int rectStartY;

        /// <summary>
        /// declaring all of the rectangles which will be needed
        /// </summary>
        Rectangle dragRectangle;
        Rectangle squaredCircle;
        Rectangle squaredSquare;


        /// <summary>
        /// Default colours for the path gradient brush
        /// </summary>
        Color gradientInsideColour = Color.Blue;
        Color gradientOutsideColour = Color.Red;

        /// <summary>
        /// when mouse is pressed, depending on what utility is selected, a different operation will occur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            //defining all of the coordinates at initial press
            start.X = e.X;
            start.Y = e.Y;
            rectStartX = e.X;
            rectStartY = e.Y;
            rectWidth = e.X;
            rectHeight = e.Y;

            // sets drawing bool to true
            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
            }
            switch (pickedTool)
            {
                case "":
                    {
                        break;
                    }
                case "circle":
                    {
                        // creates a graphics element on the main picture box
                        // and rectangle in which to fill an ellipse
                        myGraphic = pictureBoxMain.CreateGraphics();
                        graphicsPath = new GraphicsPath();
                        squaredCircle = new Rectangle(e.X, e.Y, 50, 50);
                        graphicsPath.AddRectangle(squaredCircle);

                        // instantiates brush and applies colours to it
                        // paints a circle when button is initially pressed
                        pathGradientBrush = new PathGradientBrush(graphicsPath);
                        pathGradientBrush.CenterColor = gradientInsideColour;
                        Color[] coloursArray = { gradientOutsideColour };
                        pathGradientBrush.SurroundColors = coloursArray;
                        myGraphic = pictureBoxMain.CreateGraphics();
                        myGraphic.FillEllipse(pathGradientBrush, squaredCircle);

                        break;
                    }
                case "square":
                    {
                        // creates a graphics element on the main picture box
                        // and rectangle in which to fill a square
                        myGraphic = pictureBoxMain.CreateGraphics();
                        graphicsPath = new GraphicsPath();
                        squaredSquare = new Rectangle(e.X, e.Y, 50, 50);
                        graphicsPath.AddRectangle(squaredSquare);

                        // instantiates brush and applies colours to it
                        // paints a square when button is initially pressed
                        pathGradientBrush = new PathGradientBrush(graphicsPath);
                        pathGradientBrush.CenterColor = gradientInsideColour;
                        Color[] coloursArray = { gradientOutsideColour };
                        pathGradientBrush.SurroundColors = coloursArray;
                        myGraphic = pictureBoxMain.CreateGraphics();
                        myGraphic.FillRectangle(pathGradientBrush, squaredSquare);

                        break;
                    }
            }
        }

        /// <summary>
        /// determines actvity when a shape is dragged after a mousedown event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        // as the pen is moved, a line is drawn between the previous position and the new position
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
                        // as the rectangle is dragged, a new rectangle is continually drawn, and erased with a refresh call
                        // currently my big hard problem is that this erases everything previously drawn
                        if (drawing)
                        {
                            dragRectangle = new Rectangle(Math.Min(rectStartX, e.X), Math.Min(rectStartY, e.Y), Math.Abs(rectStartX - e.X), Math.Abs(rectStartY - e.Y));
                            Refresh();
                            myGraphic = pictureBoxMain.CreateGraphics();
                            myGraphic.DrawRectangle(myPen, dragRectangle);
                        }
                        start = end;
                        break;
                    }
                case "square":
                    {
                        // as the square is dragged, it creates a series of squares at every 
                        // position it recognizes itself to pass through
                        if (drawing)
                        {
                            end = e.Location;

                            myGraphic = pictureBoxMain.CreateGraphics();

                            //// Path
                            graphicsPath = new GraphicsPath();
                            squaredSquare = new Rectangle(e.X, e.Y, 50, 50);
                            graphicsPath.AddRectangle(squaredSquare);

                            // Gradient Brush
                            pathGradientBrush = new PathGradientBrush(graphicsPath);
                            pathGradientBrush.CenterColor = gradientInsideColour;
                            Color[] coloursArray = { gradientOutsideColour };
                            pathGradientBrush.SurroundColors = coloursArray;
                            myGraphic = pictureBoxMain.CreateGraphics();
                            myGraphic.FillRectangle(pathGradientBrush, squaredSquare);
                        }
                        start = end;
                        break;
                    }
                case "circle":
                    {
                        // as the circle is dragged, it creates a series of squares at every 
                        // position it recognizes itself to pass through
                        if (drawing)
                        {
                            end = e.Location;

                            myGraphic = pictureBoxMain.CreateGraphics();

                            //// Path
                            graphicsPath = new GraphicsPath();
                            squaredCircle = new Rectangle(e.X, e.Y, 50, 50);
                            graphicsPath.AddRectangle(squaredCircle);

                            // Gradient Brush
                            pathGradientBrush = new PathGradientBrush(graphicsPath);
                            pathGradientBrush.CenterColor = gradientInsideColour;
                            Color[] coloursArray = { gradientOutsideColour };
                            pathGradientBrush.SurroundColors = coloursArray;
                            myGraphic = pictureBoxMain.CreateGraphics();
                            myGraphic.FillEllipse(pathGradientBrush, squaredCircle);
                        }
                        start = end;
                        break;
                    }
            }
        }

        /// <summary>
        /// depending on which tool is picked, determines what happens when the mouse button is released
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxMain_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            switch (pickedTool)
            {
                // in the case of rectangle, draws a fill rectangle and a regular rectangle to create a border
                case "rectangle":
                    {
                        myGraphic = pictureBoxMain.CreateGraphics();
                        Point startRectGradient = new Point(rectWidth, rectHeight);
                        Point endRectGradient = new Point(e.X - rectWidth, e.Y - rectHeight);
                        myGraphic.FillRectangle(myBrush, (new Rectangle(Math.Min(rectStartX, e.X), Math.Min(rectStartY, e.Y), Math.Abs(rectStartX - e.X), Math.Abs(rectStartY - e.Y))));
                        myGraphic.DrawRectangle(myPen, Math.Min(rectStartX, e.X), Math.Min(rectStartY, e.Y), Math.Abs(rectStartX - e.X), Math.Abs(rectStartY - e.Y));
                        break;
                    }
            }
        }        

        /// <summary>
        /// exits the application when this menu item is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// opens a colour picker and applies resulting colour to the background
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMain.BackColor = colorDialog1.Color;
            }
        }

        /// <summary>
        /// opens a colour picker and applies chosen colour to the pen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colourPenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                myPen.Color = colorDialog1.Color;
            }
        }

        /// <summary>
        /// opens a colour picker and applies that colour to the standard brush
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colourBrushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Brush newBrush = new SolidBrush(colorDialog1.Color);
                myBrush = newBrush;
            }
        }

        /// <summary>
        /// opens a colour picker and applies that colour to the standard brush
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void outsideColourToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                gradientOutsideColour = colorDialog1.Color;
            }
        }

        /// <summary>
        /// sets picked tool to pen from the menu selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scribbleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pickedTool = "pen";
        }

        /// <summary>
        /// sets picked tool to rectangle from the menu selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pickedTool = "rectangle";
        }

        /// <summary>
        /// sets picked tool to square from the menu selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pickedTool = "square";
        }

        /// <summary>
        /// sets picked tool to circle from the menu selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pickedTool = "circle";
        }

        /// <summary>
        /// sets picked tool to circle from the menu selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void insideColourToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                gradientInsideColour = colorDialog1.Color;
            }
        }
    }
}
