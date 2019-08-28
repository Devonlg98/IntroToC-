using System;
using System.Collections.Generic;
using System.Text;
using Raylib;
using rl = Raylib.Raylib;

namespace ConsoleApp1
{
    struct Vector2Int
    {
        public int x;
        public int y;
    }

    class Player
    {
        public bool movementManager = true;
        public bool timerManager = true;
        public int plHealth = 5;
        public int speed = 3;
        Program pr = new Program();
        public int timer = 0;
        public Vector2Int Position = new Vector2Int();
        public Color MyColor = Color.GREEN;
        public void RunUpdate()
        {
            if (movementManager == true)
            {
                if (rl.IsKeyDown(KeyboardKey.KEY_LEFT_SHIFT))
                {
                    Console.WriteLine("SPRINT");
                    speed = 6;
                }
                else
                {
                    speed = 3;
                }
            
            }
            if (rl.IsKeyDown(KeyboardKey.KEY_W))
            {
                Console.WriteLine(" GOINNNN UPPP");
                Position.y -= speed;
            }
            if (rl.IsKeyDown(KeyboardKey.KEY_S))
            {
                Console.WriteLine(" GOINNNN DOWNNN");
                Position.y += speed;
            }
            if (rl.IsKeyDown(KeyboardKey.KEY_A))
            {
                Console.WriteLine(" Too the left");
                Position.x -= speed;
            }
            if (rl.IsKeyDown(KeyboardKey.KEY_D))
            {
                Console.WriteLine(" Too the right");
                Position.x += speed;
            }

            if (Position.x > 800)
            {
                Position.x = 0;
            }
            if (Position.x < 0)
            {
                Position.x = 800;
            }
            if (Position.y > 450)
            {
                Position.y = -50;
            }
            if (Position.y < -50)
            {
                Position.y = 450;
            }
            if (timerManager == true)
            {
            timer++;
            }
           
        }

        public void Draw()
        {
            rl.DrawCircle(Position.x, Position.y, 5f, MyColor); // draw circle only excepts ints
            rl.DrawRectangle(Position.x-5, Position.y+5, 10, 30, MyColor);

        }
    }
}
