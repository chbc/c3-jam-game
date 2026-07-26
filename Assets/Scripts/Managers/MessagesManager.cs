using System.Collections;
using UnityEngine;

public class MessagesManager : MonoBehaviour
{
    public static MessagesManager Instance => _instance;
    public delegate void voidFunction();

    public voidFunction OnGameplayStart;
    public voidFunction OnPlayerReachCheckpoint;
    
    private static MessagesManager _instance = null;

    private void Awake()
    {
        /*
        if (_instance != null)
        {
            Destroy(_instance);
        }

        DontDestroyOnLoad(this);
        */

        _instance = this;
    }

    private void Start()
    {
        StartCoroutine(DelayedGameplayStart());
    }

    private IEnumerator DelayedGameplayStart()
    {
        yield return new WaitForSeconds(1.0f);

        OnGameplayStart();

        yield return null;
    }


    public void NotifyPlayerReachCheckpoint()
    {
        OnPlayerReachCheckpoint();
    }
}
