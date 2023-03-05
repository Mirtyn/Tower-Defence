using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefence.Models
{
    internal class Tower
    {
        //public GameObject GameObject { get; set; }

        //public EnemyBehaviour Behaviour { get; set; }

        private static int MaxLevel = 4;
        private static float MinRadius = 10f;

        public TowerType TowerType { get; set; } = TowerType.Default;

        public DamageType DamageType { get; set; } = DamageType.Default;

        public MaterialType MaterialType { get; set; } = MaterialType.Wood;

        public int Level { get; set; } = 1;

        public Tile Tile { get; set; }

        public float Radius { get; set; } = MinRadius;

        public int NumberOfProjectiles { get; set; } = 3;

        public static int LifeForTileType(TowerType towerType)
        {
            switch(towerType)
            {
                case TowerType.Aura:
                    return 120;
                case TowerType.Barrier:
                    return 1000;
                default:
                    return 100;
            }
        }


        public float CalculateAttackSpeed()
        {
            switch (TowerType)
            {
                case TowerType.Aura:
                    return 0.5f;
                case TowerType.Barrier:
                    return 0f;
                default:
                    return 0.25f;
            }
        }

        public void UpgradeLevel()
        {
            Level++;

            if(Level > MaxLevel)
            {
                Level = MaxLevel;
            }

            Radius = MinRadius * Level;
        }
    }
}
