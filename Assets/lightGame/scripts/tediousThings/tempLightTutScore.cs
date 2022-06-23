using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempLightTutScore : MonoBehaviour
{

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
}
