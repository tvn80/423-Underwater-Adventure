using UnityEngine;
using UnityEngine.Video;

public class ActivateCanvas : MonoBehaviour
{
    public GameObject canvasToActivate;
    public VideoPlayer videoPlayer;
    public float videoStartDelay = 0.1f; // Delay in seconds

    public void Activate()
    {
        if (canvasToActivate != null)
        {
            canvasToActivate.SetActive(true);
            Invoke(nameof(PlayVideo), videoStartDelay);
        }
    }

    private void PlayVideo()
    {
        if (videoPlayer != null)
            videoPlayer.Play();
    }
}