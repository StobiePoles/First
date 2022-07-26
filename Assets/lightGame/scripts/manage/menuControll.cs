using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuControll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetMeTheHellOutOfHere()
    {

        Application.Quit();
        Debug.Log("End Game");
    }


    public void ToStartignMenu()
    {
        SceneManager.LoadScene("Menu");

    }    
    public void About()
    {
        SceneManager.LoadScene("aboutScene");

    }
    public void ToLevels()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ToTut()
    {     
        SceneManager.LoadScene("BasicMovementTut");

    }
    public void ToLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");

    }

    public void Basic()
    {
        SceneManager.LoadScene("BasicMovementTut");
    }
    public void Light()
    {
        SceneManager.LoadScene("LightTut");
    }
    public void wall()
    {
        SceneManager.LoadScene("WallRunTut");
    }
    public void invercing()
    {
        SceneManager.LoadScene("InverseTut");
    }
    public void grappling()
    {
        SceneManager.LoadScene("grappleTut");
    }

    public void Blue()
    {
        SceneManager.LoadScene("Blue");
    }
    public void Red()
    {
        SceneManager.LoadScene("Red");
    }
    public void Purple()
    {
        SceneManager.LoadScene("Purple");
    }

    public void Orange()
    {
        SceneManager.LoadScene("orange");
    }





    public void RestartGame()
    {
        Progress.Lives = 3;
        Progress.finished = false;
        lightyBox.blueCompleted = false;
        lightyBox.redCompleted = false;
        lightyBox.purpleCompleted = false;
        SceneManager.LoadScene("Menu");
    }




}
