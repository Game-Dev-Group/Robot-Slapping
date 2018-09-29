using UnityEngine;
using System.Collections;

public class HBMLimit : MonoBehaviour
{
    //Restricts the position of this object to be within a distance of "distance" of "center"
    public float distance;
    public Transform center;

    private void FixedUpdate()
    {
        float dst = Vector3.Distance(center.position, transform.position);
        if (dst > distance)
        {
            Vector3 vect = center.position - transform.position;
            vect = vect.normalized;
            vect *= (dst - distance);
            transform.position += vect;
        }
    }
}