using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions.Comparers;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Time_Process : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _Time_Text;
    private float Day_Lengh;
    private float TimeConverter; 
    

   

    void Update()
    {
        GameData.CurrentTime += 1 * Time.deltaTime;
        Day_Lengh = GameData.Day_Lengh_In_Real_Minutes * 60;
        TimeConverter = (GameData.CurrentTime / Day_Lengh);

        float t = TimeConverter * 24;
        t *= 60; 
        GameData.Minutes = (int)Math.Floor(t%60);

        if (GameData.Minutes + 1  >= 60  )
        {
            GameData.Hours++;

            if (GameData.Hours >= 24 )
            {
                GameData.Days++;
                GameData.Hours = 0;

                if (GameData.Days >= 30)
                {
                    GameData.Months++;
                    GameData.Hours = 0;

                    if (GameData.Months >= 12 )
                    {
                        GameData.Years++;
                        GameData.Months = 0; 
                    }
                }
            }
        }
        
        _Time_Text.text = "" + GameData.Hours + " ,le " + GameData.Days + "du mois numéro" + GameData.Months ;


    }

    
}
