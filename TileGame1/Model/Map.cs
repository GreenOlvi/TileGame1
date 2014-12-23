using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TileGame1
{
    class Map
    {
        public int[] Tiles { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Map()
        {
            this.Width = 5;
            this.Height = 5;
            this.Tiles = new int[] {
                0,  0,  0,  0,  0,
                3,  4,  4,  4,  5,
                6,  7,  7,  7,  8,
                9, 10, 10, 10, 11,
                0,  0,  0,  0,  0,
            };
        }

        public int GetTile(int x, int y)
        {
            var i = x + y * Width;
            return Tiles[i];
        }
    }
}
