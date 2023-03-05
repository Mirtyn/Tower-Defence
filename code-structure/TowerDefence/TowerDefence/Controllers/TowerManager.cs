using System;
using System.Collections.Generic;
using System.Text;
using TowerDefence.Models;

namespace TowerDefence.Controllers
{
    internal class TowerManager
    {
        public List<Tower> Towers { get; set; } = new List<Tower>();

        public void SpawnTowers(float time, Tile tile)
        {
            var tower = new Tower
            {
                Tile = tile,
            };

            Towers.Add(tower);

            // add to unity
        }

        public void UpgradeTower(Tower tower)
        {
            tower.UpgradeLevel();
        }

        public void AttackEnemies(List<Enemy> enemies)
        {
            // find nearest enemy
            
            // attack nearest enemy
        }

        public void DieTower(Tower tower)
        {
            Towers.Remove(tower);

            // remove from unity
        }
    }
}
