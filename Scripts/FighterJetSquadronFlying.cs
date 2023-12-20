using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class FighterJetSquadronFlying : MonoBehaviour
    {
        [Header("Target")]
        [SerializeField]
        private Transform Target;
        [SerializeField]
        private float Speed;
        [Header("Time Window To Move Jets")]
        [SerializeField]
        private float TimeToFlyInSeconds = 0;
        [SerializeField]
        private float DefaultTimeToFlyInSeconds = 10;
        [Header("Spawn Settings")]
        [SerializeField]
        private GameObject[] PlacesToSpawn;
        [SerializeField]
        private int placesToSpawnIndex;
        [SerializeField]
        private float SpawnEverySeconds;
        [SerializeField]
        private float SpawnEverySecondsDefault;


        private bool StoppedFlying = false;
        private bool TimeToSpawn = false;

        void Start()
        {
            TimeToFlyInSeconds = DefaultTimeToFlyInSeconds;
        }

        void Update()
        {
            if (TimeToFlyInSeconds >= 0)
            {
                transform.position = Vector3.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
                TimeToFlyInSeconds -= Time.deltaTime;
            }
            else if (TimeToFlyInSeconds < 0 && StoppedFlying is false) 
            {
                StoppedFlying = true;
            }

            if (StoppedFlying is true && SpawnEverySeconds >= 0)
            {
                SpawnEverySeconds -= Time.deltaTime;
            }
            else if (TimeToSpawn is false && SpawnEverySeconds < 0 )
            {
                TimeToSpawn = true;
                Relocate();
            }
        }

        private void Relocate()
        {
            TryUpdatePlacesToSpawnIndex();
            transform.position = PlacesToSpawn[placesToSpawnIndex].transform.position;
            TimeToFlyInSeconds = DefaultTimeToFlyInSeconds;
            StoppedFlying = false;
            TimeToSpawn = false;
            SpawnEverySeconds = SpawnEverySecondsDefault;
        }

        private void TryUpdatePlacesToSpawnIndex()
        {
            if (placesToSpawnIndex + 1 >= PlacesToSpawn.Length)
            {
                placesToSpawnIndex = 0;
            }
            else
            {
                placesToSpawnIndex++;
            }
        }
    }
}
