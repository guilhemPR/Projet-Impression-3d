using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Comparers;

public class Sun_Process : MonoBehaviour
{
    public TimeData timeData; 
    
    [SerializeField] private Transform Sun_Transform;
    [SerializeField] private Light Sun_Light;
    private float sun_Rotation_Speed;

    void Start()
    {
        float adaptedRotationToTime = (timeData.Minutes + (((float)timeData.Hours+18)*60))/1440 ;
        
        Sun_Transform.eulerAngles = new Vector3( (360 * (adaptedRotationToTime)), Sun_Transform.eulerAngles.y, Sun_Transform.eulerAngles.z);

        sun_Rotation_Speed =  (float)360 / timeData.Day_Lengh_In_Real_Minutes / 60; 
    }

    void Update()
    {
        Sun_Transform.Rotate(1* (sun_Rotation_Speed*Time.deltaTime),0,0);
    }
}
