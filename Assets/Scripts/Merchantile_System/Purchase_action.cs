using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purchase_action : store
{

    public int playerMoney = 100;
    

    public void Purchase_Yellow_Roll(string ballec)
    {
        if (playerMoney >= price[0])
        {
            playerMoney -= price[0];
            item_in_stock[0] += 1;
        }
    }

     public void Purchase_Blue_Roll(string ballec)
    {
        if (playerMoney >= price[1])
        {
            playerMoney -= price[1];
            item_in_stock[1] += 1;
        }
    }

     public void Purchase_Red_Roll(string ballec)
    {
        if (playerMoney >= price[2])
        {
            playerMoney -= price[2];
            item_in_stock[2] += 1;
        }
    }

     public void Purchase_Storage(string ballec)
    {
        if (playerMoney >= price[3])
        {
            playerMoney -= price[3];
            item_in_stock[3] += 1;
        }
    }

     public void Purchase_printer(string ballec)
    {
        if (playerMoney >= price[4])
        {
            playerMoney -= price[04];
            item_in_stock[4] += 1;
        }
    }
}
