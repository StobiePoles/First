using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisions : MonoBehaviour
{
    public float nonBullShitter = 5;
    private void Update()
    {
        nonBullShitter -= Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ded" && nonBullShitter <= 0)
        {        
            nonBullShitter = 5;
            SceneManager.LoadScene("SampleScene");
            Progress.Lives--;


        }
    }
}
