using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayGameButton : MonoBehaviour
{
    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("TestScene");
    }
}
