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
    public struct Matrix3
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9;
        public Matrix3(float val_1, float val_2, float val_3, float val_4, float val_5, float val_6, float val_7, float val_8, float val_9)
        {
            m1 = 1; m2 = 0; m3 = 0;
            m4 = 0; m5 = 1; m6 = 0;
            m7 = 0; m8 = 0; m9 = 1;
        }
        public static Matrix3 operator *(Matrix3 lhs, Matrix3 rhs)
        {
            return new Matrix3(
            lhs.m1 * rhs.m1 + lhs.m2 * rhs.m4 + lhs.m3 * rhs.m7, 
            lhs.m1 * rhs.m2 + lhs.m2 * rhs.m5 + lhs.m3 * rhs.m8,
            lhs.m1 * rhs.m3 + lhs.m2 * rhs.m6 + lhs.m3 * rhs.m9,

            lhs.m4 * rhs.m1 + lhs.m5 * rhs.m4 + lhs.m6 * rhs.m7,
            lhs.m4 * rhs.m2 + lhs.m5 * rhs.m5 + lhs.m6 * rhs.m8,
            lhs.m4 * rhs.m3 + lhs.m5 * rhs.m6 + lhs.m6 * rhs.m9,

            lhs.m7 * rhs.m1 + lhs.m8 * rhs.m4 + lhs.m9 * rhs.m7,
            lhs.m7 * rhs.m2 + lhs.m8 * rhs.m5 + lhs.m9 * rhs.m8,
            lhs.m7 * rhs.m3 + lhs.m8 * rhs.m6 + lhs.m9 * rhs.m9);
        }
        public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
        {
            return new Vector3
               ((lhs.m1 * rhs.x) + (lhs.m2 * rhs.y) + (lhs.m3 * rhs.z),
                (lhs.m4 * rhs.x) + (lhs.m5 * rhs.y) + (lhs.m6 * rhs.z),
                (lhs.m7 * rhs.x) + (lhs.m8 * rhs.y) + (lhs.m9 * rhs.z));
        }

    }

}