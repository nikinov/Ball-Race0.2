using UnityEngine;
using UnityEngine.SceneManagement;

public class ToStore : MonoBehaviour
{
    public void GoToStore ()
	{
		SceneManager.LoadScene(sceneBuildIndex: 0);
	}
}
