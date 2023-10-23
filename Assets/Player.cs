using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    private Transform camera;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        camera = GameObject.FindWithTag("MainCamera").transform;
    }

    void Update()
    {
        rb.velocity = Vector3.zero; //ŠŠ‚è–hŽ~
        float x_rotation = Input.GetAxis("Mouse X");
        float y_rotation = Input.GetAxis("Mouse Y");
        transform.Rotate(0, x_rotation * 2.5f, 0);
        camera.Rotate(-y_rotation * 2.5f, 0, 0);

        var velocity = Vector3.zero;
        if (Input.GetKey("w")) velocity.z = speed;
        else if (Input.GetKey("s")) velocity.z = -speed;
        else if (Input.GetKey("a")) velocity.x = -speed;
        else if (Input.GetKey("d")) velocity.x = speed;
        if (velocity.x != 0 || velocity.z != 0) transform.position += transform.rotation * velocity*Time.deltaTime;
    }
}
