using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMenu : MonoBehaviour
{
    public float sceneLoadDelay = 5f; // Delay in seconds
    public string sceneName = "FinishLevel";

    public void OnObjectSelect()
    {
        Invoke(nameof(LoadScene), sceneLoadDelay);
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }
}
