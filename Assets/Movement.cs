﻿using UnityEngine;

public class Movement : MonoBehaviour
{
    //Player inputs
    public string Forward;
    public string Left;
    public string Backward;
    public string Right;

    //Amount of movement
    public float moveX;
    public float moveY;

    //Center of Rotation/Movement
    public Transform target;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Player moves toward the opponent.
        if (Input.GetKey(Forward))
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveY * Time.deltaTime);
        }

        //Player moves clockwise around the opponent.
        if (Input.GetKey(Left))
        {
            transform.RotateAround(target.position, Vector3.up, moveX * Time.deltaTime);
        }

        //Player moves away from opponent.
        if (Input.GetKey(Backward))
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, -moveY * Time.deltaTime);
        }

        //Player moves counter-clockwise around the opponent.
        if (Input.GetKey(Right))
        {
            transform.RotateAround(target.position, Vector3.up, -moveX * Time.deltaTime);
        }
    }
}
