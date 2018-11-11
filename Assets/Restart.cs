using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public KeyCode restartKeyCode;
    public KeyCode exitMainMenu;
 
    void Update()
    {
        if (Input.GetKeyDown(restartKeyCode))
        {
            SceneManager.LoadScene("Fight");
        }
        if (Input.GetKeyDown(exitMainMenu))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
