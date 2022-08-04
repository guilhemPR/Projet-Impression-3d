using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Principal_UI_Script : MonoBehaviour
{
   //Variable for Menu_Button; 
   
   private float _timeScaleMenu = 0;
   private float _timeScaleGame = 1;

   [SerializeField] private GameObject Menu_UI;
   [SerializeField] private GameObject Principal_UI; 
   
   public void Menu_Button()
   {
      if (Time.timeScale == _timeScaleGame)
      {
         Time.timeScale = _timeScaleMenu; 
      }
      else
      {
         Time.timeScale = _timeScaleGame;
      }
      
      Menu_UI.SetActive(true);
      Principal_UI.SetActive(false);
   }
}
