using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DrawingShapesLogic
{
    interface IDrawingPoints
    {
        void DrawingShape(Graphics g, ref List<Point> lstPoints);
    }
}
