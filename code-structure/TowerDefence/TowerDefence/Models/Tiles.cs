using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefence.Models
{
    internal class Tile
    {
        //public GameObject GameObject { get; set; }

        //public EnemyBehaviour Behaviour { get; set; }

        public TileType TileType { get; set; } = TileType.Unknown;

        public string Position { get; set; }

        public bool IsRevealed { get; set; } = false;

        public static float SpeedForTileType(TileType tileType)
        {
            switch(tileType)
            {
                case TileType.Grass:
                    return 0.75f;
                case TileType.Path:
                    return 1f;
                case TileType.Unbuildable:
                    return 0f;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
