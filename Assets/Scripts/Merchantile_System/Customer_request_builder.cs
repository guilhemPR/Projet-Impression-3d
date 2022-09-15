using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;



public class Customer_request_builder : MonoBehaviour
{
  
    
    [SerializeField]public string[][] customerRequests = new string[2][]; 

    public int timeBeforeCustomerRequest; 
    
    void Update()
    {
      
    }

    public void NewCustomerRequest()
    {
       
        //customer request variable parameter
        
        int Quantity = Random.Range(0, 10);
        int Day = Random.Range(2, 20);

        int materialIndex = Random.Range(0, store.item_to_purchase.Count);
        int rawMeterial =  store.item_to_purchase.ElementAt(materialIndex).Value;
        int itemPrice = rawMeterial * Quantity;

        string material = store.item_to_purchase.ElementAt(materialIndex).Key;

        int customerRequestIndex = Random.Range(0, 2);
            
        //export array creation 
            
        customerRequests[customerRequestIndex] = new string[5]
        { 
            "coupe", 
            Quantity.ToString(),
            Day.ToString(), 
            itemPrice.ToString(),
            material, 
                
        };

        // for test
            
        for (int i = 0; i < customerRequests[customerRequestIndex].Length; i++)
        {
            Debug.Log(customerRequests[customerRequestIndex][i]);
        }
         
          
        
    }
}