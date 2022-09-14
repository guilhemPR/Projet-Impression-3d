using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purchase_action : store
{

    public int playerMoney = 100;
    

    public void Purchase_Yellow_Roll(string ballec)
    {
        if (playerMoney >= 25)
        {
            playerMoney -= price[0];
            item_in_stock[0] += 1;
        }
    }
}
