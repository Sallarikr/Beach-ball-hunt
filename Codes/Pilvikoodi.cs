using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilvikoodi : MonoBehaviour
{   
    void Update()
    {
        // Skyboxin pyöritys
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 0.4f);
    } // Update
} // class
