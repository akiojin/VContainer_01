using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using VContainer;

public class MainMenuUI : MonoBehaviour, IDisposable
{
    [Inject]
    ILogger Logger;

    [SerializeField]
    Button ToInGame;

    void Start()
    {
        Logger.Log(nameof(MainMenuUI));

        ToInGame.onClick.AddListener(() => {
            SceneManager.LoadScene("InGame");
        });
    }

    void IDisposable.Dispose()
        => Logger.Log($"{nameof(MainMenuUI)} Dispose");
}
