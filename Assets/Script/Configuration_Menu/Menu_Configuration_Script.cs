using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_Configuration_Script : MonoBehaviour
{

  [SerializeField] private Button Video_Para_Button;
  [SerializeField] private Button Audio_Para_Button;
  [SerializeField] private Button Sav_Para_Button;
  [SerializeField] private Button Return_Button;

  [SerializeField] private GameObject Configuation_Menu_UI;
  [SerializeField] private GameObject Video_Para_Ui; 
  [SerializeField] private GameObject Audio_Para_Ui; 

  void OnEnable()
  {
    
    //Video_Para_Button.onClick.AddListener();
    Audio_Para_Button.onClick.AddListener(Open_Audio_Para);
   // Sav_Para_Button.onClick.AddListener();
    Return_Button.onClick.AddListener(Return_to_Main_Menu);
  }
  
  private void Return_to_Main_Menu()
  {
    
    SceneManager.LoadScene("Start_Menu_Scene");
    
    Debug.Log("Pouic" );
  }
  
  // Audio System Fonction
  
  private void Open_Audio_Para()
  {
    Close_Principal_Para_Menu();
    
    Audio_Para_Ui.SetActive(true);
    
  }

  private void Close_Audio_Para()
  {
    Open_Principal_Para_Menu();
    
    Audio_Para_Ui.SetActive(false);
    
    Principal_Para_Menu_Add_Buttons_Listener();
    
  }
  
  // // 

  //Switch_Menu_System

  private void Open_Principal_Para_Menu()
  {
    Configuation_Menu_UI.SetActive(true);
    
    Principal_Para_Menu_Add_Buttons_Listener();

  }
  
  private void Close_Principal_Para_Menu()
  {
    Principal_Para_Menu_Remove_Buttons_Listener();
    
    Configuation_Menu_UI.SetActive(false);
  }
  //  // Add All Lister of Principal Menu Buttons

  private void Principal_Para_Menu_Add_Buttons_Listener()
  {
    //Video_Para_Button.onClick.AddListener();
    Audio_Para_Button.onClick.AddListener(Open_Audio_Para);
   // Sav_Para_Button.onClick.AddListener();
    Return_Button.onClick.AddListener(Return_to_Main_Menu);
  }
  
  //  // Remove All Listener of Principal Menu Buttons

  private void Principal_Para_Menu_Remove_Buttons_Listener()
  {
   // Video_Para_Button.onClick.RemoveListener();
    Audio_Para_Button.onClick.RemoveListener(Open_Audio_Para);
    //Sav_Para_Button.onClick.RemoveListener();
    Return_Button.onClick.RemoveListener(Return_to_Main_Menu);
  }


}
