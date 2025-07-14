using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject optionsPanel;

    public void OpenOptions()
    {
        mainMenuPanel.SetActive(false);
        optionsPanel.SetActive(true);
    }

    public void BackToMainMenu()
    {
        optionsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
}