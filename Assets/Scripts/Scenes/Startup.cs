using UnityEngine.SceneManagement;
using VContainer.Unity;

public class Startup : IStartable
{
    void IStartable.Start()
        => SceneManager.LoadScene("MainMenu");
}
