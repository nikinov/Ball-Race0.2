using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu3 : MonoBehaviour
{
    void FixedUpdate()
    {
        if (Input.GetKey("m"))
        {
            SceneManager.LoadScene(sceneBuildIndex: 1);
        }
    }

}
