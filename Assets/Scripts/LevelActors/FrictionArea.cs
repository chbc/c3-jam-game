using UnityEngine;

public class FrictionArea : MonoBehaviour
{
    [SerializeField] private float _frictionSpeed = 10.0f;

    private void OnTriggerEnter(Collider other)
    {
        PlayerCharacter character = other.GetComponent<PlayerCharacter>();
        character.SetSpeed(_frictionSpeed);
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerCharacter character = other.GetComponent<PlayerCharacter>();
        character.RestoreSpeed();
    }
}
