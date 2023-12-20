using System.Collections.Generic;
using System.Collections;
using System.Linq;
using UnityEngine;
using Assets.Scripts.Enemies;

/// <summary>
/// Class that is responsible for spawning all the zombies to the map.
/// </summary>
public sealed class ZombieSpawnHandler : MonoBehaviour
{
    [Header("Main Enemy Settings")]
    [SerializeField]
    private GameObject enemyInstancesParent;
    [SerializeField]
    private List<GameObject> enemies;
    [SerializeField]
    private bool isSpawningEnemies;
    [Header("Zombie Spawn Timer Settings")]
    [SerializeField]
    private float zombieInstantiatorTimer;
    [Header("Script References")]
    [SerializeField]
    private ZombieRoundHandler zombieRoundHandler;
    [SerializeField]
    private DifferentTypeEnemyInitiatorHandler differentTypeEnemyInitiatorHandler;

    /// <summary>
    /// Get active zombies count on the map.
    /// </summary>
    public int ActiveZombies
    {
        get
        {
            return enemies.Count(x => x != null);
        }
    }

    /// <summary>
    /// Whether the zombie spawn handler is currently spawning zombies.
    /// </summary>
    public bool IsSpawningEnemies
    {
        get
        {
            return isSpawningEnemies;
        }
    }

    /// <summary>
    /// Start the zombie spawn coroutine.
    /// </summary>
    public void StartSpawningZombies()
    {
        StartCoroutine(WaitAndSpawnZombies());
    }

    /// <summary>
    /// Waits and spawn zombies until a max zombie count is met.
    /// </summary>
    private IEnumerator WaitAndSpawnZombies()
    {
        enemies = new List<GameObject>();
        isSpawningEnemies = true;

        while (enemies.Count < zombieRoundHandler.MaxZombiesCurrentRound)
        {
            if (zombieInstantiatorTimer > 0)
            {
                zombieInstantiatorTimer -= Time.deltaTime;
            }
            else
            {
                var newEnemyForRound = differentTypeEnemyInitiatorHandler.GetNextEnemyFromCompositon();
                InstantiateNewEnemy(newEnemyForRound);
                zombieInstantiatorTimer = newEnemyForRound.DefaultEnemyInstantiatorTimer;
            }

            yield return null;
        }

        isSpawningEnemies = false;
    }

    /// <summary>
    /// Create an instance of a single zombie at a specific location.
    /// </summary>
    private void InstantiateNewEnemy(EnemyType enemyType)
    {   
        var spawnPositionIndex = RandomNumberGenerator.Generate(0, enemyType.SpawnPoints.Length);
        var newEnemy = Instantiate(enemyType.Enemy, enemyType.SpawnPoints[spawnPositionIndex].transform.position, Quaternion.identity, enemyInstancesParent.transform);
        newEnemy.name = enemyType.Name + (enemies.Count + 1);

        enemies.Add(newEnemy);
    }
}