using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalTrigger : MonoBehaviour
{
    public bool bluePortal = true;
    public bool redPortal = false;
    public bool purplePortal = false;
    public bool OrangePortal = false;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("works");


            if (bluePortal == true)
            {
                SceneManager.LoadScene("Blue");
            }
            if (redPortal == true)
            {
                SceneManager.LoadScene("Red");
            }
            if (purplePortal == true)
            {
                SceneManager.LoadScene("Purple");
            }
            if(OrangePortal == true)
            {
                SceneManager.LoadScene("orange");
            }
        }
    }
}
