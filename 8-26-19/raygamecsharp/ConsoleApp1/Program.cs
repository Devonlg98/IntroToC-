using System;
using System.Collections.Generic;
using System.Text;
using Raylib;
using rl = Raylib.Raylib;

namespace ConsoleApp1
{
    class Program
    {
        

        public static bool CheckCollisionV1(Player _pl,PickUp _pu)
        {
            bool rtn = false;
            //Rectangle PlayerCol = new Rectangle(_pl.Position.x - 5, _pl.Position.y - 5, 10, 40);


            float w = PickUp.MyTexture.width * _pu.SprScale;// Hit Box Scales
            //float h = _pu.MyTexture.height * _pu.SprScale;
            float h = PickUp.MyTexture.height * _pu.SprScale;
            //float w = PickUp.MyTexture
            Rectangle PickUpColl = new Rectangle(_pu.Position.x, _pu.Position.y, w, h);
            
            //PickUpColl = new Rectangle(_pu.Position.x - .5f*w, _pu.Position.y - .5f*h, w, h,);

            rl.DrawRectangleLines(_pu.Position.x, _pu.Position.y, (int)w, (int)h, Color.GREEN);



            Rectangle PlayerCol = new Rectangle(_pl.Position.x -5, _pl.Position.y -5, 10, 40);// 40 instead of 30 includes circle

            rtn = rl.CheckCollisionRecs(PlayerCol, PickUpColl);
            if (rtn) _pu.Enabled = false;


            return rtn;
        }
        public static bool CheckCollisionV2(Player _pl, Enemy _en)
        {
            bool rtnE = false;
            //Rectangle PlayerCol = new Rectangle(_pl.Position.x - 5, _pl.Position.y - 5, 10, 40);


            float w = Enemy.MyTexture.width * _en.SprScale;// Hit Box Scales
            //float h = _pu.MyTexture.height * _pu.SprScale;
            float h = Enemy.MyTexture.height * _en.SprScale;
            //float w = PickUp.MyTexture
            Rectangle EnemyColl = new Rectangle(_en.Position.x, _en.Position.y, w, h);

            //PickUpColl = new Rectangle(_pu.Position.x - .5f*w, _pu.Position.y - .5f*h, w, h,);

            rl.DrawRectangleLines(_en.Position.x, _en.Position.y, (int)w+5, (int)h+5, Color.GREEN);

            //-\\(-_-)/-

            Rectangle PlayerCol = new Rectangle(_pl.Position.x - 5, _pl.Position.y - 5, 10, 40);// 40 instead of 30 includes circle

            rtnE = rl.CheckCollisionRecs(PlayerCol, EnemyColl);
            if (rtnE)
            {
                _en.Life = false;
            }

            return rtnE;
        }
        public static int Main()
        {
            // Initialization
            //--------------------------------------------------------------------------------------
            int screenWidth = 800;
            int screenHeight = 450;
            int score = 0;
            bool winState = false;
            int timeLose = 20;

            Player MyPlayer = new Player();
            Random rd = new Random();
            
            MyPlayer.Position.x = 75;
            MyPlayer.Position.y = 75;


            PickUp[] Test = new PickUp[1000];
            Enemy[] enemyIdx = new Enemy[5];
            int idx = 0;
            int idxE = 0;
            string[] gemPickUp = new string[10] {"gem1.png", "gem2.png", "gem3.png", "gem4.png", "gem5.png", "gem6.png", "gem7.png", "gem8.png", "gem9.png", "gem10.png"};

            
            rl.InitWindow(screenWidth, screenHeight, "raylib [core] example - basic window");

            Enemy.SetTexture("ghost_normal.png");

            for (int x = 0; x < 5 && idxE < 5; x++)
            {
                enemyIdx[idxE] = new Enemy();
                enemyIdx[idxE].Position.x = rd.Next(100, 700);
                enemyIdx[idxE].Position.y = rd.Next(50, 350);
                //Test[idx].SetTexture("GenericString[1]");
                enemyIdx[idxE].SprScale = .5f;
                idxE++;
            }


            PickUp.SetTexture("platformPack_item009.png");

            for (int x = 0; x < 1000 && idx < 1000; x++)
            {
                Test[idx] = new PickUp();
                Test[idx].Position.x = rd.Next(100,700);
                Test[idx].Position.y = rd.Next(50, 350);
                //Test[idx].SetTexture("platformPack_item009fix.png");
                Test[idx].SprScale = 1f;
                idx++;
            }
            
            rl.SetTargetFPS(60);
            //--------------------------------------------------------------------------------------
            // Main game loop
            while (!rl.WindowShouldClose())    // Detect window close button or ESC key
            {
                // Update
                //----------------------------------------------------------------------------------
                // TODO: Update your variables here
                //----------------------------------------------------------------------------------
                MyPlayer.RunUpdate();
                // Draw
                //----------------------------------------------------------------------------------
                rl.BeginDrawing();
                rl.ClearBackground(Color.BLACK);
                rl.DrawText($"Score = {score}", 50, 50, 20, Color.GREEN); rl.DrawText($"Score = {score}", 50, 50, 20, Color.GREEN);
                rl.DrawText($"Health = {MyPlayer.plHealth}", 50, 100, 20, Color.GREEN);
                rl.DrawText($"TIME : {MyPlayer.timer/60}", 400, 50, 20, Color.GREEN);
                rl.DrawText("Pick Up Dem Cubes", 200, 50, 20, Color.GREEN);
                MyPlayer.Draw();
                if (MyPlayer.timer / 60 % 2 == 1)
                {
                    PickUp.SetTexture("platformPack_item009fix.png");
                    Console.WriteLine("debug1");
                }
                for(int i= 0; i<10; i++)
                {
                    if (MyPlayer.timer / 60 % 2 == 0)
                    {
                        PickUp.SetTexture(gemPickUp[i]);
                        Console.WriteLine("debug1");
                    }
                }
                foreach (Enemy enemy in enemyIdx)
                {
                    if (enemy.Life && !winState)
                    {
                        enemy.Draw();
                        if (CheckCollisionV2(MyPlayer, enemy))
                        {
                            MyPlayer.plHealth--;
                        }
                    }
                    if (enemy.Position.x < MyPlayer.Position.x)
                    {
                        enemy.Position.x++;
                    }
                    if (enemy.Position.x > MyPlayer.Position.x)
                    {
                        enemy.Position.x--;
                    }
                    if (enemy.Position.y < MyPlayer.Position.y)
                    {
                        enemy.Position.y++;
                    }
                    if (enemy.Position.y > MyPlayer.Position.y)
                    {
                        enemy.Position.y--;
                    }

                }

                foreach (PickUp pickup in Test)
                {
                    if (pickup.Enabled)
                    {
                        pickup.Draw();
                        score += CheckCollisionV1(MyPlayer, pickup) ? 1 : 0; //evaluate as if an if statement

                        //if (CheckCollisionV1(MyPlayer, pickup))
                        //{
                        //    score++;
                        //} // works the same as above
                    }

                }
                if (((MyPlayer.timer / 60) >=timeLose) && (winState == false))
                {
                    rl.DrawText("YOU LOSE",200, 225, 100, Color.GREEN);
                    MyPlayer.movementManager = false;
                    MyPlayer.timerManager = false;
                    MyPlayer.speed = 0;
                    //MyPlayer.sprint = 0;
                    
                }

                //Console.WriteLine(CheckCollisionV1(MyPlayer, Test));
                rl.EndDrawing();
                //----------------------------------------------------------------------------------
                if (MyPlayer.plHealth  <= 0)
                {
                    rl.DrawText("YOU DIED", 200, 225, 100, Color.GREEN);
                    MyPlayer.movementManager = false;
                    MyPlayer.timerManager = false;
                    MyPlayer.speed = 0;
                }

                if (score == 50)
                {
                    rl.DrawText("YOU WIN", 200, 225, 100, Color.GREEN);
                    winState =true;
                    MyPlayer.movementManager = false;
                    MyPlayer.timerManager = false;
                    MyPlayer.speed = 0;

                }
            }

            // De-Initialization
            //--------------------------------------------------------------------------------------
            rl.CloseWindow();        // Close window and OpenGL context
            //--------------------------------------------------------------------------------------

            return 0;
        }
    }
}