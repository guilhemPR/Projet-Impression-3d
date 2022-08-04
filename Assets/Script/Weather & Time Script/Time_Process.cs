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
    public TimeData timeData; 
 
    private float InGame_Day_In_Seconds;
    private float TimeConverter;
    public string ClockString;

    private float _secondinGame;
    private float testsecond; 
    [SerializeField] private TextMeshProUGUI _Time_Text;

    private float Real_Second_Of_Simulat_Hour;
    private float Real_Second_Of_Simulat_Minute;

    void Start()
    {
         Real_Second_Of_Simulat_Hour = (((float)60 / 24) * timeData.Day_Lengh_In_Real_Minutes);
         Real_Second_Of_Simulat_Minute = Real_Second_Of_Simulat_Hour / 60; 
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
        timeData.CurrentTime += 1 * Time.deltaTime;
        
      

        if (timeData.CurrentTime >= Real_Second_Of_Simulat_Minute)
        {
            timeData.CurrentTime = 0 + (timeData.CurrentTime - Real_Second_Of_Simulat_Minute);
            timeData.Minutes++;
        }
        
        if (timeData.Minutes >= 60)
        {
            timeData.Minutes = 0; 
            timeData.Hours++;
        }
        
        
    }

    private void Day_Month_Year_Changer()
    {
        if (timeData.Hours >= 24 )
        {
            Time.timeScale = 0;
            
            timeData.day++;
            timeData.day_Name_index++;

            timeData.Hours = 0;

            if (timeData.day_Name_index > 7)
            {
                timeData.day_Name_index = 1; 
            }

            if (timeData.day >= timeData.month_Size)
            {
                timeData.day = 1;
                timeData.month++;
                Julian_Month_Size_Changer();

                if (timeData.month >= 12 ) 
                {
                    timeData.month = 1; 
                    timeData.Years++;
                   
                }
            }
        }
    }
    
    private void Time_Display()
    {
        ClockString = string.Format("{0:00}h{1:00}", timeData.Hours, timeData.Minutes) ;
        _Time_Text.text = ClockString + "    " + MonthData.day_Names_Dictionary[timeData.day_Name_index] + " " + timeData.day + " " +MonthData
            .Month_Names_Dictionary[timeData.month] + " " + timeData.Years;

    }

    private void Julian_Month_Size_Changer()
    {
        if (timeData.month == 2)
        {
            timeData.month_Size = 28; 
        }
        else if (timeData.month_Size == 30 || timeData.month_Size == 28)
        {
            timeData.month_Size = 31; 
        }
        else
        {
            timeData.month_Size = 30;
        }
        
       
        
    }
    

}
