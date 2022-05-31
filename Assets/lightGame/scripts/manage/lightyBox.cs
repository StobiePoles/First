using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lightyBox : MonoBehaviour
{
    public ParticleSystem Cheer;
    public bool play = false;
    public bool startTimer;
    float x = 5;
    public static bool ThisBlue = false;
    public static bool ThisRed = false;
    public static bool ThisPurple = false;
    public static bool blueCompleted = false;
    public static bool redCompleted = false;
    public static bool purpleCompleted = false;
    public string WhatLevel;


    // Start is called before the first frame update
    void Start()
    {
        Cheer.Stop();


        if(WhatLevel == "Blue")
            ThisBlue = true;
        if (WhatLevel == "Red")
            ThisRed = true;
        if (WhatLevel == "Purple")
            ThisPurple = true;

    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        
        
        if (play == true)
        {
            startTimer = true;
            if(ThisBlue)
            {
                blueCompleted = true;
                Debug.Log("blue");
            }
                
            if(ThisRed)
            {
                redCompleted = true;
                Debug.Log("red");
            }
            
            if (ThisPurple)
            {
                purpleCompleted = true;
                Debug.Log("purple");
            }
                
        }
            


        if(startTimer == true)
            x = x - Time.deltaTime;



        if (play == true)
        {
            Cheer.Play();
            
            


            play = false;
        }
        if (x < 0)
        {
            Debug.Log("working");
            SceneManager.LoadScene("SampleScene");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {

            play = true;

            
        }




    }


}
