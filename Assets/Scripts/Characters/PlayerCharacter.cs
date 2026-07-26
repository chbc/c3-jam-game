using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerCharacter : MonoBehaviour
{
    [SerializeField]
    private float _maxSpeed = 20.0f;

    [SerializeField]
    private float _maxRotationSpeed = 90.0f;

    private float _speed;
    private float _rotationSpeed;

    private CharacterController _characterController;
    private Transform _characterTransform;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _characterTransform = this.transform;

        MessagesManager.Instance.OnGameplayStart += OnGameplayStart;
        MessagesManager.Instance.OnPlayerReachCheckpoint += OnPlayerReachCheckpoint;
        MessagesManager.Instance.OnTimeUp += OnTimeUp;
    }

    private void Update()
    {
        float input = Input.GetAxis("Horizontal");
        if (input != 0.0f)
        {
            float yaw = input * _rotationSpeed * Time.deltaTime;
            _characterTransform.Rotate(0.0f, yaw, 0.0f);
        }

        Vector3 resultVelocity = _characterTransform.forward * _speed * Time.deltaTime;
        _characterController.Move(resultVelocity);
    }

    private void OnGameplayStart()
    {
        _speed = _maxSpeed;
        _rotationSpeed = _maxRotationSpeed;
    }

    private void OnPlayerReachCheckpoint()
    {
        _speed = 0.0f;
        _rotationSpeed = 0.0f;
    }

    private void OnTimeUp()
    {
        _speed = 0.0f;
        _rotationSpeed = 0.0f;
    }
}
