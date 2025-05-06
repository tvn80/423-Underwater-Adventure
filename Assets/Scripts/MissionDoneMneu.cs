using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionDoneMenu : MonoBehaviour
{
    public void MissionComplete ()
    {
        SceneManager.LoadScene("MainMenu");

    }

    public void OnQuitButton ()
    {
        Application.Quit();
    }
}
