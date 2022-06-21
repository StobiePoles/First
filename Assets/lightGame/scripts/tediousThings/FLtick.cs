using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FLticks : MonoBehaviour
{
    public Text text;
    public int textNumber = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (textNumber)
        {
            case 0:
                text.text = "hello and welcome to my wizard boy game";
                break;
            case 1:
                text.text = "try and do a jump for me using the space bar";
                break;
            case 2:
                text.text = "good job, you can more on to the next sign";
                break;
            case 3:
                text.text = "try and crouch for me using the control or C key";
                break;
            case 4:
                text.text = "Good job";
                break;
            case 5:
                text.text = "you look like you are ready to start your adventures, good luck";
                break;


        }
       // FLticks.textNumber = SignCollisions.number;
    }
}
