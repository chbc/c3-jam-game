using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayHUD : MonoBehaviour
{
    [SerializeField] GameObject _victoryPanel;
    [SerializeField] GameObject _losePanel;

    private void Start()
    {
        if (!_victoryPanel || !_losePanel)
        {
            Debug.LogError("Missing result panel references");
        }

        MessagesManager.Instance.OnPlayerReachCheckpoint += OnPlayerReachCheckpoint;
        MessagesManager.Instance.OnTimeUp += OnTimeUp;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    private void OnPlayerReachCheckpoint()
    {
        _victoryPanel.SetActive(true);
    }

    private void OnTimeUp()
    {
        _losePanel.SetActive(true);
    }
}
