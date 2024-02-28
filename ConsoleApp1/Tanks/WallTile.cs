
using Shard;

namespace GameTanks
{
    class WallTile : GameObject, InputListener, CollisionHandler
    {
        //private int health;

        //public int Health { get => health; set => health = value; }

        public override void initialize()
        {


            setPhysicsEnabled();

            MyBody.Mass = 1;
            MyBody.Kinematic = true;

            MyBody.addRectCollider();

            addTag("WallTile");

        }


        public void handleInput(InputEvent inp, string eventType)
        {




        }


        public override void update()
        {

            this.Transform.SpritePath = Bootstrap.getAssetManager().getAssetPath("wall.png");
            this.Transform.Scalex = 2.0f;
            this.Transform.Scaley = 2.0f;
            Bootstrap.getDisplay().addToDraw(this);
        }

        public void onCollisionEnter(PhysicsBody x)
        {
            //Health -= 1;

            //if (Health <= 0)
            //{
            //    this.ToBeDestroyed = true;
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
            return "WallTile: [" + Transform.X + ", " + Transform.Y + ", " + Transform.Wid + ", " + Transform.Ht + "]";
        }

    }
}
