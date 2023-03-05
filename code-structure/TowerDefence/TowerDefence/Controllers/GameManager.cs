using System;
using System.Collections.Generic;
using System.Text;
using TowerDefence.Models;

namespace TowerDefence.Controllers
{
    internal class GameManager
    {
        public bool IsPaused { get; private set; } = true;

        public Level CurrentLevel { get; private set; }

        public EnemyManager EnemyManager { get; private set; } = new EnemyManager();

        public TowerManager TowerManager { get; private set; } = new TowerManager();

        public void LoadLevel(string name)
        {
            CurrentLevel = new LevelBuilder().Build();

            EnemyManager.SpawnEnemies(0f);

            // add to unity
        }


        private static readonly GameManager _instance = new GameManager();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static GameManager()
        {
        }

        private GameManager()
        {
        }

        public static GameManager Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
