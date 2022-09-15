using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Interactable_Event : MonoBehaviour
{
    public delegate void Open_Interactable_UI();
    public static event Open_Interactable_UI Open_UI; 
    
    
 
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            if (Physics.Raycast(ray, out RaycastHit machin, Mathf.Infinity))
            {
                if (Open_UI != null && machin.transform.CompareTag("Interactable")) 
                {
                        
                        Open_UI();
                        
                }
            }
        }
    }
}

