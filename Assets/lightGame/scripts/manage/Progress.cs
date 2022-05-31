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

    public bool blueCompleted = false;
    public bool redCompleted = false;
    public bool purpleCompleted = false;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
      //  Checking();
        if(blueCompleted)
        {
            BlueTree.GetComponent<Renderer>().material = blue;
        }
        if (redCompleted)
        {
            RedTree.GetComponent<Renderer>().material = red;
        }
        if (purpleCompleted)
        {
            PurpleTree.GetComponent<Renderer>().material = purple;
        }



    }


    void Checking()
    {
        if (lightyBox.blueCompleted == true)
        {
            blueCompleted = true;
        }/*
        if (lightyBox.red == true)
        {
            redCompleted = true;
        }
        if (lightyBox.purple == true)
        {
            purpleCompleted = true;
        }

*/
    }
}
