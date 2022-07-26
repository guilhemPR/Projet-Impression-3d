using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Computer_Script : MonoBehaviour
{
    void OnEnable()
    {
        UI_Interactable_Event.Open_UI += Open_Computer_UI;
        Debug.Log("Inscription");
    }

    void OnDisable()
    {
        UI_Interactable_Event.Open_UI -= Open_Computer_UI;
    }
    
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            if (Physics.Raycast(ray, out RaycastHit machin, Mathf.Infinity))
            {
            
                Debug.Log("open UI");
                  
            }
        }
    }
    void Open_Computer_UI()
    {
        
    }

}
