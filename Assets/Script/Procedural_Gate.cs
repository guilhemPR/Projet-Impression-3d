using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Procedural_Gate : MonoBehaviour
{
   
   [Range(0,1000)][SerializeField] private int _gate_High = 100;
   [Range(0,1000)][SerializeField] private int _gate_Lenght = 100;

   [SerializeField] private Renderer _renderer; 
   
   [SerializeField] private Color _color;
   
   void Start()
   {
      Texture2D gate_Texture = new Texture2D(_gate_High,_gate_Lenght);

      for (int y = 0; y < _gate_High ; y++)
      {
         for (int x = 0; x < _gate_Lenght; x+=10)
         {
          
            gate_Texture.SetPixel(x,y,new Color(1,1,1,1));
         }
      }
      
      for (int y = 0; y < _gate_High ; y+=10)
      {
         for (int x = 0; x < _gate_Lenght; x++)
         {
            gate_Texture.SetPixel(x,y,new Color(1,1,1,1));
         }
      }

      gate_Texture.Apply();
   
      _renderer.material.mainTexture = gate_Texture; 

   }
}
