using SDL2;
using Shard;
using System.Drawing;

namespace GameTanks
{
    class Tank1 : GameObject, InputListener, CollisionHandler
    {
        bool up, down, turnLeft, turnRight;
        private int health1;
        public int Health1 { get => health1; set => health1 = value; }

        public override void initialize()
        {

            this.Transform.X = 150.0f;
            this.Transform.Y = 150.0f;
            this.Transform.SpritePath = Bootstrap.getAssetManager().getAssetPath("BasicTank.png");


            Bootstrap.getInput().addListener(this);

            up = false;
            down = false;

            setPhysicsEnabled();

            MyBody.Mass = 1;
            MyBody.MaxForce = 10;
            MyBody.AngularDrag = 0.2f;
            MyBody.Drag = 10f;
            MyBody.StopOnCollision = true;
            MyBody.ReflectOnCollision = false;
            MyBody.ImpartForce = false;
            MyBody.Kinematic = false;


            //           MyBody.PassThrough = true;
            //            MyBody.addCircleCollider(0, 0, 5);
            //            MyBody.addCircleCollider(0, 34, 5);
            //            MyBody.addCircleCollider(60, 18, 5);
            //     MyBody.addCircleCollider();

            MyBody.addRectCollider();

            addTag("Tank1");


        }

        public void fireBullet1()
        {
            Bullet1 b1 = new Bullet1();

            b1.setupBullet1(this, this.Transform.Centre.X + 20, this.Transform.Centre.Y);

            b1.Transform.rotate(this.Transform.Rotz);
            

            Bootstrap.getSound().playSound("fire.wav");
        }

        public void handleInput(InputEvent inp, string eventType)
        {



            if (eventType == "KeyDown")
            {
                if (inp.Key == (int)SDL.SDL_Scancode.SDL_SCANCODE_W)
                {
                    up = true;
                }

                if (inp.Key == (int)SDL.SDL_Scancode.SDL_SCANCODE_S)
                {
                    down = true;
                }

                if (inp.Key == (int)SDL.SDL_Scancode.SDL_SCANCODE_D)
                {
                    turnRight = true;
                }

                if (inp.Key == (int)SDL.SDL_Scancode.SDL_SCANCODE_A)
                {
                    turnLeft = true;
                }

            }
            else if (eventType == "KeyUp")
            {
                if (inp.Key == (int)SDL.SDL_Scancode.SDL_SCANCODE_W)
                {
                    up = false;
                }

                if (inp.Key == (int)SDL.SDL_Scancode.SDL_SCANCODE_S)
                {
                    down = false;
                }

                if (inp.Key == (int)SDL.SDL_Scancode.SDL_SCANCODE_D)
                {
                    turnRight = false;
                }

                if (inp.Key == (int)SDL.SDL_Scancode.SDL_SCANCODE_A)
                {
                    turnLeft = false;
                }


            }



            if (eventType == "KeyUp")
            {
                if (inp.Key == (int)SDL.SDL_Scancode.SDL_SCANCODE_SPACE)
                {
                    fireBullet1();
                }
            }
        }

        public override void physicsUpdate()
        {

            if (turnLeft)
            {
                MyBody.addTorque(-0.3f);
            }

            if (turnRight)
            {
                MyBody.addTorque(0.3f);
            }

            if (up)
            {

                MyBody.addForce(this.Transform.Forward, 2f);

            }

            if (down)
            {
                MyBody.addForce(this.Transform.Forward, -2f);
            }


        }

        public override void update()
        {
            Bootstrap.getDisplay().addToDraw(this);
        }

        public void onCollisionEnter(PhysicsBody x)
        {
            if (x.Parent.checkTag("Bullet2") == true)
            {
                MyBody.DebugColor = Color.Red;
                Health1 -= 1;

                if (Health1 <= 0)
                {
                    this.ToBeDestroyed = true;
                }
            }
        }

        public void onCollisionExit(PhysicsBody x)
        {
        }

        public void onCollisionStay(PhysicsBody x)
        {
        }

        public override string ToString()
        {
            return "Tank1: [" + Transform.X + ", " + Transform.Y + ", " + Transform.Wid + ", " + Transform.Ht + "]";
        }

    }

}
