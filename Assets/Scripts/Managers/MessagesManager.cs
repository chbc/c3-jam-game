using UnityEngine;

public class MessagesManager : MonoBehaviour
{
    public static MessagesManager Instance => _instance;
    public delegate void voidFunction();

    public voidFunction OnPlayerReachCheckpoint;
    
    private static MessagesManager _instance = null;

    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(_instance);
        }

        DontDestroyOnLoad(this);

        _instance = this;
    }

    public void NotifyPlayerReachCheckpoint()
    {
        OnPlayerReachCheckpoint();
    }
}
