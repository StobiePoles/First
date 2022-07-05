using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Progress : MonoBehaviour
{
    public GameObject BlueTree;
    public GameObject RedTree;
    public GameObject PurpleTree;

    public Material blue;
    public Material red;
    public Material purple;

    public static int Lives = 3;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public static bool finished = false;

    public GameObject GroundPortal;
    public GameObject GroundPortalTrigger;



    // Start is called before the first frame update
    void Start()
    {

        GroundPortal.gameObject.SetActive(false);
        GroundPortalTrigger.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(finished == false)
        {
            GroundPortal.gameObject.SetActive(false);
            GroundPortalTrigger.gameObject.SetActive(false);
        }
        else if (finished == true)
        {
            GroundPortal.gameObject.SetActive(true);
            GroundPortalTrigger.gameObject.SetActive(true);
        }


        Checking();
       

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

                SceneManager.LoadScene("deathScene");
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Lives = 3;

                break;

        }





    }


    void Checking()
    {
        if(lightyBox.blueCompleted == true && lightyBox.redCompleted == true && lightyBox.purpleCompleted == true)
            finished = true;

    }
}
