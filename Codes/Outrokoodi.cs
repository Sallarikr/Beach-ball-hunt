using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Outrokoodi : MonoBehaviour
{
    void Start()
    {
        // Ajan hakeminen
        float aika1 = PlayerPrefs.GetFloat("aika");
        GameObject.Find("Lopputeksti").GetComponent<Text>().text = "Your time was " + aika1.ToString("0") + " seconds";
    } // Start

    void Update()
    {
        
    } // Update
} // class
