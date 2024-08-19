using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lopetuskoodi : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) { 
            Application.Quit();
        } // if
    } // Update
} // class
