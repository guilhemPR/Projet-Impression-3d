using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class store : Reserve
{
    //public items[] items = {yellow_roll,blue_roll,red_roll,stockage,printer};
    [ReadOnly] public static Dictionary<string,int> item_to_purchase = new Dictionary<string,int>();
    public int[] price = {25,50,75,150,350};

    void Start()
    {

        item_to_purchase.Add("yellow_roll",25);
        item_to_purchase.Add("blue_roll",50);
        item_to_purchase.Add("red_roll",75);
        item_to_purchase.Add("stockage",150);
        item_to_purchase.Add("printer",350);

    }


    void Update()
    {

    }
}