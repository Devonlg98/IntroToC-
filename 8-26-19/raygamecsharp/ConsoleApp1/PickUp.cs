using System;
using System.Collections.Generic;
using System.Text;
using Raylib;
using rl = Raylib.Raylib;

namespace ConsoleApp1
{
    
    class PickUp
    {
        public Vector2Int Position;
        public Color MyColor = Color.RED;
        public bool Enabled = true;
        public float SprScale = 1.25f;
        public static Texture2D MyTexture;

        public static void SetTexture(string _FileName)
        {
            MyTexture = rl.LoadTexture(_FileName);
        }
        public void Draw()
        {
            if (!Enabled)
                return;
            //rl.DrawCircle(Position.x, Position.y, 10f, MyColor); // draw circle only excepts ints
            // rl.DrawRectangle(Position.x - 5, Position.y + 5, 20, 20, MyColor);
            rl.DrawTextureEx(MyTexture,
                new Vector2(Position.x, Position.y),
                0f,
                SprScale,
                Color.WHITE); // white is untinted
               

        }
    }
}
