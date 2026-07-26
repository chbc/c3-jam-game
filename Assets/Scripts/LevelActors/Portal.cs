using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField]
    private Portal _targetPortal;

    [SerializeField]
    private GameObject _top;

    [SerializeField]
    private Transform _coloredTop;

    private void Start()
    {
        if (_targetPortal == null)
        {
            Debug.LogError("Missing target portal!");
        }

        _top.transform.position = _coloredTop.position + new Vector3(0.0f, 5.0f, 0.0f);
    }

    public void DestroyTop()
    {
        Destroy(_top);
    }

    private void OnTriggerEnter(Collider other)
    {
        DestroyTop();
        _targetPortal.DestroyTop();

        CharacterController characterController = other.gameObject.GetComponent<CharacterController>();

        characterController.enabled = false;

        Transform targetTransform = _targetPortal.transform;
        Vector3 resultPosition = targetTransform.position + (targetTransform.forward * 2.0f);
        resultPosition.y = characterController.transform.position.y;
        other.transform.position = resultPosition;
        other.transform.rotation = targetTransform.rotation;

        characterController.enabled = true;
    }
}
