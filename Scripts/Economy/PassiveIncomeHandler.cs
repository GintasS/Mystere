using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassiveIncomeHandler : MonoBehaviour
{
    [SerializeField]
    private ZombieRoundHandler _zombieRoundHandler;
    [SerializeField]
    private PlayerMoney _playerMoney;
    [SerializeField]
    private int timeSpentInSeconds;
    [SerializeField]
    private float passiveIncomeTimer;
    [SerializeField]
    private float passiveIncomeTimerDefault;


    void Start()
    {
        passiveIncomeTimer = passiveIncomeTimerDefault;
        StartCoroutine(TimerMethod());
    }

    // Update is called once per frame
    void Update()
    {
        if (passiveIncomeTimer == 0)
        {
            var generatedMoney = GeneratePassiveMoney(1000, 1.5, 2, 1, 1, _zombieRoundHandler.CurrentRound, timeSpentInSeconds);
            Debug.Log("Adding money: " + generatedMoney);
            _playerMoney.TryAddMoney(generatedMoney);
            passiveIncomeTimer = passiveIncomeTimerDefault;
        }
    }

    static int GeneratePassiveMoney(double baseMoney, double roundNumberMultiplier, double timeMultiplier, double bonusTimeMultiplier, double timeFactor, int roundNumber, double timeInGame)
    {
        // Calculate the money based on the provided equation
        double money = (baseMoney + (roundNumberMultiplier * roundNumber) / (timeMultiplier * timeInGame + 1)) * (1 + bonusTimeMultiplier * Math.Sin(timeFactor * timeInGame));
        // Debug.Log("Before rounding:" + money);
        money = Math.Round(money, MidpointRounding.AwayFromZero);
        Debug.Log("After rounding:" + money);
        return (int)money;
    }

    private IEnumerator TimerMethod()
    {
        while (passiveIncomeTimer >= 0)
        {
            yield return new WaitForSeconds(Constants.Unit.Second);
            SaveGameStartDate();
            passiveIncomeTimer--;
        }
    }

    public void SaveGameStartDate()
    {
        Debug.Log("Adding seconds");
        timeSpentInSeconds++;
    }
}
