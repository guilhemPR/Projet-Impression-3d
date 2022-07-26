using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Comparers;
using UnityEngine.UI;

public class Button_On_Object : MonoBehaviour
{
    [SerializeField] private Transform ObjectTransform;
    [SerializeField] private Camera MainCamera;
    [SerializeField] private Button _button;
    [SerializeField] private float Distance_Object_Button_y; 

    private void Update()
    {
        Vector3 Oject_UI_Position = MainCamera.WorldToScreenPoint(ObjectTransform.position);
        _button.transform.position = new Vector3(Oject_UI_Position.x, Oject_UI_Position.y + Distance_Object_Button_y, Oject_UI_Position.z);
    }
}
