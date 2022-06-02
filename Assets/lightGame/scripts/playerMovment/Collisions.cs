using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisions : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ded")
        {
                SceneManager.LoadScene("SampleScene");
            Progress.Lives--;
        }
    }
}
