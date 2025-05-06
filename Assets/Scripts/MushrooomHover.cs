using UnityEngine;

public class MushrooomHover : MonoBehaviour
{
    public GameObject popupText;

    public void OnHoverEnter()
    {
        if (popupText != null)
        {
            popupText.SetActive(true);
        }
    }

    public void OnHoverExit()
    {
        if (popupText != null)
        {
            popupText.SetActive(false);
        }
    }
}
