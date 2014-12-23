using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TileGame1
{
    class SpriteMap
    {
        public Texture2D Texture { get; private set; }
        public int Columns { get; private set; }
        public int Rows { get; private set; }
        public int SpriteWidth { get; private set; }
        public int SpriteHeight { get; private set; }
        public List<Rectangle> Sprites { get; private set; }

        public SpriteMap(Texture2D texture, int columns, int rows)
        {
            this.Texture = texture;
            this.Columns = columns;
            this.Rows = rows;

            this.SpriteWidth = texture.Width / columns;
            this.SpriteHeight = texture.Height / rows;

            var sprites = new List<Rectangle>(Columns * Rows);
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    var rectangle = new Rectangle(SpriteWidth * col, SpriteHeight * row, SpriteWidth, SpriteHeight);
                    sprites.Add(rectangle);
                }
            }

            this.Sprites = sprites;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position, int sprite) {
            var sourceRectangle = Sprites[sprite];
            var destinationRectangle = new Rectangle((int)position.X, (int)position.Y, SpriteWidth, SpriteHeight);
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
