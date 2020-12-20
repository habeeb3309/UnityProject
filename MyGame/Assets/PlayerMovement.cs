using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 7f;

    public Rigidbody rb;

    Vector3 movement;


    // Update is called once per frame
    void Update()
    {
        movement.z = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
    }
}
