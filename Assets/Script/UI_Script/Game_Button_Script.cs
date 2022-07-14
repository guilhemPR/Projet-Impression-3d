using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Button_Script : MonoBehaviour

{
    
    public  GameObject Game_Menu;
    public GameObject Game_UI; 
    
    public void Open_Menu()
    {
        Game_Menu.SetActive(true);
        Game_UI.SetActive(false);
        
    }
}
