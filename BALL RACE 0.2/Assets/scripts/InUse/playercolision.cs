using UnityEngine;

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
    }
}