using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieRoundNumberModel
{
    /// <summary>
    /// X
    /// </summary>
    public int RoundNumber { get; set; }  
    /// <summary>
    /// Y
    /// </summary>
    public int NumberOfZombiesKilled { get; set; } 
    /// <summary>
    /// Z
    /// </summary>
    public double PlayerHealthNumber { get; set; }
    /// <summary>
    /// D
    /// </summary>
    public int RandomNumberOne { get; set; }
    /// <summary>
    /// E
    /// </summary>
    public int RandomNumberTwo { get; set; }
    /// <summary>
    /// F
    /// </summary>
    public int LastRoundZombieCount { get; set; }


    public ZombieRoundNumberModel(int roundNumber, int numberOfZombiesKilled, double playerHealth, int randomNumberOne, int randomNumberTwo, int lastRoundZombieCount)
    {
        RoundNumber = roundNumber;
        NumberOfZombiesKilled = numberOfZombiesKilled;
        PlayerHealthNumber = playerHealth;
        RandomNumberOne = randomNumberOne;
        RandomNumberTwo = randomNumberTwo;
        LastRoundZombieCount = lastRoundZombieCount;
    }
}
