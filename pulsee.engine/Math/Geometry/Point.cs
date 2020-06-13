using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace pulsee.engine.Math.Geometry
{
    class Point
    {
        public float x;

        public float y;

        public Point(int x_, int y_)
        {
            x = x_;
            y = y_;
        }

        public Point(float x_, float y_)
        {
            x = x_;
            y = y_;
        }
    }
}
