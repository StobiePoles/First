using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinnyThingy : MonoBehaviour
{
    public float desiredRotate = 0;
    float smooth = 5.0f;
    public int change = 3;

    void FixedUpdate ()
    {
        desiredRotate += change;
        Quaternion target = Quaternion.Euler(desiredRotate, 0, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}
