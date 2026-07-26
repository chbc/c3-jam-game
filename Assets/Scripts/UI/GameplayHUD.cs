using UnityEngine;

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
    }

    private void OnPlayerReachCheckpoint()
    {
        _victoryPanel.SetActive(true);
    }
}
