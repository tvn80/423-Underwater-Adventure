using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    public void OnButtonSelect ()
    {
        SceneManager.LoadScene("FinishLevel");

    }

    public void OnQuitButton ()
    {
        Application.Quit();
    }
}
