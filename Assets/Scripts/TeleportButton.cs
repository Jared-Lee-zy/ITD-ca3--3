using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TeleportButton : MonoBehaviour
{
    public Button closeButton;

    void Start()
    {
        closeButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("StorageScene");
        });
    }
}