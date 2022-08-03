using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TimeData
{
    
    //all Time variables to save
    
    
    [Range(1,60)]public static readonly int Day_Lengh_In_Real_Minutes = 1;
    public static float CurrentTime; 
    
    public static int Minutes;
    
    
    public static int Hours = 0;
    public static int hours_modifier = 0; 

    public static int day = 29;
    public static int day_Name_index = 4;

    public static int month = 2;
    public static int month_Size = 28; 
    
    
    public static int Years = 2022;


    // Days and Months Name Variable
    
    public static readonly Dictionary< int, string> day_Names_Dictionary = new Dictionary< int, string>
    {
        [1] = "lundi",
        [2] = "mardi",
        [3] = "mercredi",
        [4] = "jeudi",
        [5] = "vendredi",
        [6] = "samedi",
        [7] = "dimanche"
    
        
    };

    public static readonly Dictionary<int, string> Month_Names_Dictionary = new Dictionary<int, string>
    {
        [1] = "Janvier",
        [2] = "Février",
        [3] = "Mars",
        [4] = "Avril",
        [5] = "Mai",
        [6] = "Juin",
        [7] = "Juillet",
        [8] = "Aout",
        [9] = "Septembre",
        [10] = "Octobre",
        [11] = "Novembre",
        [12] = "Décembre",
    };






}
