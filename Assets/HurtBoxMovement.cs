using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.Networking;

public class HurtBoxMovement : MonoBehaviour
{
    public KeyCode Punch;

    /*public KeyCode Block;

    public KeyCode Grab; */

    public Transform Target;
    public Transform OrigPosition;
    public float Speed;

    void FixedUpdate()
    {
        float step = Speed * Time.deltaTime;

        if (Input.GetKey(Punch))
            transform.position = Vector3.Lerp(transform.position, Target.position, step);
        else
            transform.position = Vector3.MoveTowards(transform.position, OrigPosition.position, step);
    }
}
