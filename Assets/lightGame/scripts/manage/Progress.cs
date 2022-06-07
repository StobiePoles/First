using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    public GameObject BlueTree;
    public GameObject RedTree;
    public GameObject PurpleTree;

    public Material blue;
    public Material red;
    public Material purple;

    public Light blueLight;
    public Light redLight;
    public Light purpleLight;

    public static int Lives = 3;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public static bool finished = false;





    // Start is called before the first frame update
    void Start()
    {
        blueLight.gameObject.SetActive(false);
        redLight.gameObject.SetActive(false);
        purpleLight.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Lives);


        Checking();
        if(lightyBox.blueCompleted == true)
        {
            BlueTree.GetComponent<Renderer>().material = blue;
            blueLight.gameObject.SetActive(true);
        }
        if (lightyBox.redCompleted == true)
        {
            RedTree.GetComponent<Renderer>().material = red;
            redLight.gameObject.SetActive(true);
        }
        if (lightyBox.purpleCompleted == true)
        {
            
            PurpleTree.GetComponent<Renderer>().material = purple;
            purpleLight.gameObject.SetActive(true);
        }

        switch (Lives)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;

            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);

            break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;

            default:

                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;

        }





    }


    void Checking()
    {
        if(lightyBox.blueCompleted == true && lightyBox.redCompleted == true && lightyBox.purpleCompleted == true)
            finished = true;

    }
}
