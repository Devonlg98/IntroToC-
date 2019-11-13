using System;
using System.Collections.Generic;
using System.Text;
using Raylib;
using rl = Raylib.Raylib;
namespace ConsoleApp1
{
    class MyShape
    {

        public Color NoCollision = Color.GREEN;
        public Color Collision = Color.RED;


        Vector2 minVal = new Vector2(float.PositiveInfinity, float.PositiveInfinity);
        Vector2 maxVal = new Vector2(float.NegativeInfinity, float.NegativeInfinity);


        public Vector2 position = new Vector2();
        public AABB blankHitBox = new AABB(Vector2.Zero, Vector2.Zero);

        public Sphere blankHitCircle = new Sphere(Vector2.Zero, 0f);


        public List<Vector2> MyPoints = new List<Vector2>();

        public void Vector2MinMax()
        {
            minVal = new Vector2(float.PositiveInfinity, float.PositiveInfinity);
            maxVal = new Vector2(float.NegativeInfinity, float.NegativeInfinity);

            for (int i = 0; i < MyPoints.Count; i++)
            {
                if (MyPoints[i].x + position.x > maxVal.x)
                    maxVal.x = MyPoints[i].x + position.x;
                if (MyPoints[i].y + position.y > maxVal.y)
                    maxVal.y = MyPoints[i].y + position.y;
                if (MyPoints[i].x + position.x < minVal.x)
                    minVal.x = MyPoints[i].x + position.x;
                if (MyPoints[i].y + position.y < minVal.y)
                    minVal.y = MyPoints[i].y + position.y;
            }
        }
        public void HitCircle()
        {
            blankHitCircle.Fit(MyPoints);
            blankHitCircle.center += position;

        }
        public void HitBox()
        {
            blankHitBox.Fit(MyPoints);
            blankHitBox.min += position;
            blankHitBox.max += position;

        }
        //Creates Bool overload for Draw to draw a change color on collison
        public void Draw(bool HitBoxCollision)
        {
            if (HitBoxCollision == false)
            {

                rl.DrawLine((int)minVal.x, (int)minVal.y, (int)minVal.x, (int)maxVal.y, NoCollision);
                rl.DrawLine((int)minVal.x, (int)maxVal.y, (int)maxVal.x, (int)maxVal.y, NoCollision);
                rl.DrawLine((int)maxVal.x, (int)maxVal.y, (int)maxVal.x, (int)minVal.y, NoCollision);
                rl.DrawLine((int)maxVal.x, (int)minVal.y, (int)minVal.x, (int)minVal.y, NoCollision);
            }
            if (HitBoxCollision == true)
            {
                rl.DrawLine((int)minVal.x, (int)minVal.y, (int)minVal.x, (int)maxVal.y, Collision);
                rl.DrawLine((int)minVal.x, (int)maxVal.y, (int)maxVal.x, (int)maxVal.y, Collision);
                rl.DrawLine((int)maxVal.x, (int)maxVal.y, (int)maxVal.x, (int)minVal.y, Collision);
                rl.DrawLine((int)maxVal.x, (int)minVal.y, (int)minVal.x, (int)minVal.y, Collision);
            }

        }
        public void DrawCircle(bool HitCircleCollision)
        {
            if (HitCircleCollision == false)
            {
                rl.DrawCircleLines((int)blankHitCircle.center.x, (int)blankHitCircle.center.y, blankHitCircle.radius, NoCollision);
            }
            if (HitCircleCollision == true)
            {
                rl.DrawCircleLines((int)blankHitCircle.center.x, (int)blankHitCircle.center.y, blankHitCircle.radius, Collision);
            }

        }
        public void Draw()
        {
            HitBox();
            Vector2MinMax();
            Vector2 Last = new Vector2(); 
            for(int idx = 0; idx < MyPoints.Count; idx++)
            {
                if(idx>0)
                Raylib.Raylib.DrawLineEx(position+Last, position+MyPoints[idx], 2, Color.BLACK);
                Last = MyPoints[idx];
            }
        }
        public void DrawCircle()
        {

            HitCircle();
            HitBox();
            Vector2MinMax();
            Vector2 Last = new Vector2();
            for (int idx = 0; idx < MyPoints.Count; idx++)
            {
                if (idx > 0)
                    Raylib.Raylib.DrawLineEx(position + Last, position + MyPoints[idx], 2, Color.BLACK);
                Last = MyPoints[idx];
            }
        }
    }
}
