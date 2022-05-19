using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaryTiger : MonoBehaviour
{
    Vector3 playerVelocity;
    float TimeToMove = 2;
    float TimeToMove2 = 2;
    float TimeToMove3 = 2;
    float TimeToMove4 = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeToMove -= Time.deltaTime;
        TimeToMove2 -= Time.deltaTime;
        TimeToMove3 -= Time.deltaTime;
        TimeToMove4 -= Time.deltaTime;
        if (TimeToMove <= 1.5f)
        {
            transform.position += new Vector3(3, 2, 0);
            TimeToMove = 999999999;

        }
        if (TimeToMove2 <= 1)
        {
            transform.position += new Vector3(3, -2, 0);
            TimeToMove2 = 99999999;

        }
        if(TimeToMove3 <= .7f)
        {
            transform.position += new Vector3(8, 6, 0);
            TimeToMove3 = 9999999999;

        }
        if(TimeToMove4 <= .2f)
        {
            transform.position += new Vector3(8, -6, 0);
            TimeToMove = 2;
            TimeToMove2 = 2;
            TimeToMove3 = 2;
            TimeToMove4 = 2;
        }

    }

    
}
