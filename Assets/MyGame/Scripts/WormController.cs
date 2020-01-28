using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public int x;
    public string text;

    // Start is called before the first frame update
    void Start()
    {
        /*if (x>0)
        {
            Debug.Log("x ist größer als 0");
        }
        else
        {
            Debug.Log("x ist kleiner als 0");
        }

        if (text == "Richie")
        {
            Debug.Log("Cool");
        }
        else
        {
            Debug.Log("Nicht so cool");
        }

        float summe = AddNumbers(3.2f, 2.7f);
        */
        if (x > 10)
        {
            Debug.Log("x ist größer als 10");
        }
        else
        {
            Debug.Log("x ist kleiner als 10");
        }
    }

    // Update is called once per frame

    /*void Update()

    public float AddNumbers(float a, float b)
    {
        float c = a + b;
        return c;
    }*/
}
