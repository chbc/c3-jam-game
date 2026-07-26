using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryPanel : MonoBehaviour
{
    [SerializeField] private GameObject _star2;
    [SerializeField] private GameObject _star3;

    private void Start()
    {
        float pastTime = CountdownTimer.Instance.PastTime;

        if (pastTime < 20)
        {
            _star2.SetActive(true);
        }

        if (pastTime < 15)
        {
            _star3.SetActive(true);
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            OnRestartButtonPressed();
        }
        else if (Input.GetButtonDown("Jump"))
        {
            OnQuitButtonPressed();
        }
    }

    public void OnRestartButtonPressed()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OnQuitButtonPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
