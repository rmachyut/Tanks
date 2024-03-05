using Shard;
using System;
using System.Drawing;
using System.IO;

namespace GameTanks
{
    class Bullet1 : GameObject, CollisionHandler
    {
        private Tank1 origin;

        public void setupBullet1(Tank1 or, float x, float y)
        {
            this.Transform.X = x;
            this.Transform.Y = y;
            this.Transform.Wid = 10;
            this.Transform.Ht = 10;

            this.origin = or;

            //this.Transform.SpritePath = Bootstrap.getAssetManager().getAssetPath("ball.png");
            setPhysicsEnabled();

            //MyBody.addRectCollider((int)x, (int)y, 10, 10);

            //addTag("Bullet");
            MyBody.addCircleCollider();
            //            MyBody.addCircleCollider((int)x, (int)y, 5);

            MyBody.Mass = 1;
            MyBody.MaxForce = 5;
            //            MyBody.addTorque(0.001f);

            //MyBody.PassThrough = true;

        }

        public override void initialize()
        {
            this.Transient = true;
            this.Transform.SpritePath = Bootstrap.getAssetManager().getAssetPath("ball.png");
            addTag("Bullet1");
            

        }

        public override void physicsUpdate()
        {
            MyBody.addForce(this.Transform.Forward, 100.0f);
        }

        public override void update()
        {
            Bootstrap.getDisplay().addToDraw(this);

            //Random r = new Random();
            //Color col = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);


            //Bootstrap.getDisplay().drawLine(
            //    (int)Transform.X - 5,
            //    (int)Transform.Y - 5,
            //    (int)Transform.X + 5,
            //    (int)Transform.Y - 5,
            //    col);

            //Bootstrap.getDisplay().drawLine(
            //    (int)Transform.X + 5,
            //    (int)Transform.Y - 5,
            //    (int)Transform.X + 5,
            //    (int)Transform.Y + 5,
            //    col);

            //Bootstrap.getDisplay().drawLine(
            //    (int)Transform.X + 5,
            //    (int)Transform.Y + 5,
            //    (int)Transform.X - 5,
            //    (int)Transform.Y + 5,
            //    col);

            //Bootstrap.getDisplay().drawLine(
            //    (int)Transform.X - 5,
            //    (int)Transform.Y + 5,
            //    (int)Transform.X - 5,
            //    (int)Transform.Y - 5,
            //    col);

        }

        public void onCollisionEnter(PhysicsBody x)
        {
            if (x.Parent.checkTag("Tank2") == true)
            {
                Debug.Log("Boom! " + x);
                ToBeDestroyed = true;
            }
            //else
            //{
            //    Directory = 
            //}
        }

        public void onCollisionExit(PhysicsBody x)
        {
        }

        public void onCollisionStay(PhysicsBody x)
        {
        }

        public override string ToString()
        {
            return "Bullet1: " + Transform.X + ", " + Transform.X;
        }
    }
        class Bullet2 : GameObject, CollisionHandler
        {
            private Tank2 origin;

            public void setupBullet2(Tank2 or, float x, float y)
            {
                this.Transform.X = x;
                this.Transform.Y = y;
                this.Transform.Wid = 10;
                this.Transform.Ht = 10;

                this.origin = or;

                //this.Transform.SpritePath = Bootstrap.getAssetManager().getAssetPath("ball.png");
                setPhysicsEnabled();

                //MyBody.addRectCollider((int)x, (int)y, 10, 10);

                //addTag("Bullet");
                MyBody.addCircleCollider();
                //            MyBody.addCircleCollider((int)x, (int)y, 5);

                MyBody.Mass = 1;
                MyBody.MaxForce = 5;
                //            MyBody.addTorque(0.001f);

                //MyBody.PassThrough = true;

            }

            public override void initialize()
            {
                this.Transient = true;
                this.Transform.SpritePath = Bootstrap.getAssetManager().getAssetPath("ball.png");
                addTag("Bullet2");


            }

            public override void physicsUpdate()
            {
                MyBody.addForce(this.Transform.Forward, 100.0f);
            }

            public override void update()
            {
                Bootstrap.getDisplay().addToDraw(this);

                //Random r = new Random();
                //Color col = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);


                //Bootstrap.getDisplay().drawLine(
                //    (int)Transform.X - 5,
                //    (int)Transform.Y - 5,
                //    (int)Transform.X + 5,
                //    (int)Transform.Y - 5,
                //    col);

                //Bootstrap.getDisplay().drawLine(
                //    (int)Transform.X + 5,
                //    (int)Transform.Y - 5,
                //    (int)Transform.X + 5,
                //    (int)Transform.Y + 5,
                //    col);

                //Bootstrap.getDisplay().drawLine(
                //    (int)Transform.X + 5,
                //    (int)Transform.Y + 5,
                //    (int)Transform.X - 5,
                //    (int)Transform.Y + 5,
                //    col);

                //Bootstrap.getDisplay().drawLine(
                //    (int)Transform.X - 5,
                //    (int)Transform.Y + 5,
                //    (int)Transform.X - 5,
                //    (int)Transform.Y - 5,
                //    col);

            }

            public void onCollisionEnter(PhysicsBody x)
            {
                if (x.Parent.checkTag("Tank1") == true)
                {
                    Debug.Log("Boom! " + x);
                    ToBeDestroyed = true;
                }
                //else
                //{
                //    Directory = 
                //}
            }

            public void onCollisionExit(PhysicsBody x)
            {
            }

            public void onCollisionStay(PhysicsBody x)
            {
            }

            public override string ToString()
            {
                return "Bullet2: " + Transform.X + ", " + Transform.X;
            }
        }
    
}
