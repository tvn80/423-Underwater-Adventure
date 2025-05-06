using UnityEngine;

public class TriggerPanelOnTouch : MonoBehaviour
{
    // Tag to identify interactable objects
    public string interactableTag = "Interactable";

    // The panel to activate (you can set different ones per object with a manager)
    public GameObject textPanel; 
    // public GameObject popupText; 


    private void OnTriggerEnter(Collider other)
    {
        {
        if (textPanel != null)
        {
            textPanel.SetActive(true);
        }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (textPanel != null)
        {
            textPanel.SetActive(false);
        }
    }
}