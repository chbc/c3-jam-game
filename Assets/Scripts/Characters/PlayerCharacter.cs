using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CharacterController))]
public class PlayerCharacter : MonoBehaviour
{
    private CharacterController characterController;
    private Transform characterTransform;

    [SerializeField]
    private float speed = 20.0f;

    [SerializeField]
    private float rotationSpeed = 90.0f;

    private void Start()
    {
        this.characterController = GetComponent<CharacterController>();
        this.characterTransform = this.transform;
    }

    private void Update()
    {
        float input = Input.GetAxis("Horizontal");
        if (input != 0.0f)
        {
            float yaw = input * this.rotationSpeed * Time.deltaTime;
            this.characterTransform.Rotate(0.0f, yaw, 0.0f);
        }

        Vector3 resultVelocity = this.characterTransform.forward * this.speed * Time.deltaTime;
        this.characterController.Move(resultVelocity);
    }
}
