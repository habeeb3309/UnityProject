using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float Speed = 5f;

    GameObject scoreUIText;

    void Start()
    {
        scoreUIText = GameObject.FindGameObjectWithTag("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * Speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider col)
    {
      if((col.tag == "Player"))
        {
            ScoreCount.score++;
        } 
    }
}
