using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefence.Models
{
    internal class Enemy
    {
        //public GameObject GameObject { get; set; }

        //public EnemyBehaviour Behaviour { get; set; }

        public EnemyType EnemyType { get; set; }
        public AttackType AttackType { get; set; }

        public int CalculateDamage()
        {
            switch (EnemyType)
            {
                case EnemyType.Normal:
                    return CalculateDamageEnemyTypeNormal();
                case EnemyType.Fast:
                    return CalculateDamageEnemyTypeFast();
                case EnemyType.Tough:
                    return CalculateDamageEnemyTypeTough();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public int CalculateGold()
        {
            switch (EnemyType)
            {
                case EnemyType.Normal:
                    return 1;
                case EnemyType.Fast:
                    return 1;
                case EnemyType.Tough:
                    return 1;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private int CalculateDamageEnemyTypeNormal()
        {
            switch (AttackType)
            {
                case AttackType.HitFast:
                    return 200;
                case AttackType.HitHeavy:
                    return 400;
                case AttackType.RangedFast:
                    return 50;
                default:
                    return 200;
            }
        }

        private int CalculateDamageEnemyTypeFast()
        {
            switch (AttackType)
            {
                case AttackType.HitFast:
                    return 200;
                case AttackType.HitHeavy:
                    return 400;
                case AttackType.RangedFast:
                    return 50;
                default:
                    return 200;
            }
        }

        private int CalculateDamageEnemyTypeTough()
        {
            switch (AttackType)
            {
                case AttackType.HitFast:
                    return 200;
                case AttackType.HitHeavy:
                    return 400;
                case AttackType.RangedFast:
                    return 50;
                default:
                    return 200;
            }
        }

        public float CalculateAttackSpeed()
        {
            switch (EnemyType)
            {
                case EnemyType.Normal:
                    return CalculateAttackSpeedForEnemyTypeNormal();
                case EnemyType.Fast:
                    return CalculateAttackSpeedForEnemyTypeFast();
                case EnemyType.Tough:
                    return CalculateAttackSpeedForEnemyTypeTough();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private float CalculateAttackSpeedForEnemyTypeNormal()
        {
            switch (AttackType)
            {
                case AttackType.HitFast:
                    return 200f;
                case AttackType.HitHeavy:
                    return 400f;
                case AttackType.RangedFast:
                    return 50f;
                default:
                    return 200f;
            }
        }

        private float CalculateAttackSpeedForEnemyTypeFast()
        {
            switch (AttackType)
            {
                case AttackType.HitFast:
                    return 200f;
                case AttackType.HitHeavy:
                    return 400f;
                case AttackType.RangedFast:
                    return 50f;
                default:
                    return 200f;
            }
        }

        private float CalculateAttackSpeedForEnemyTypeTough()
        {
            switch (AttackType)
            {
                case AttackType.HitFast:
                    return 200f;
                case AttackType.HitHeavy:
                    return 400f;
                case AttackType.RangedFast:
                    return 50f;
                default:
                    return 200f;
            }
        }

        public static float SpeedForEnemyType(EnemyType enemyType)
        {
            switch (enemyType)
            {
                case EnemyType.Normal:
                    return 1f;
                case EnemyType.Fast:
                    return 1.5f;
                case EnemyType.Tough:
                    return 0.75f;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static int LifeForEnemyType(EnemyType enemyType)
        {
            switch (enemyType)
            {
                case EnemyType.Normal:
                    return 100;
                case EnemyType.Fast:
                    return 50;
                case EnemyType.Tough:
                    return 400;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
