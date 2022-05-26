using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public GameObject LightProjectile;
    public Transform spawnTransform;
    public Image forceBar;
    public RawImage barOutline;
    public float force = 1000;


    // Start is called before the first frame update
    void Start()
    {
        barOutline.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            GameObject temp2 = Instantiate(LightProjectile, spawnTransform.position, spawnTransform.rotation);
            temp2.GetComponent<Rigidbody>().AddForce(temp2.transform.forward * force / 2);
            Debug.Log(force);
            force = 1000f;

            barOutline.enabled = false;

        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            barOutline.enabled = true;
        }


        SetForceUI();
       

    }



    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Mouse0) && force < 4000)
        {
            force += 40;
        }
    }

    void SetForceUI()
    {
        forceBar.fillAmount = (force - 1000) / 3000;
        print("working");
    }



}
