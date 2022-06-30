using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 public class tutorialProgress : MonoBehaviour
{
    public string CurrentLevel;
    public GameObject final;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ShootingRange.score == 7)
       {
            final.SetActive(true);
       }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ball")
        {
            goToNext();
            Debug.Log("oahsdfjlasfhasfhlashfksaf");
        }
    }


    void goToNext ()
    {
        switch (CurrentLevel)
        {
            case "light":
                SceneManager.LoadScene("wallRunTut");
                break;
            case "wall":
                SceneManager.LoadScene("InverseTut");
                break;
            case "inverse":
                SceneManager.LoadScene("grappleTut");
                break;
            case "grapple":
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                SceneManager.LoadScene("Menu");
                break;
            case "first":
                SceneManager.LoadScene("lightTut");
                break;



        }
    }


}
