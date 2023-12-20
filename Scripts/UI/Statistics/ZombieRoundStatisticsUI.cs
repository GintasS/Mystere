using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class that handles statistics for a particular zombie round.
/// </summary>
public sealed class ZombieRoundStatisticsUI : MonoBehaviour
{
    [Header("Round Statistics Settings")]
    [SerializeField]
    private Text roundsSurvivedText;
    [SerializeField]
    private Text zombiesKilledText;

    void Awake()
    {
        DisplayStatistics();
    }

    /// <summary>
    /// Display all zombie round statistics.
    /// </summary>
    private void DisplayStatistics()
    {
        DisplayZombieRoundsSurvived();
    }

    /// <summary>
    /// Display the number of zombie rounds the player has survived.
    /// </summary>
    private void DisplayZombieRoundsSurvived()
    {
        var zombieRoundsSurvived = ZombieRoundStatisticsHandler.GetStatistics(ZombieRoundStatisticsType.ZombieRoundsSurvived);
        var zombiesKilled = ZombieRoundStatisticsHandler.GetStatistics(ZombieRoundStatisticsType.ZombiesKilled);

        roundsSurvivedText.text = string.Format(Constants.RoundStatistics.YouSurvivedRoundsText, (int)(object)zombieRoundsSurvived);
        zombiesKilledText.text = string.Format(Constants.RoundStatistics.ZombiesKilled, (int)(object)zombiesKilled);
    }
}