using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DrawingShapesLogic
{
    public sealed class Rectangle : Shape
    {      
        public Rectangle()
        {

        }

        public Rectangle(int x, int y, int width, int height) : base(x,y, width, height)
        {
            
        }

        public override void DrawingShape(Graphics g, int x, int y, int width, int height)
        {
            g.DrawRectangle(new Pen(Color.Black), x, y, width, height);
        }

        public override void DrawingShape(Graphics g,ref List<Point> lstPoints)
        {
            throw new NotImplementedException();
        }

        public override Type GetType()
        {
            return typeof(Rectangle);
        }
    }
}
