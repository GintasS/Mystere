using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class that handles menu buttons(such as play, exit) for the Main Menu scene.
/// </summary>
public sealed class MainMenuUI : MonoBehaviour
{
    [Header("Options Window Settings")]
    [SerializeField]
    private OptionsWindowUI optionsWindowUI;
    [Header("Script References")]
    [SerializeField]
    private RandomBackgroundImageHandler randomBackgroundImageHandler;
    [SerializeField]
    private OptionsHandler optionsHandler;
    [SerializeField]
    private MainMenuSceneOptionsHandler mainMenuSceneOptionsHandler;

    void Awake()
    {
        optionsHandler.TryFillSavedOptions();
        mainMenuSceneOptionsHandler.TryActivateOptions();
        randomBackgroundImageHandler.SetRandomBackgroundImage();
    }

    /// <summary>
    /// Activate Game scene load logic on the play button click.
    /// </summary>
    public void PlayButtonClick()
    {
        if (!optionsWindowUI.IsWindowOpen)
        {
            SceneManager.LoadSceneAsync(Constants.Scene.NewDetectiveCase);
        }
    }

    public void StartTheGameButtonClick()
    {
        SceneManager.LoadSceneAsync(Constants.Scene.Loading);
    }

    /// <summary>
    /// Activate options window logic on a options button click.
    /// </summary>
    public void OptionsButtonClick()
    {
        if (optionsWindowUI.IsWindowOpen)
        {
            optionsHandler.SaveOptions();
        }
        optionsWindowUI.SetWindowActive();
    }

    /// <summary>
    /// Activate exit game logic on a exit button click.
    /// </summary>
    public void ExitButtonClick()
    {
        if (!optionsWindowUI.IsWindowOpen)
        {
            Application.Quit();
        }
    }
}