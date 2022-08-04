using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//all Time variables to save
[System.Serializable] public class TimeData : MonoBehaviour
{
    [Range(1,60)]public  int Day_Lengh_In_Real_Minutes = 1;
    public float CurrentTime;
    public int Minutes;
    public int Hours = 9; 
    public  int day = 29;
    public  int day_Name_index = 4;

    public  int month = 2;
    public  int month_Size = 28; 
    
    
    public int Years = 2022;
}
