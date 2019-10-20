using UnityEngine;
using UnityEngine.SceneManagement;

public class menu2 : MonoBehaviour
{
    public void StartGamePlay ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
}
