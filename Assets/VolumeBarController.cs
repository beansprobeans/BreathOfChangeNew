using UnityEngine;

public class VolumeBarController : MonoBehaviour
{
    public GameObject[] bars;
    private int currentVolume = 10; // Starts with all bars on

    public void IncreaseVolume()
    {
        if (currentVolume < bars.Length)
        {
            currentVolume++;
            UpdateBar();
        }
    }

    public void DecreaseVolume()
    {
        if (currentVolume > 0)
        {
            currentVolume--;
            UpdateBar();
        }
    }

    void Start()
    {
        UpdateBar();
    }

    void UpdateBar()
    {
        for (int i = 0; i < bars.Length; i++)
        {
            // Get or add a CanvasGroup component
            CanvasGroup canvasGroup = bars[i].GetComponent<CanvasGroup>();
            if (canvasGroup == null)
            {
                canvasGroup = bars[i].AddComponent<CanvasGroup>();
            }

            // Show or hide the bar by changing alpha
            canvasGroup.alpha = i < currentVolume ? 1f : 0f;
        }
    }
}