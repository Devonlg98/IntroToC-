using Raylib;
using rl = Raylib.Raylib;

namespace ConsoleApp1
{
    static class Program
    {
        public static int Main()
        {
            // Initialization
            //--------------------------------------------------------------------------------------
            int screenWidth = 800;
            int screenHeight = 450;

            rl.InitWindow(screenWidth, screenHeight, "raylib [core] example - basic window");

            rl.SetTargetFPS(60);
            //--------------------------------------------------------------------------------------

            MyShape triangle = new MyShape();
            triangle.MyPoints.Add(new Vector2(10, 10));
            triangle.MyPoints.Add(new Vector2(20, 30));
            triangle.MyPoints.Add(new Vector2(30, 10));
            triangle.MyPoints.Add(new Vector2(10, 10));
            triangle.MyPoints.Add(new Vector2(40, 30));
            triangle.MyPoints.Add(new Vector2(50, 10));
            triangle.position = new Vector2(100, 100);

            MyShape satan = new MyShape();
            satan.MyPoints.Add(new Vector2(0, 11));
            satan.MyPoints.Add(new Vector2(-10, -10));
            satan.MyPoints.Add(new Vector2(13, 3));
            satan.MyPoints.Add(new Vector2(-13, 3));
            satan.MyPoints.Add(new Vector2(10, -10));
            satan.MyPoints.Add(new Vector2(0, 11));
            satan.position.x = 60;
            satan.position.y = 120;

            //Vector2 satanVector = new Vector2();

            //AABB aabb = new AABB();

            //TODO:Create another object with a different shape


            // Main game loop
            while (!rl.WindowShouldClose())    // Detect window close button or ESC key
            {
                // Update
                //----------------------------------------------------------------------------------
                // TODO: Update your variables here
                //----------------------------------------------------------------------------------

                // Draw
                //----------------------------------------------------------------------------------
                rl.BeginDrawing();

                rl.ClearBackground(Color.RAYWHITE);

                rl.DrawText("Congrats! You created your first window!", 190, 200, 20, Color.LIGHTGRAY);
                //triangle.Draw();
                //satan.Draw();
                satan.Draw(satan.blankHitBox.Overlaps(triangle.blankHitBox));
                triangle.Draw(triangle.blankHitBox.Overlaps(satan.blankHitBox));

                satan.DrawCircle();
                satan.DrawCircle(satan.blankHitCircle.Overlaps(triangle.blankHitBox));
                satan.DrawCircle(satan.blankHitCircle.Overlaps(triangle.blankHitBox));

                satan.position.x += .6f;
                triangle.position.x += .2f;

                //rl.DrawCircleLines(1, 1, 1, Color.GREEN);

                //TODO:Move the 2nd object so that it is on a collision course with the triangle
                //TODO:Implement AABB Collision detection so you know when they hit.
                //Recommend adding the AABB Functionality to the myshape class.
                //Add a method to the myshape class that causes the Bounding box to be recalculated and 
                //stored in the myshape class (with the corners/vectors relative to itself)


                //TODO:Bonus have your AABB Box drawn as a green outline to the shapes, and then turn red 
                //When they collide.


                rl.EndDrawing();
                //----------------------------------------------------------------------------------
            }

            // De-Initialization
            //--------------------------------------------------------------------------------------
            rl.CloseWindow();        // Close window and OpenGL context
                                     //--------------------------------------------------------------------------------------

            return 0;
        }
    }
}
