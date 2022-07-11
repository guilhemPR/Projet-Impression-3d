using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Object_Mover : MonoBehaviour
{
     [SerializeField] private Transform ObjectOrigin;
     [SerializeField] private GameObject[] ObjectMesh; 
     
     private Vector3 _hitPosition;
     [Range(10,0)][SerializeField] private float objectPositionMaxDeep;
     
     [SerializeField] private Button UpButton;
     [SerializeField] private Button DownButton;

     [SerializeField] private GameObject Emphty;
 
     private Color _defaultColor;
     public Color _forbidenPosition;

     void Start()
     {
         UpButton.onClick.AddListener(UpObjectPosition);
         DownButton.onClick.AddListener(DownObjectPOsition);
     }
    
    

   
   /* void Update()
    {
        Ray ray = new Ray(ObjectOrigin.position, Vector3.down);
        
        if (Physics.Raycast(ray, out RaycastHit tempoHitInfo,  10f))
        {
            _hitPosition = tempoHitInfo.transform.position;
        }
        
        if (ObjectOrigin.position.y <  _hitPosition.y && ObjectOrigin.position.y > _hitPosition.y - objectPositionMaxDeep)
        {
            Debug.Log("ça collide");
        }

        transform.position = new Vector3(transform.position.x, _hitPosition.y, transform.position.z);
    } */

    private void UpObjectPosition()
    {
        
        ObjectJumper(Vector3.up, 0.01f);
    

    }

    private void DownObjectPOsition()
    {
        ObjectJumper(Vector3.down, -0.01f);
    }

    private void ObjectJumper(Vector3 originDirection, float jumpPrecision)
    {
        

        Vector3[] MeshRelativeTransform = new Vector3[ObjectMesh.Length];

        for (int i = 0; i < ObjectMesh.Length; i++)
        {
            MeshRelativeTransform[i] = ObjectMesh[i].transform.localPosition;
            ObjectMesh[i].SetActive(false);
        }

        Ray ray = new Ray(ObjectOrigin.position, originDirection);

        if (Physics.Raycast(ray, out RaycastHit tempoHitInfo))
        {
            ObjectOrigin.position = new Vector3(ObjectOrigin.position.x, tempoHitInfo.point.y + jumpPrecision,
                ObjectOrigin.position.z);
        }

        GameObject JumpPostionHelper = Instantiate(Emphty);

        JumpPostionHelper.transform.position = ObjectOrigin.position;


        while (Physics.Raycast(new Ray(JumpPostionHelper.transform.position, -originDirection),
            out RaycastHit jumpRaycastHit) && jumpRaycastHit.point.y < ObjectOrigin.position.y)
        {
            JumpPostionHelper.transform.position = new Vector3(JumpPostionHelper.transform.position.x,
                JumpPostionHelper.transform.position.y + jumpPrecision, JumpPostionHelper.transform.position.z);
        }
        
        Physics.Raycast(new Ray(JumpPostionHelper.transform.position, -originDirection),
            out RaycastHit raycastHit);

        ObjectOrigin.position = raycastHit.point;

        for (int i = 0; i < ObjectMesh.Length; i++)
        {
            MeshRelativeTransform[i] = ObjectMesh[i].transform.localPosition;
            ObjectMesh[i].SetActive(true);
        }

        Destroy(JumpPostionHelper);
    }

 
}


