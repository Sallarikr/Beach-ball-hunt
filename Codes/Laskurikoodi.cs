using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Laskurikoodi : MonoBehaviour
{
    // Aikalaskuri
    private float laskuri = 0f;

    // Löydetyt pallot
    public int pallot = 0;

    // Unityn tekstikenttien haku
    public GameObject aikateksti = null;
    public GameObject palloteksti = null;

    void Start()
    {
    
    } // Start

    void Update()
    {
        // Aikalaskurin kasvattaminen
        this.laskuri += Time.deltaTime;

        // Aika ja pallot tekstikenttiin
        this.aikateksti.GetComponent<Text>().text = "Time: " + this.laskuri.ToString("0");
        this.palloteksti.GetComponent<Text>().text = "Beach balls: " + this.pallot + "/5";
        
        //  Kun pallot löydetty -> game over-sceneen
        if(this.pallot >= 5)
        {
            PlayerPrefs.SetFloat("aika",this.laskuri);
            SceneManager.LoadScene("Outroscene");
        } // if

    } // Update
} // class
