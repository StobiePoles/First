using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FLticks : MonoBehaviour
{
    public Text text;
    public int textNumber = 0;
    public Image tickOne;
    public Image tickTwo;
    public Image tickThree;

    public GameObject wallOne;
    public GameObject wallTwo;
    public GameObject wallThree;


    // Start is called before the first frame update
    void Start()
    {
        tickOne.enabled = false;
        tickTwo.enabled = false;
        tickThree.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        switch (SignCollisions.number)
        { 
            case 0:
                text.text = "hello and welcome to my wizard boy game";
                break;
            case 1:
                text.text = "try and do a jump for me using the space bar";
                SignCollisions.onceJump = false;
                break;
            case 2:
                text.text = "good job, you can move onto the next sign";
                tickOne.enabled = true;
                wallOne.SetActive(false);
                break;
            case 3:
                text.text = "try and crouch for me using the control";
                SignCollisions.onceCrouch = false;
                break;
            case 4:
                text.text = "good job, you can more on to the next sign";
                tickTwo.enabled = true;
                wallTwo.SetActive(false);
                break;
            case 5:
                text.text = "do a left click to shoot a light projectile";
                SignCollisions.onceShoot = false;
                break;

            case 6:
                text.text = "nice shot! Shoot the cube to proceed to the next stage";
                wallThree.SetActive(false);
                tickThree.enabled = true;
                break;
            case 7:
                text.text = "you look like your ready for the other tutorials";
                break;
                default:
                text.text = "go closer to the sign";
                break;


        }
       // FLticks.textNumber = SignCollisions.number;
    }
}
