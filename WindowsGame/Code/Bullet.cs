﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace WindowsGame
{
    class Bullet
    {
        public bool isAlive = true;
        public Vector2 Pos;
        int type = 0;
        double Dir;
        Color color = Color.White;
        float speed = 5;
        public static Texture2D Texture2D { get; set; }
        public static Texture2D EnemyTexture2D { get; set; }
        public Bullet(Vector2 Pos, double Dir, int type, int speed = 5)
        {
            this.Pos = Pos;
            this.Dir = Dir;
            this.type = type;
            this.speed = speed;
        }
        public bool Hidden
        {
            get
            {
                return Pos.X > Asteroids.Width || Pos.X < 0 || Pos.Y > Asteroids.Height || Pos.Y < 0;
            }
        }
        public void Update()
        {
            if (Pos.X < Asteroids.Width)
            {
                Pos.X += this.speed * (float) Math.Cos(this.Dir);
                Pos.Y += this.speed * (float) Math.Sin(this.Dir);
            }
        }
        public void Draw()
        {
            if (type == 0)
            {
                Asteroids.SpriteBatch.Draw(Texture2D, Pos, color);
            } else
            {
                Asteroids.SpriteBatch.Draw(EnemyTexture2D, Pos, color);
            }
        }
    }
}
