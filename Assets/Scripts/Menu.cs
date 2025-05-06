using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayButton ()
    {
        SceneManager.LoadScene("Underwater Adventure Scene");

    }

    public void OnQuitButton ()
    {
        Application.Quit();
    }
}
