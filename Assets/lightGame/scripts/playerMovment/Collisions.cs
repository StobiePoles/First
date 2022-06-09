using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisions : MonoBehaviour
{
    public float nonBull = 5;
    private void Update()
    {
        nonBull -= Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ded" && nonBull <= 0)
        {        
            nonBull = 5;
            SceneManager.LoadScene("SampleScene");
            Progress.Lives--;


        }
    }
}
