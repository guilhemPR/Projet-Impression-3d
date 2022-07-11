using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGame_Menu_Script : MonoBehaviour
{
    [SerializeField] private Button Save_Button;
    [SerializeField] private Button Option_Button;
    [SerializeField] private Button Quit_Button;
    [SerializeField] private Button Resum_Button;

    [SerializeField] private GameObject Ui_In_Game_Menu;
    [SerializeField] private Button Menu_Button; 

    Void Start()
    {
        Resum_Button.onClick.AddListener()
    }

    private Void Resum_Game()
    {
        Ui_In_Game_Menu.SetActive(true);
        Menu_Button.onClick.RemoveListener(Open_Menu);
        Canvas canvas = this.gameObject.GetComponent<Canvas>();
        canvas.enabled = false; 
    }
}
