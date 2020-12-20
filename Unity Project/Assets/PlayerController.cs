using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody rd;


    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f,0f, moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
    }
}
