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


        timer += Time.deltaTime;
        if (timer > .8f)
        {
            Destroy(GetComponent<Rigidbody>());
        }


        if (timer >= projectileLife || Input.GetKeyDown(KeyCode.R))
        {
            Destroy(gameObject);
        }

    }

}
