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
    public void ToLevels()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("worked cheif");
    }
    public void ToTut()
    {        Debug.Log("worked cheif");
        SceneManager.LoadScene("BasicMovementTut");

    }
    public void ToLevelSelect()
    {        Debug.Log("worked cheif");
        SceneManager.LoadScene("LevelSelect");

    }

}