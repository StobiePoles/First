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
    public float possableRange;


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
            if (SignCollisions.onceShoot == false)
            {
                SignCollisions.onceShoot = true;
                SignCollisions.number++;
            }



            GameObject temp2 = Instantiate(LightProjectile, spawnTransform.position, spawnTransform.rotation);
            temp2.GetComponent<Rigidbody>().AddForce(temp2.transform.forward * force / 2);
            temp2.GetComponent<Rigidbody>().AddForce(temp2.transform.up * -250);

            force = 1000f;

            barOutline.enabled = false;

            HandleProjectile handleProjectile = temp2.GetComponent<HandleProjectile>();
            handleProjectile.possableRange = force;
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
    }



}
