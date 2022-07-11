using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Comparers;
using UnityEngine.PlayerLoop;

public class Object_Mover1 : MonoBehaviour
{
   [SerializeField] private Camera _camera;

   void Update()
   {
      ObjectSelection(_camera, 100f);
   }
   
   
   
   static void ObjectSelection(Camera cam, float RayMaxDistance)
   {
      Ray ray = cam.ScreenPointToRay(Input.mousePosition);
      RaycastHit hit;

      if (Physics.Raycast(ray, out hit, RayMaxDistance))
      {
        
      }
   }
   
   
   private void ObjectMover()
   {
      
   }
}
