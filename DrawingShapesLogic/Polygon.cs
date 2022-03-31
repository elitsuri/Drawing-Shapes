using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DrawingShapesLogic
{
    public sealed class Polygon : Shape
    {       
        public Polygon()
        {
            //  g.FillPolygon(new SolidBrush(Color.Black), lstPoints.ToArray()); 
        }

        public Polygon(int x, int y, int width, int height) : base (x,y, width, height)
        {
         
            
        }

        public override void DrawingShape(Graphics g, int x, int y, int width, int height)
        {
            throw new NotImplementedException();
        }

        public override void DrawingShape(Graphics g, ref List<Point> lstPoints)
        {
            if (lstPoints.Count == 4)
            {
                g.DrawPolygon(new Pen(Color.Black), lstPoints.ToArray());
                lstPoints.Clear();
            }
        }

        public override Type GetType()
        {
            return typeof(Polygon);
        }      
    }
}
