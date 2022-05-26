using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightBall : MonoBehaviour
{
    public float projectileLife = 30;
    private float timer;
    public int damage;
   // public GameObject light;

    private Color currentColor;
    private int colorInt;
    public int speedTimer = 15;

    void Start()
    {
        timer = 0;
      //  var lightcolor = light.GetComponent<Renderer>();


    }


    private void FixedUpdate()
    {
        //gameObject.GetComponent<Renderer>().material.color = new Color(colorValue1, colorValue2, colorValue3);
        // lightcolor.color = new Color32(173, 173, 173, 255);
        



        if (colorInt == 0)
        {
            currentColor = Color.Lerp(currentColor, Color.red, speedTimer * Time.deltaTime);
            if (Vector4.Distance(currentColor, Color.red) < 0.1f)
            {
                colorInt = 1;
            }
        }

        if (colorInt == 1)
        {
            currentColor = Color.Lerp(currentColor, Color.yellow, speedTimer * Time.deltaTime);
            if (Vector4.Distance(currentColor, Color.yellow) < 0.1f)
            {
                colorInt = 2;
            }
        }

          if (colorInt == 2)
        {
            currentColor = Color.Lerp(currentColor, Color.green, speedTimer * Time.deltaTime);
            if (Vector4.Distance(currentColor, Color.green) < 0.1f)
            {
                colorInt = 3;
            }
        }
        if (colorInt == 3)
        {
            currentColor = Color.Lerp(currentColor, Color.cyan, speedTimer * Time.deltaTime);
            if (Vector4.Distance(currentColor, Color.cyan) < 0.1f)
            {
                colorInt = 4;
            }
        }
        if (colorInt == 4)
        {
            currentColor = Color.Lerp(currentColor, Color.blue, speedTimer * Time.deltaTime);
            if (Vector4.Distance(currentColor, Color.blue) < 0.1f)
            {
                colorInt = 5;
            }
        }
        if (colorInt == 5)
        {
            currentColor = Color.Lerp(currentColor, Color.magenta, speedTimer * Time.deltaTime);
            if (Vector4.Distance(currentColor, Color.magenta) < 0.1f)
            {
                colorInt = 0;
            }
        }



        /*
        if (colorValue1 >= 255)
            {
                colorValue3++;
            }
            else if (colorValue3 >= 255)
            {
                colorValue1--;
            }
            else if (colorValue1 <= 0)
            {
                colorValue2++;
            }
            else if (colorValue2 >= 255)
            {
                colorValue3--;
            }
            else if (colorValue3 <= 0)
            {
                colorValue1++;
            }
            else if (colorValue1 >= 255)
            {
                colorValue2--;
            }
        */
        gameObject.GetComponent<Light>().color = currentColor;
        gameObject.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", currentColor);



    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= projectileLife)
        {
            Destroy(gameObject);
        }
    }


}
