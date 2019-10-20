using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public float Score;

    void Update()
    {
        scoreText.text = Score.ToString("0");
        Score = player.position.z + 140;
    }
}
