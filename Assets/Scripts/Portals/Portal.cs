using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField]
    Transform targetPortal;

    private void Start()
    {
        if (targetPortal == null)
        {
            Debug.LogError("Missing target portal!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        CharacterController characterController = other.gameObject.GetComponent<CharacterController>();

        characterController.enabled = false;

        other.transform.position = targetPortal.position + (targetPortal.forward * 2.0f); ;
        other.transform.rotation = targetPortal.rotation;

        characterController.enabled = true;
    }
}
