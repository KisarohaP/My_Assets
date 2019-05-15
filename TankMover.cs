using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMover : MonoBehaviour
{

    public float moveSpeed;
    public float turnSpeed;
    //public AudioClip RunningSound;
    public Transform Engine;

    //操作
    void Update()
    {
        Move();
        //if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        //{
            Turn();
        //}
        //else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
        //{
        //    Turn();
        //}
    }

    //前進操作
    void Move()
    {
        float speed = Input.GetAxis("Vertical") * moveSpeed;
        transform.position += transform.forward * speed * Time.deltaTime;
        //AudioSource.PlayClipAtPoint(RunningSound, Engine.position);
    }

    //旋回操作
    void Turn()
    {
        float round = Input.GetAxis("Horizontal") * turnSpeed;
        transform.Rotate(0, round, 0);
    }
}
