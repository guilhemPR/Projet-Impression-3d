using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun_Process : MonoBehaviour
{
    [SerializeField] private Transform Sun_Transform;
    private float sun_Rotation_Speed;

    void Start()
    {
        
        sun_Rotation_Speed =  360 / GameData.Day_Lengh_In_Real_Minutes / 60  ; 
    }

    void Update()
    {
        Sun_Transform.Rotate(1* (sun_Rotation_Speed*Time.deltaTime),0,0);

        if ( GameData.Hours > 21)
        {
            
        }
        
    }
}
