using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AABB
    {
        Vector3 min = new Vector3(float.NegativeInfinity,
       float.NegativeInfinity,
       float.NegativeInfinity);
        Vector3 max = new Vector3(float.PositiveInfinity,
       float.PositiveInfinity,
       float.PositiveInfinity);
        public AABB()
        {
        }
        //Finding minimum and maximum of vector3
        public AABB(Vector3 min, Vector3 max)
        {
            this.min = min;
            this.max = max;
        }

        //Finding the center of the box
        public Vector3 Center()
        {
            return (min + max) * 0.5f;
        }
        public Vector3 Extents()
        {
            return new Vector3(Math.Abs(max.x - min.x) * 0.5f,
            Math.Abs(max.y - min.y) * 0.5f,
            Math.Abs(max.z - min.z) * 0.5f);
        }
        public void Fit(List<Vector3> points)
        {
            // invalidate the extents
            min = new Vector3(float.PositiveInfinity,
           float.PositiveInfinity,
           float.PositiveInfinity);
            max = new Vector3(float.NegativeInfinity,
           float.NegativeInfinity,
           float.NegativeInfinity);
            // more to come here...
        }

    }
}
