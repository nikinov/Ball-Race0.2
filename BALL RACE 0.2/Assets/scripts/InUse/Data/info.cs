using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class info : MonoBehaviour
{
    public static float TheSpeed;
    public float Speed;
    public float AndularSpeed;
    protected Rigidbody r;


    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Speed = r.velocity.magnitude;
        AndularSpeed = r.angularVelocity.magnitude / (Mathf.PI * 2);
        TheSpeed = Speed + 0;
    }
}
