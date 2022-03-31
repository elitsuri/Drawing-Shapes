using DrawingShapesLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = DrawingShapesLogic.Rectangle;

namespace DrawingShapes
{
    public partial class Form1 : Form
    {
        private Shape figure;
        private int lastX;
        private int lastY;
        private string figureName;
        private List<Point> polyPoints = new List<Point>();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;

            btnDiamond.Click += BtnDiamond_Click;
            btnTriangle.Click += BtnTriangle_Click;
            btnRectangle.Click += BtnRectangle_Click;
            btnCircle.Click += BtnCircle_Click;
            btnPolygon.Click += BtnPolygon_Click;

            btnColor.Click += BtnColor_Click;
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = textBox1.ForeColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                lblColor.ForeColor = MyDialog.Color;
                lblColor.Text = MyDialog.Color.Name;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {        
            BtnCircle_Click(sender, e);
            lblShapeChoose.Text = figure.GetType().Name;
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            figureName = figure.GetType().Name;
            
            Graphics painter = panel1.CreateGraphics();

            int topX = Math.Min(e.X, lastX);
            int topY = Math.Min(e.Y, lastY);
            int width = Math.Abs(e.X - lastX);
            int height = Math.Abs(e.Y - lastY);

            switch (figureName)
            {
                case "Circle":
                    figure.DrawingShape(painter, topX, topY, width, height);                                    
                    break;
                case "Rectangle":
                    figure.DrawingShape(painter, topX, topY, width, height);
                    break;
                case "Diamond":
                    
                    break;

                case "Triangle":
                    figure.DrawingShape(painter, ref polyPoints);
                    break;
                case "Polygon":
                    figure.DrawingShape(painter, ref polyPoints);
                    break;                
            }          
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            figureName = figure.GetType().Name;

            switch (figureName)
            {
                case "Circle":
                    lastX = e.X;
                    lastY = e.Y;
                    break;
                
                case "Rectangle":
                    lastX = e.X;
                    lastY = e.Y;
                    break;

                case "Polygon":
                    lastX = e.X;
                    lastY = e.Y;

                    polyPoints.Add(new Point(lastX, lastY));

                    break;

                case "Diamond":



                    break;

                case "Triangle":
                    lastX = e.X;
                    lastY = e.Y;

                    polyPoints.Add(new Point(lastX, lastY));

                    break;           
            }         
        }

        private void BtnCircle_Click(object sender, EventArgs e)
        {
            polyPoints.Clear();
            figure = new Circle();           
            lblShapeChoose.Text = figure.GetType().Name;
        }
    
        private void BtnDiamond_Click(object sender, EventArgs e)
        {
            polyPoints.Clear();
            figure = new Diamond();
            lblShapeChoose.Text = figure.GetType().Name;
        }

        private void BtnTriangle_Click(object sender, EventArgs e)
        {
            polyPoints.Clear();
            figure = new Triangle();
            lblShapeChoose.Text = figure.GetType().Name;
        }

        private void BtnRectangle_Click(object sender, EventArgs e)
        {
            polyPoints.Clear();
            figure = new Rectangle();
            lblShapeChoose.Text = figure.GetType().Name;
        }

        private void BtnPolygon_Click(object sender, EventArgs e)
        {
            figure = new Polygon();
            lblShapeChoose.Text = figure.GetType().Name;
        }

       
    }
}
