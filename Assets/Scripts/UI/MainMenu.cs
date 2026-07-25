using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject orderSelection;

    public void OnLoginButtonPressed()
    {
        this.orderSelection.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
