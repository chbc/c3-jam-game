using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject orderSelection;

    private void Start()
    {
        if (this.orderSelection == null)
        {
            Debug.LogError("Missing order selection window!");
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            OnLoginButtonPressed();
        }
    }

    public void OnLoginButtonPressed()
    {
        this.orderSelection.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void OnCreditsButtonPressed()
    {
        SceneManager.LoadScene("Credits");
    }

    public void OnQuitButtonPressed()
    {
        Application.Quit();
    }
}
