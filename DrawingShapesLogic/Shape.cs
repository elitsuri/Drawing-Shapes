using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DrawingShapesLogic
{ 
    public abstract class Shape : IDrawing, IDrawingPoints
    {
        private int _x;
        private int _y;

        public Shape()
        {

        }

        public Shape(int x, int y, int w, int h)
        {
            _x = x;
            _y = y;
        }

        public int LastX
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }
        public int LastY
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }

        public abstract void DrawingShape(Graphics g, int x, int y, int width, int height);
        public abstract void DrawingShape(Graphics g,ref List<Point> lstPoints);
        public new abstract Type GetType();           
    }
}
