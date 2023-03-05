using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefence.Models
{
    internal class Level
    {
        public string Name { get; set; }

        public List<Tile> Tiles { get; set; } = new List<Tile>();
    }
}
