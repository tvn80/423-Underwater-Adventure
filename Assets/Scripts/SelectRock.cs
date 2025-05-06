using UnityEngine;

public class SelectRock : MonoBehaviour
{
 
    private Renderer rockRenderer;
    private Color originalColor;

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
        Debug.Log("Rock grabbed!" + gameObject.name);

        if (rockRenderer != null)
        {
            rockRenderer.material.color = Color.green;
        }
    }

    public void OnRockDropped()
    {
        Debug.Log("Rock dropped!" + gameObject.name);

        if (rockRenderer != null)
        {
            rockRenderer.material.color = originalColor;
        }
    }
} 
        
    
