using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{

    public Text healthText;
    public int health = 10;


    private void Start()
    {
        healthText.text = health.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DamageZone")
        {
            health = health - 1;
            healthText.text = health.ToString();
            Destroy(collision.gameObject);

            Debug.Log("Kollision DamageZone");
        }
        if (collision.gameObject.tag == "Healthpack")
        {
            health = health + 1;
            healthText.text = health.ToString();


            Debug.Log("Kollision Healthpack");
        }
    }
        

}