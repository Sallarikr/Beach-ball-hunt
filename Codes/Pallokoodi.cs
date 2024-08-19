using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pallokoodi : MonoBehaviour
{
    void Start()
    {
        
    } // Start

    void Update()
    {
        // Pallot pyörimään
        this.GetComponent<Transform>().Rotate(0f, 20f * Time.deltaTime, 0f);
    } // Update

    private void OnTriggerEnter(Collider other)
    {
        // Palloääni
        GameObject.Find("Aaniolio2").GetComponent<AudioSource>().Play();

        // Tarkistetaan oliko törmääjä pelaaja
        if(other.name.Equals("Pelaaja")) {
            // Pallolaskurin päivittäminen
            GameObject.Find("Koodivarasto").GetComponent<Laskurikoodi>().pallot++;
            Destroy(this.gameObject);
        } // if
    } // OnTriggerEnter
} // class
