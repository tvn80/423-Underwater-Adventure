using UnityEngine;

public class PanelHover : MonoBehaviour
{
    public GameObject textPanel; 

    private void Awake()
    {
        if (textPanel != null)
            textPanel.SetActive(false);
    }
    
    public void OnHoverEnter()
    {
        if (textPanel != null)
        {
            textPanel.SetActive(true);
        }
    }

    public void OnHoverExit()
    {
        if (textPanel != null)
        {
            textPanel.SetActive(false);
        }
    }
}