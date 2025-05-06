using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectTransition : MonoBehaviour
{
    private Renderer rockRenderer;
    private Color originalColor;

    [Header("Scene Transition Settings")]
    public float sceneLoadDelay = 5f;
    public string sceneName = "FinishLevel";

    private void Awake()
    {
        rockRenderer = GetComponent<Renderer>();

        if (rockRenderer != null)
        {
            originalColor = rockRenderer.material.color;
        }
    }

    public void OnRockGrabbed()
    {
        Debug.Log("Rock grabbed! " + gameObject.name);

        if (rockRenderer != null)
        {
            rockRenderer.material.color = Color.green;
        }

        // Start delayed scene transition
        Invoke(nameof(LoadScene), sceneLoadDelay);
    }

    public void OnRockDropped()
    {
        Debug.Log("Rock dropped! " + gameObject.name);

        if (rockRenderer != null)
        {
            rockRenderer.material.color = originalColor;
        }
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