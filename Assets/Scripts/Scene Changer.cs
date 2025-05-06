using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    
    // Go to next scene in build
    public void GoToNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Return to title scene
    public void GoToTitleScene()
    {
        SceneManager.LoadScene(0);
    }

}
