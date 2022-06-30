using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleProjectile : MonoBehaviour
{
    public float projectileLife = 10;
    private float timer;
    public Transform ball;
    public Light light;
    public float possableRange;




    Rigidbody rb; 

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {

        light = GetComponent<Light>();

        light.range = possableRange / 10; 

        timerStuff();



    }
    void timerStuff()
    {
        timer += Time.deltaTime;
        


        if (timer >= projectileLife)
        {

            rb.isKinematic = false;
        }
        else if (timer > .8f)
        {
            rb.isKinematic = true;
        }


        if (timer >= projectileLife + 10 || Input.GetKeyDown(KeyCode.R))
        { 
            Destroy(gameObject);
        }

    }
}
