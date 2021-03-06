using System;
using System.Collections.Generic;
using System.Text;

namespace TestingClasses
{
    public class Point
    {
        private double x;
        private double y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
           set { this.y = value; }
        }
    }
}
