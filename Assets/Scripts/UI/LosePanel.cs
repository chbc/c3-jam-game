using UnityEngine;
using UnityEngine.SceneManagement;

public class LosePanel : MonoBehaviour
{
    public void OnRestartButtonPressed()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OnQuitButtonPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
