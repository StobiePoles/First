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
   static public bool blue;
   static public bool red;
   static public bool purple;



    // Start is called before the first frame update
    void Start()
    {
        Cheer.Stop();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (play == true)
            startTimer = true;


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
