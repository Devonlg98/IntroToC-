using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Raylib.Raylib;
using Raylib;

namespace ConsoleApp1
{
    class Game
    {
        SceneObject tankObject = new SceneObject();
        SceneObject turretObject = new SceneObject();
        SpriteObject tankSprite = new SpriteObject();
        SpriteObject turretSprite = new SpriteObject();
        SceneObject tankHitBoxBL = new SceneObject();
        SceneObject tankHitBoxBR = new SceneObject();
        SceneObject tankHitBoxTL = new SceneObject();
        SceneObject tankHitBoxTR = new SceneObject();

        SceneObject tankObject2 = new SceneObject();
        SceneObject turretObject2 = new SceneObject();
        SpriteObject tankSprite2 = new SpriteObject();
        SpriteObject turretSprite2 = new SpriteObject();


        Timer gameTime = new Timer();
        private float timer = 0;
        private int fps = 1;
        private int frames;
        private float deltaTime;

        public void Init()
        {

            tankSprite.Load("Resources/topdowntanks/PNG/Tanks/tankGreen_outline.png");
            // sprite is facing the wrong way... fix that here
            tankSprite.SetRotate(-90 * (float)(Math.PI / 180.0f));
            // sets an offset for the base, so it rotates around the centre
            tankSprite.SetPosition(-tankSprite.Width / 2.0f, tankSprite.Height /2.0f);
            
            turretSprite.Load("Resources/topdowntanks/PNG/Tanks/barrelGreen.png");
            turretSprite.SetRotate(-90 * (float)(Math.PI / 180.0f));
            // set the turret offset from the tank base
            turretSprite.SetPosition(0, turretSprite.Width / 2.0f);

            // set up the scene object hierarchy - parent the turret to the base,
            // then the base to the tank sceneObject
            turretObject.AddChild(turretSprite);
            tankObject.AddChild(tankSprite);
            tankObject.AddChild(turretObject);
            tankObject.AddChild(tankHitBoxTL);
            tankObject.AddChild(tankHitBoxTR);
            tankObject.AddChild(tankHitBoxBR);
            tankObject.AddChild(tankHitBoxBL);
            tankHitBoxTL.SetPosition((-tankSprite.Width / 2.0f), -tankSprite.Height / 2.0f);    //(0,0)
            tankHitBoxTR.SetPosition((tankSprite.Width / 2.0f), -tankSprite.Height / 2.0f);     //(1,0)
            tankHitBoxBR.SetPosition((tankSprite.Width / 2.0f), tankSprite.Height / 2.0f);      //(1,1)
            tankHitBoxBL.SetPosition((-tankSprite.Width / 2.0f), tankSprite.Height / 2.0f);     //(0,1)



            // having an empty object for the tank parent means we can set the
            // position/rotation of the tank without
            // affecting the offset of the base sprite
            tankObject.SetPosition((GetScreenWidth() / 2.0f) - 100f, GetScreenHeight() / 2.0f);
            
            tankSprite2.Load("Resources/topdowntanks/PNG/Tanks/tankBlue_outline.png");
            tankSprite2.SetRotate(-90 * (float)(Math.PI / 180.0f));
            tankSprite2.SetPosition(-tankSprite2.Width / 2.0f, tankSprite2.Height /2.0f);
            turretSprite2.Load("Resources/topdowntanks/PNG/Tanks/barrelBlue.png");
            turretSprite2.SetRotate(-90 * (float)(Math.PI / 180.0f));
            turretSprite2.SetPosition(0, turretSprite2.Width / 2.0f);
            turretObject2.AddChild(turretSprite2);
            tankObject2.AddChild(tankSprite2);
            tankObject2.AddChild(turretObject2);
            tankObject2.SetPosition((GetScreenWidth() / 2.0f)+100f, GetScreenHeight() / 2.0f);
            //TankObjectAddChild4ChildCorners so they rotate with the tank

        }
        public void Shutdown()
        {

        }
        public void Update()
        {
            deltaTime = gameTime.GetDeltaTime();
            timer += deltaTime;
            if (timer >= 1)
            {
                fps = frames;
                frames = 0;
                timer -= 1;
            }
            frames++;

            //Player 1 movement
            if (IsKeyDown(KeyboardKey.KEY_A))
            {
                tankObject.Rotate(-deltaTime);
            }
            if (IsKeyDown(KeyboardKey.KEY_D))
            {
                tankObject.Rotate(deltaTime);
            }
            if (IsKeyDown(KeyboardKey.KEY_W))
            {
                Vector3 facing = new Vector3(
                tankObject.LocalTransform.m1,
                tankObject.LocalTransform.m2, 1) * deltaTime * 100;
                tankObject.Translate(facing.x, facing.y);
            }
            if (IsKeyDown(KeyboardKey.KEY_S))
            {
                Vector3 facing = new Vector3(
               tankObject.LocalTransform.m1,
               tankObject.LocalTransform.m2, 1) * deltaTime * -100;
                tankObject.Translate(facing.x, facing.y);
            }
            tankObject.Update(deltaTime);

            if (IsKeyDown(KeyboardKey.KEY_Q))
            {
                turretObject.Rotate(-deltaTime);
            }
            if (IsKeyDown(KeyboardKey.KEY_E))
            {
                turretObject.Rotate(deltaTime);
            }

            //Player 2 movement

            if (IsKeyDown(KeyboardKey.KEY_KP_4))
            {
                tankObject2.Rotate(-deltaTime);
            }
            if (IsKeyDown(KeyboardKey.KEY_KP_6))
            {
                tankObject2.Rotate(deltaTime);
            }
            if (IsKeyDown(KeyboardKey.KEY_KP_8))
            {
                Vector3 facing = new Vector3(
                tankObject2.LocalTransform.m1,
                tankObject2.LocalTransform.m2, 1) * deltaTime * 100;
                tankObject2.Translate(facing.x, facing.y);
            }
            if (IsKeyDown(KeyboardKey.KEY_KP_5))
            {
                Vector3 facing = new Vector3(
               tankObject2.LocalTransform.m1,
               tankObject2.LocalTransform.m2, 1) * deltaTime * -100;
                tankObject2.Translate(facing.x, facing.y);
            }
            tankObject2.Update(deltaTime);

            if (IsKeyDown(KeyboardKey.KEY_KP_7))
            {
                turretObject2.Rotate(-deltaTime);
            }
            if (IsKeyDown(KeyboardKey.KEY_KP_9))
            {
                turretObject2.Rotate(deltaTime);
            }


        }


    public void Draw()
        {
            BeginDrawing();
            ClearBackground(Color.WHITE);
            DrawText(fps.ToString(), 10, 10, 12, Color.RED);
            tankObject.Draw();
            tankObject2.Draw();
            EndDrawing();

        }

    }
}