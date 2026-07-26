using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialHUD : MonoBehaviour
{
    [SerializeField] string _nextLevel;
    [SerializeField] string _conclusionText;
    [SerializeField] TextMeshProUGUI _goalMessage;

    private void Start()
    {
        MessagesManager.Instance.OnPlayerReachCheckpoint += OnPlayerReachCheckpoint;
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
        _goalMessage.text = _conclusionText;
        StartCoroutine(DelayedLoadNextLevel());
    }

    private IEnumerator DelayedLoadNextLevel()
    {
        yield return new WaitForSeconds(3.0f);

        SceneManager.LoadScene(_nextLevel);
    }
}
