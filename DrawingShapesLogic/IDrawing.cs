using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DrawingShapesLogic
{
    public interface IDrawing
    {
        void DrawingShape(Graphics g, int x, int y, int width, int height);
    }
}
