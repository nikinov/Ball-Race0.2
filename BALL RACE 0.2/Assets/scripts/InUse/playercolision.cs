using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercolision : MonoBehaviour
{
    public PlayerMovement PlayerMovement;
    public GameManager GameManager;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            PlayerMovement.Die();
            FindObjectOfType<GameManager>().EndGame();
        }
        if (collisionInfo.collider.tag == "FinishLine")
        {
            PlayerMovement.Die();
            FindObjectOfType<GameManager>().completeLevel();
        }
		if (collisionInfo.collider.tag == "Play")
		{
            SceneManager.LoadScene(sceneBuildIndex: 0);
		}
        if (collisionInfo.collider.tag == "Skins")
        {
            SceneManager.LoadScene(sceneBuildIndex: 1);
        }
    }
}