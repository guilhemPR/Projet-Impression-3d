using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Procedural_Mesh : MonoBehaviour
{
    private int _hight = 4; // A adapter pour correspondre à 1 unité et pas au vertex (donc 2 de long équivaut à 3 vertex;
    private int _lengt = 4; 
    
    
    public MeshFilter MeshFilter;

    private int[] _triangles;
    private Vector3[] _verticesVector3; 

    void Start()
    {
        _verticesVector3 = new Vector3[_hight*_lengt];
        
        
        int index = 0;
      
        
        for (int x = 0; x < _hight; x++)
        {
            for (int y = 0; y < _lengt; y++)
            {
                _verticesVector3[index] = new Vector3(x, 0, y);

                index++;

                Debug.Log(index + "" + _verticesVector3[index-1]);
            }
        }
    }

    private void TriangleAssignation()
    {
        _triangles = new int[(_hight - 1) * (_lengt - 1) ]; // créé la taille du tableau pour la création des triangles;
        
        int index = 0;

        for (int i = 0; i < _hight-1; i++)
        {
            for (int j = 0; j < _lengt-1; j++)
            {
                _triangles[index] = 
                
                index =+ 3; 
            }
            
            
        }
    }
}
