using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Comparers;
using UnityEngine.EventSystems;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Time_Process : MonoBehaviour
{

 
    private float InGame_Day_In_Seconds;
    private float TimeConverter;
    public string ClockString;

    private float _secondinGame;
    private float testsecond; 
    [SerializeField] private TextMeshProUGUI _Time_Text;

    void Start()
    {
      
    }
    
    void Update()
    {
        Minutes_Hour_Core();
        Day_Month_Year_Changer();
        Time_Display();
    }
    
    
    private void Minutes_Hour_Core()
    {
        // permet de confertir le temps de jeu minute pour une journée en seconde
        TimeData.CurrentTime += 1 * Time.deltaTime;
        
        float testsecond = TimeData.CurrentTime / TimeData.Day_Lengh_In_Real_Minutes * 24 * 60 * 60;

        Debug.Log(testsecond);
        // permet de convertir le temps d'une journée dans le jeu défini en minute en seconde
        InGame_Day_In_Seconds = TimeData.Day_Lengh_In_Real_Minutes*60;
        
        // permet de deiviser une seconde réel en 
        TimeConverter = (TimeData.CurrentTime / InGame_Day_In_Seconds);
   

        float t = TimeConverter * 24;
        
        TimeData.Hours = (int)Math.Floor(t);
        t *= 60; 
        TimeData.Minutes = (int)Math.Floor(t%60);
    }

    private void Day_Month_Year_Changer()
    {
        if (TimeData.Hours >= 24 )
        {
            TimeData.day++;
            TimeData.day_Name_index++;

            TimeData.CurrentTime = 0;

            if (TimeData.day_Name_index > 7)
            {
                TimeData.day_Name_index = 1; 
            }

            if (TimeData.day >= TimeData.month_Size)
            {
                TimeData.day = 1;
                TimeData.month++;
                Julian_Month_Size_Changer();

                if (TimeData.month >= 12 ) 
                {
                    TimeData.month = 1; 
                    TimeData.Years++;
                   
                }
            }
        }
    }
    
    private void Time_Display()
    {
        ClockString = string.Format("{0:00}h{1:00}", TimeData.Hours, TimeData.Minutes) ;
        _Time_Text.text = ClockString + "    " + TimeData.day_Names_Dictionary[TimeData.day_Name_index] + " " + TimeData.day + " " +TimeData
            .Month_Names_Dictionary[TimeData.month] + " " + TimeData.Years;

    }

    private void Julian_Month_Size_Changer()
    {
        if (TimeData.month == 2)
        {
            TimeData.month_Size = 28; 
        }
        else if (TimeData.month_Size == 30 || TimeData.month_Size == 28)
        {
            TimeData.month_Size = 31; 
        }
        else
        {
            TimeData.month_Size = 30; 
        }
        
       
        
    }
    

}
