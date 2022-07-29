using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Procedural_Gate_Mesh : MonoBehaviour
{

    private int _gate_Lenght = 2;
    private int _gate_Hight = 2;
    private float _gate_RealHight = 0.1f;
    private int _triangleIndex = 0;



    private int[] Triangles; 
    private Vector3[] vertice_Coordinate;


    
    Mesh _mesh; 
    
  
    void Start()
    {
        
        Creat_Vertice();
        TriangleAssignation();
        
        
        
        _mesh = GetComponent<MeshFilter>().mesh;

        _mesh.Clear();
        _mesh.vertices = vertice_Coordinate;
        _mesh.triangles = Triangles; 
    }

    private  void Creat_Vertice()
    {
            
        vertice_Coordinate = new Vector3[(_gate_Lenght) * (_gate_Hight)];

        int verticeIndex = 0; 
        
        for (int x = 0; x < _gate_Lenght; x++)
        {
            for (int y = 0; y < _gate_Hight; y++)
            {
              
                vertice_Coordinate[verticeIndex] = new Vector3(x, _gate_RealHight, y);
                Debug.Log(vertice_Coordinate[verticeIndex]);
                verticeIndex++; 
             
            }
        }
    }

    private void TriangleAssignation()
    {
        Triangles = new int[(_gate_Lenght * _gate_Hight) * 6];
        
        Debug.Log(Triangles.Length);

        for (int x = 0; x < _gate_Lenght; x++)
        {
            for (int y = 0; y < _gate_Hight; y++)
            {
                if (x < _gate_Lenght && y < _gate_Hight)
                {
                    TriangleIndexation(y, y+1, y+_gate_Lenght);
                    TriangleIndexation(y+1, y+_gate_Lenght+1, y+_gate_Lenght);
                    
                    Debug.Log("Indexation faite");
                  
                    _triangleIndex += 3; 
                }
                 
            }
        }
        
    }
    
    void TriangleIndexation(int a, int b, int c)
    {
        Triangles[_triangleIndex] = a; 
        Triangles[_triangleIndex+1] = b; 
        Triangles[_triangleIndex+2] = c; 
        
        Debug.Log(a+" , "+ b + " " + c) ;
    }
}
