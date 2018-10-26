using UnityEngine;

public class HurtBoxMovement : MonoBehaviour
{
    public KeyCode Punch;
    public KeyCode Block;
    //public KeyCode Grab;
    public static bool isBlocked;

    public Transform Target;
    public Transform OrigPosition;
    public float Speed;

    void FixedUpdate()
    {
        float step = Speed * Time.deltaTime;

        if (Input.GetKeyDown(Punch) || Input.GetKey(Block))
        {
            transform.position = Vector3.Lerp(transform.position, Target.position, step);
            if (Input.GetKey(Block))
                isBlocked = true;
            else isBlocked = false;
        }
        else transform.position = Vector3.MoveTowards(transform.position, OrigPosition.position, step);
    }
}
