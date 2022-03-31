using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DrawingShapesLogic
{
    public sealed class Circle : Shape
    {       
        public Circle()
        {

        }
  
        public Circle(int x, int y, int width, int height, Control control) : base(x, y, width, height)
        {
            
        }

        public override void DrawingShape(Graphics g, int x, int y, int width, int height)
        {
            g.DrawEllipse(new Pen(Color.Black), x, y, width, height);
        }

        public override void DrawingShape(Graphics g, ref List<Point> lstPoints)
        {
            throw new NotImplementedException();
        }

        public override Type GetType()
        {
            return typeof(Circle);
        }      
    }
}
