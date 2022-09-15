using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Reserve : MonoBehaviour
{
    //manage the player's item stockage

    public Dictionary<string,int> item_stocked = new Dictionary<string,int>();
    
    public int[] item_in_stock = {0,0,0,0,0};

    void Start()
    {
        item_stocked.Add("yellow_roll",0);
        item_stocked.Add("blue_roll",0);
        item_stocked.Add("red_roll",0);
        item_stocked.Add("stockage",0);
        item_stocked.Add("printer",0);
    }

  
}