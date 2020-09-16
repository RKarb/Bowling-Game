using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlToUI : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("UI");
    }
}