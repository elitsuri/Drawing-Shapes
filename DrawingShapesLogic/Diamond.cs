using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DrawingShapesLogic
{
    public sealed class Diamond : Shape
    {      
        public Diamond()
        {

        }

        public Diamond(int x, int y, int width, int height) : base(x, y, width, height)
        {


        }

        public override void DrawingShape(Graphics g, int x, int y, int width, int height)
        {
            throw new NotImplementedException();
        }

        public override void DrawingShape(Graphics g, ref List<Point> lstPoints)
        {
            throw new NotImplementedException();
        }

        public override Type GetType()
        {
            return typeof(Diamond);
        }       
    }
}
