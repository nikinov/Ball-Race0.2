using UnityEngine;
using UnityEngine.SceneManagement;

public class level2 : MonoBehaviour
{
    public void StartGameSecond ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 2);
    }
}
