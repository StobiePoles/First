using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingRange : MonoBehaviour
{
    bool start = false;
    public static float score = 0;
    bool hit = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(start == true)
        {
            transform.position += new Vector3(0, -0.05f, 0);
        }
        Debug.Log(score);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            start = true;
            if(hit == false)
            {
                hit = true;
                score++;
            }

        }
    }

}
