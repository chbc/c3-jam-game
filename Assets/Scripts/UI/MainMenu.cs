using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Start");
    }

    public void OnPlayButtonPressed()
    {
        SceneManager.LoadScene("Level1");
    }
}
