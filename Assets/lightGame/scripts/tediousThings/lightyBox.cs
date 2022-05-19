using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightyBox : MonoBehaviour
{
    public GameObject Black;
    public GameObject Yellow;
    public ParticleSystem Cheer;
    public bool play = false;

    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        Black.SetActive(true);
        Yellow.SetActive(false);
        Cheer.Stop();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (play)
        {
            Cheer.Play();
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "asamawahanwanhamdo")
        {
            Debug.Log("working");
            Black.SetActive(false);
            Yellow.SetActive(true);
            play = true;
            button.transform.position += new Vector3(0.1f, 0, 0);
        }
    }


}
