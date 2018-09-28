using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public KeyCode restartKeyCode;
 
    void Update()
    {
        if (Input.GetKeyDown(restartKeyCode))
        {
            SceneManager.LoadScene("Fight");
        }
    }
}
