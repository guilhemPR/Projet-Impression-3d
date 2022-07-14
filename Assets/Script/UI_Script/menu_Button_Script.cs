using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_Button_Script : MonoBehaviour
{
    public  GameObject Game_Menu;
    public GameObject Game_UI; 
    
    public void Close_Menu()
    {
  
        Game_UI.SetActive(true);
        Game_Menu.SetActive(false);
        
    }

    public void Open_Principal_Menu()
    {
        
    }
}
