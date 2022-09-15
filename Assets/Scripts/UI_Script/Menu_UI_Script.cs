using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Menu_UI_Script : MonoBehaviour
{

    //Variable for Menu_Button; 

    private float _timeScaleMenu = 0;
    private float _timeScaleGame = 1;

    [SerializeField] private GameObject Menu_UI;
    [SerializeField] private GameObject Principal_UI;

    //For Return_Button

    public void Return_Button()
    {
        if (Time.timeScale >= _timeScaleGame)
        {
            Time.timeScale = _timeScaleMenu;
        }
        else
        {
            Time.timeScale = _timeScaleGame;
        }

        Principal_UI.SetActive(true);
        Menu_UI.SetActive(false);
    }
}
