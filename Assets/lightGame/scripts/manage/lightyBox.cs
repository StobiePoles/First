using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lightyBox : MonoBehaviour
{
    public ParticleSystem Cheer;
    public bool play = false;
    public bool startTimer;
    float x = 2;
    public bool ThisBlue = false;
    public bool ThisRed = false;
    public bool ThisPurple = false;
    public bool ThisOrange = false;
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
        if(WhatLevel == "orange")
            ThisOrange = true;

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
            }
                
            else if(ThisRed)
            {
                redCompleted = true;
            }
            
            else if (ThisPurple)
            {
                purpleCompleted = true;
            }
            else if (ThisOrange)
            {
                SceneManager.LoadScene("WinningScene");
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
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
