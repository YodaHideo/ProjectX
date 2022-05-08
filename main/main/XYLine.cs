using System;
using System.Collections.Generic;
using System.Text;

namespace main
{
    public class XYLine
    {
        public double x
        {
            get { return x; }
            set { x = value; }
        }
        public double y
        {
            get { return y; }
            set { y = value; }
        }
        public double x2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public double y2
        {
            get { return y2; }
            set { y2 = value; }
        }
        public XYLine(double x, double y, double x2, double y2)
        {
            this.x = x; this.y = y; this.x2 = x2; this.y2 = y2;
        }

    }
}
