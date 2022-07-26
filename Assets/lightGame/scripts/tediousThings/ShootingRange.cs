using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingRange : MonoBehaviour
{
    float DistructionTimer = 5f;
    public static float score = 0;
    bool hit = false;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        Debug.Log(score);
        if(hit)
        {
            DistructionTimer -= Time.deltaTime;
        }
        if(DistructionTimer <= 0)
        {
            Destroy(gameObject);
        }
    }


    // Update is called once per frame

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;

            if(hit == false)
            {
                score++;
            }
            hit = true;

        }
    }

}
