using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDp
{
    public class Point : IProto<Point>
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X : {X} Y : {Y}";
        }

        public Point Clone()
        {
            Point result = new Point(this.X, this.Y);
            return result;
        }
    }
}
