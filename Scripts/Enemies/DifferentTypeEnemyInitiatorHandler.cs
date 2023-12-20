using Assets.Scripts.Enemies;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DifferentTypeEnemyInitiatorHandler : MonoBehaviour
{
    [Header("Enemy types")]
    [SerializeField]
    private EnemyType[] differentEnemyTypes;
    [Header("Enemy types for the Round")]
    [SerializeField]
    private List<EnemyType> enemyTypesCurrentRound;
    [SerializeField]
    private int enemyTypesCurrentRoundIndex = 0;
    [SerializeField]
    private List<EnemyType> enemyTypesByRarity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRoundEnemyComposition(int enemyCount)
    {
        enemyTypesCurrentRound = new List<EnemyType>();
        enemyTypesCurrentRoundIndex = 0;

        SetEnemyTypesByRarity();

        for (var i = 0; i < enemyCount; i++)
        {
            var rarityNumber = GenerateRarityNumber();
            var enemyType = enemyTypesByRarity[rarityNumber];
            enemyTypesCurrentRound.Add(enemyType);
        }
    }

    public EnemyType GetNextEnemyFromCompositon()
    {
        var enemy = enemyTypesCurrentRound[enemyTypesCurrentRoundIndex];
        enemyTypesCurrentRoundIndex++;
        return enemy;
    }

    private void SetEnemyTypesByRarity()
    {
        enemyTypesByRarity = new List<EnemyType>(100);

        for (var i = 0; i < differentEnemyTypes.Length; i++)
        {
            enemyTypesByRarity.AddRange(Enumerable.Repeat(differentEnemyTypes[i], differentEnemyTypes[i].EnemyRarity));
        }
    }

    private int GenerateRarityNumber()
    {
        return RandomNumberGenerator.Generate(0, 100);
    }
}
