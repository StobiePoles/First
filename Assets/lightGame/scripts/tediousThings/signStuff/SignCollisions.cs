using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignCollisions : MonoBehaviour
{
    public static int number = 0;
    public static bool onceJump = true;
    public static bool onceCrouch = true;
    public static bool onceShoot = true;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            number++;
            Destroy(GetComponent<Collider>());

        }
    }


}
