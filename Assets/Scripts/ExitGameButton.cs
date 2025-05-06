using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGameButton : MonoBehaviour
{
    public void ExitScene() {
        SceneManager.LoadScene("MainMenu");
    
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
    }
}


