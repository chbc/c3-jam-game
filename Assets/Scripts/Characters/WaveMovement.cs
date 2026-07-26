using UnityEngine;

public class WaveMovement : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 0.25f;

    [SerializeField]
    private float _timeSpeed = 5.0f;

    private CharacterController _characterController;

    private float _currentTime;
    private Vector3 _velocity = Vector3.zero;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _currentTime = 0.0f;
    }

    void Update()
    {
        _currentTime += Time.deltaTime * _timeSpeed;
        _velocity.y = Mathf.Sin(_currentTime) * _moveSpeed; ;

        _characterController.Move(_velocity);

        if (_currentTime > 2.0f * Mathf.PI)
        {
            _currentTime -= 2.0f * Mathf.PI;
        }
    }
}
