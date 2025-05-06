using UnityEngine;

public class closePanel : MonoBehaviour
{
   public GameObject Panel;

    public void ClosePanel()
    {
        if (Panel != null) {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(false);
        }
    }   
}
