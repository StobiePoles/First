using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForth : MonoBehaviour
{
    public float speed = 10;
    public float distance = 10;


    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, Mathf.Sin(Time.timeSinceLevelLoad * speed) * distance * Time.deltaTime, 0);
    }
}
