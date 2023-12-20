using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Enemies
{
    public abstract class EnemyType : MonoBehaviour
    {
        [Header("Enemy Object Settings")]
        [SerializeField]
        private GameObject originalEnemy;
        [SerializeField]
        private GameObject[] spawnPoints;
        [Header("Enemy Rarity Settings")]
        [SerializeField]
        private float defaultEnemyInstantiatorTimer;
        [SerializeField]
        private int enemyRarity;

        public GameObject Enemy => originalEnemy;
        public GameObject[] SpawnPoints => spawnPoints;
        public string Name => originalEnemy.name;
        public float DefaultEnemyInstantiatorTimer => defaultEnemyInstantiatorTimer;
        public int EnemyRarity => enemyRarity;
    }
}
