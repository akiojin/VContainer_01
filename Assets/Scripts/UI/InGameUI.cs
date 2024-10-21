using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using VContainer;

public class InGameUI : MonoBehaviour, IDisposable
{
    [Inject]
    ILogger Logger;

    [SerializeField]
    Button ToMainMenu;

    void Start()
    {
        Logger.Log(nameof(InGameUI));

        ToMainMenu.onClick.AddListener(() => {
            SceneManager.LoadScene("MainMenu");
        });
    }

    void IDisposable.Dispose()
        => Logger.Log($"{nameof(InGameUI)} Dispose");
}
