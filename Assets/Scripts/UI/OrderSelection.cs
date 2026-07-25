using UnityEngine;
using UnityEngine.SceneManagement;

public class OrderSelection : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButtonDown("Fire"))
        {
            OnPlayButtonPressed();
        }
    }
    
    public void OnPlayButtonPressed()
    {
        SceneManager.LoadScene("Level1");
    }
}
