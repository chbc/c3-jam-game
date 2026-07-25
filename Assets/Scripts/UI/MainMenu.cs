using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject orderSelection;

    private void Start()
    {
        if (this.orderSelection == null)
        {
            Debug.LogError("Missing order selection window!");
        }
    }

    public void OnLoginButtonPressed()
    {
        this.orderSelection.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
