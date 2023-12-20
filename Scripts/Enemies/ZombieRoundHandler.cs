using UnityEngine;
using MonsterLove.StateMachine;
using System.Collections;

/// <summary>
/// Class that manages all zombie rounds, starts them, ends them.
/// </summary>
public sealed class ZombieRoundHandler : MonoBehaviour
{
    public enum States
    {
        RoundStart,
        RoundEnd
    }

    [Header("Zombie Round Settings")]
    [SerializeField]
    private int currentRound;
    [SerializeField]
    private int roundPauseTimer;
    [SerializeField]
    private int defaultRoundPauseTimer;
    [SerializeField]
    private int maxZombiesCurrentRound;
    [SerializeField]
    private int maxZombiesLastRound;
    [Header("Script References")]
    [SerializeField]
    private ZombieSpawnHandler zombieSpawnHandler;
    [SerializeField]
    private PlayerMoney playerMoney;
    [SerializeField]
    private PlayerHealth playerHealth;
    [SerializeField]
    private PlayerHUDHandler playerHUDHandler;
    private StateMachine<States> stateMachine;
    [SerializeField]
    private DifferentTypeEnemyInitiatorHandler differentTypeEnemyInitiatorHandler;

    public int CurrentRound
    {
        get
        {
            return currentRound;
        }
    }

    public int MaxZombiesLastRound
    {
        get
        {
            return maxZombiesLastRound ;
        }
    }

    public int MaxZombiesCurrentRound
    {
        get
        {
            return maxZombiesCurrentRound;
        }
    }
    /// <summary>
    /// Round pause timer text for player HUD.
    /// </summary>
    public string RoundPauseTimer
    {
        get
        {
            return roundPauseTimer.ToString() + Constants.UnitText.SpaceSecond;
        }
    }

    public bool IsRoundPause
    {
        get
        {
            return stateMachine.State == States.RoundEnd;
        }
    }

   


    void Awake()
    {
        roundPauseTimer = defaultRoundPauseTimer;
        stateMachine = StateMachine<States>.Initialize(this);
        stateMachine.ChangeState(States.RoundStart);
    }

    // Round start state.

    void RoundStart_Enter()
    {
        InitializeNewRound();        
    }

    private void InitializeNewRound()
    {
        currentRound++;

        var totalZombiesKilled = ZombieRoundStatisticsHandler.zombiesKilled;
        var rnd = RandomNumberGenerator.Generate(1, 10);
        var rnd2 = RandomNumberGenerator.Generate(1, 5);
        var maxZombiesLastRoundLocal = MaxZombiesLastRound;
        double health = playerHealth.CurrentHealth * 0.03;

        if (currentRound == 1)
        {
            totalZombiesKilled = RandomNumberGenerator.Generate(1, 10);
            maxZombiesLastRoundLocal = RandomNumberGenerator.Generate(1, 2);
            health = 1;
        }

        var model = new ZombieRoundNumberModel(currentRound, totalZombiesKilled, health, rnd, rnd2, maxZombiesLastRoundLocal);

        maxZombiesCurrentRound = RandomNumberGenerator.GenerateZombieNumberForSpecificRound(model);
        maxZombiesLastRound = maxZombiesCurrentRound;

        differentTypeEnemyInitiatorHandler.SetRoundEnemyComposition(maxZombiesCurrentRound);
        zombieSpawnHandler.StartSpawningZombies();
    }

    void RoundStart_Update()
    {
        if (zombieSpawnHandler.ActiveZombies == 0 && !zombieSpawnHandler.IsSpawningEnemies)
        {
            stateMachine.ChangeState(States.RoundEnd);
        }
    }

    // Round end state.

    private IEnumerator RoundEnd_Enter()
    {
        playerMoney.TryAddMoneyForZombiesKilled(MaxZombiesCurrentRound);
        ZombieRoundStatisticsHandler.SaveStatistics(ZombieRoundStatisticsType.ZombiesKilled, MaxZombiesCurrentRound);

        playerHUDHandler.SetRoundPauseWindowActive(true);

        while (roundPauseTimer >= 0)
        {
            yield return new WaitForSeconds(Constants.Unit.Second);
            roundPauseTimer--;
        }
        stateMachine.ChangeState(States.RoundStart);
    }

    void RoundEnd_Exit()
    {
        roundPauseTimer = defaultRoundPauseTimer;
        playerHUDHandler.SetRoundPauseWindowActive(false);
    }
}