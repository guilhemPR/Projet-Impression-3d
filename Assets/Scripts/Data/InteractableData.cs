using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Interactable", menuName = "Interactable/New Interactable")]
public class InteractableData : ScriptableObject
{
   public string Name;
   public Sprite Visual;
   public GameObject prefab;
   
   public int Price; 
}
