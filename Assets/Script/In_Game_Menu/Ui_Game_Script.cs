using System.Collections;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;
using UnityEngine;
using UnityEngine.UI;

public class Ui_Game_Script : MonoBehaviour
{

    [SerializeField] private Button Menu_Button;
    
    [SerializeField] private GameObject Ui_In_Game_Menu; 
    
    // Start is called before the first frame update
    void Start()
    {
        Menu_Button.onClick.AddListener(Open_Menu);
    }

    private void Open_Menu()
    {
        Ui_In_Game_Menu.SetActive(true);
        Menu_Button.onClick.RemoveListener(Open_Menu);
        Canvas canvas = this.gameObject.GetComponent<Canvas>();
        canvas.enabled = false; 
    }

 
}
