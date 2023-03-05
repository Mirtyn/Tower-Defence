using System;
using System.Collections.Generic;
using System.Text;
using TowerDefence.Models;

namespace TowerDefence.Controllers
{
    internal class EnemyManager
    {
        public List<Enemy> Enemies { get; set; } = new List<Enemy>();

        public void SpawnEnemies(float time)
        {
            var enemy = new Enemy
            {
            };

            Enemies.Add(enemy);

            // add to unity
        }

        public void MoveEnemies(float deltatime)
        {

        }

        public void AttackTower(Enemy enemy, Tower tower)
        {

        }

        public void DieEnemy(Enemy enemy)
        {
            Enemies.Remove(enemy);

            // remove from unity
        }
    }
}
