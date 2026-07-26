using TMPro;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _timerText;
    [SerializeField] float _maxTime = 0.5f * 60.0f;

    private float _currentTime;
    private bool _isRunning = false;

    private void Start()
    {
        _currentTime = _maxTime;
        UpdateTimerText();

        MessagesManager.Instance.OnGameplayStart += OnGameplayStart;
        MessagesManager.Instance.OnPlayerReachCheckpoint += OnPlayerReachCheckpoint;
    }

    private void Update()
    {
        if (_isRunning)
        {
            _currentTime -= Time.deltaTime;
            if (_currentTime < 0 )
            {
                _currentTime = 0;
                _isRunning = false;
            }

            UpdateTimerText();
        }
    }

    private void OnGameplayStart()
    {
        _isRunning = true;
    }

    private void OnPlayerReachCheckpoint()
    {
        _isRunning = false;
    }

    private void UpdateTimerText()
    {
        float decimalMinutes = _currentTime / 60;
        int resultMinutes = Mathf.FloorToInt(decimalMinutes);

        float decimalSeconds = decimalMinutes - resultMinutes;
        int resultSeconds = Mathf.FloorToInt(decimalSeconds * 60.0f);

        string minutesStringFormat = resultMinutes < 10 ? "0{0}" : "{0}";
        string secondsStringFormat = resultSeconds < 10 ? "0{1}" : "{1}";
        string resultStringFormat = string.Format("{0}:{1}", minutesStringFormat, secondsStringFormat);

        _timerText.text = string.Format(resultStringFormat, resultMinutes, resultSeconds);
    }
}
