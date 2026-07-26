using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        MessagesManager.Instance.NotifyPlayerReachCheckpoint();
        Destroy(gameObject);
    }
}
