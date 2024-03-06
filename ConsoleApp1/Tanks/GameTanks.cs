using GameTanks;
using GameTest;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Shard
{
    class GameTanks : Game
    {
        GameObject top, left, right, bottom;
        Random rand;
        List<WallTile> myWallTiles;
        List<FloorTile> myFloorTiles;
        public override void update()
        {

            Bootstrap.getDisplay().showText("FPS: " + Bootstrap.getFPS(), 10, 10, 12, 255, 255, 255);
            Bootstrap.getDisplay().showText("Delta: " + Bootstrap.getDeltaTime(), 10, 20, 12, 255, 255, 255);

            foreach (WallTile b in myWallTiles)
            {
                if (b != null && b.ToBeDestroyed == false)
                {
                    return;
                }

            }
            foreach (FloorTile b in myFloorTiles)
            {
                return;
            }

            //createTiles();
        }

        public void createTiles()
        {
            myWallTiles.Clear();
            myFloorTiles.Clear();

            FloorTile ft = new FloorTile();
            ft.Transform.X = 100;
            ft.Transform.Y = 100;
            ft.Transform.Scalex = 30.0f;
            ft.Transform.Scaley = 30.0f;
            myFloorTiles.Add(ft);

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {

                    /*if (i % 2 == 0 || j % 2 == 0)
                    {
                        continue;
                    }*/
                    if (i == 0 || i == 14 || j == 0 || j == 14)
                    {
                        WallTile br = new WallTile();
                        br.Transform.X = 100 + (i * 40);
                        br.Transform.Y = 100 + (j * 40);
                        //br.Health = 1 + rand.Next(3);
                        myWallTiles.Add(br);
                    }
                    else if ((i == 1 && j == 10) || (i == 3 && j == 1) || (i == 3 && j == 2) || (i == 4 && j == 6) || (i == 4 && j == 7) || (i == 4 && j == 8) || (i == 4 && j == 9) || (i == 4 && j == 10) || (i == 4 && j == 11) || (i == 7 && j == 8) || (i == 7 && j == 9) || (i == 7 && j == 10) || (i == 8 && j == 10) || (i == 9 && j == 10) || (i == 10 && j == 10) || (i == 11 && j == 10) || (i == 12 && j == 3) || (i == 13 && j == 3))
                    {
                        WallTile br = new WallTile();
                        br.Transform.X = 100 + (i * 40);
                        br.Transform.Y = 100 + (j * 40);
                        //br.Health = 1 + rand.Next(3);
                        myWallTiles.Add(br);
                    }
                    //else
                    //{
                    //    FloorTile br = new FloorTile();
                    //    br.Transform.X = 100 + (i * 40);
                    //    br.Transform.Y = 100 + (j * 40);
                    //    myFloorTiles.Add(br);
                    //}
                }
            }
        }

        public override void initialize()
        {
            rand = new Random();

            myWallTiles = new List<WallTile>();
            myFloorTiles = new List<FloorTile>();

            createTiles();

            Tank1 p1 = new Tank1();
            p1.Health1 = 3;
            Tank2 p2 = new Tank2();
            p2.Health2 = 3;

            //Ball b = new Ball();
            //b.Transform.X = 150;
            //b.Transform.Y = 150;
            //b.Dir = new Vector2(1, 1);
            //b.LastDir = new Vector2(1, 1);


        }

        public override int getTargetFrameRate()
        {

            return 60;

            
        }
    }



}
