using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour

{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 100f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        rb.AddForce(0, 0, -forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        rb.AddForce(0, 0, forwardForce);

        if (rb.position.y <-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        if (Input.GetKey("q"))
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
            FindObjectOfType<GameManager>().PauseLevel();
        }
        if (Input.GetKey("r"))
        {
            rb.constraints = RigidbodyConstraints.None;
            FindObjectOfType<GameManager>().ResumeLevel();
        }
    }
}
