using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialPandV
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3 firstVector3 = new Vector3(0, 1, 2);
            Vector3 secondVector3 = new Vector3(9, -2, 7);

            Vector2 firstVector2 = new Vector2(-2, 5.5f);
            Vector2 secondVector2 = new Vector2(9, -22);

            Vector2 firstVector22 = new Vector2(1, 0);
            Vector2 secondVector22 = new Vector2(0, 1);

            Vector3 firstVector32 = new Vector3(2, 3, 1);
            Vector3 secondVector32 = new Vector3(-3, 1, 2);


            Console.WriteLine(firstVector2.Distance(secondVector2));
            Console.WriteLine(firstVector3.Distance(secondVector3));
            Console.WriteLine(firstVector32.Dot(secondVector32));

            Console.ReadKey();
        }
    }

    public struct Vector2
    {
        public float x, y;
        public Vector2(float xValue, float yValue)
        {
            x = xValue;
            y = yValue;
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y);
        }

        public float MagnitudeSqrt()
        {
            float sqrd = (float)Math.Sqrt(x * x + y * y);
            return sqrd * sqrd;
        }
        public float Distance(Vector2 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            return (float)Math.Sqrt(diffX * diffX + diffY * diffY);
        }

        public float Dot(Vector2 rhs)
        {
            return x * rhs.x + y * rhs.y;
        }

    }
    public struct Vector3
    {

        public float x, y, z;

        public Vector3(float xValue, float yValue, float zValue)
        {
            x = xValue;
            y = yValue;
            z = zValue;
        }
        public float Distance(Vector3 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            return (float)Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ);
        }
        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
        public float Dot(Vector3 rhs)
        {
            return x * rhs.x + y * rhs.y + z * rhs.z;
        }        public Vector3 Cross(Vector3 rhs)
        {
            return new Vector3(
           y * rhs.z - z * rhs.y,
           z * rhs.x - x * rhs.z,
           x * rhs.y - y * rhs.x);
        }
        public void Normalize()
        {
            float m = Magnitude();
            this.x /= m; this.y /= m; this.z /= m;
        }
    }
}
