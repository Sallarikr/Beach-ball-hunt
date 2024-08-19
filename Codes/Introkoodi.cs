using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Introkoodi : MonoBehaviour
{
    void Start()
    {
        // Musiikin toisto jatkumaan muistista scenen vaihtuessa
        DontDestroyOnLoad(GameObject.Find("Aaniolio"));
    } // Start

    void Update()
    {
        // Eteenpäin siirtyminen
        if(Input.anyKey)
        {
            SceneManager.LoadScene("SampleScene");
        } // if
    } // Update
} // class
