using UnityEngine;
using UnityEngine.SceneManagement;

public class OrderSelection : MonoBehaviour
{
    public void OnPlayButtonPressed()
    {
        SceneManager.LoadScene("Level1");
    }
}
