using System.Collections;
using System.Collections.Generic;
using Ditzelgames;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float forwardSpeed;
    public float forwardForce;
    public float SideSpeed;
    float Chek;
    public GameObject DethUI;
    public GameObject CompUI;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Awake()
    {
        //rb.velocity = transform.forward * Time.deltaTime * speed;
    }
    // Update is called once per frame
    void Update()
    {
        PhysicsHelper.ApplyForceToReachVelocity(rb, Vector3.forward * forwardForce * Time.deltaTime, forwardSpeed * Time.deltaTime);

        //rb.AddTorque(Vector3.forward * speed);

        if (DethUI == true)
        {
            Chek = 0;
        }
        if (CompUI == true)
        {
            Chek = 0;
        }
        else
        {
            Chek = 1;
        }
        //rb.MovePosition(transform.position + (transform.forward * Time.deltaTime));

        //transform.position += transform.forward * Time.deltaTime * forwardForce;

        //rb.velocity = transform.forward * Time.deltaTime * forwardForce;

        //transform.Rotate(forwardForce * Time.deltaTime, 0, 0);

        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(0.0f, 0.0f, Vertical);
        Vector3 Sidemove = new Vector3(Horizontal, 0.0f, 0.0f);

        rb.AddForce(move * speed * Time.deltaTime);
        rb.AddForce(Sidemove * SideSpeed * Time.deltaTime);
    }
    public void Die ()
    {
        speed = 0;
        forwardForce = 0;
        SideSpeed = 0;
    }
}
