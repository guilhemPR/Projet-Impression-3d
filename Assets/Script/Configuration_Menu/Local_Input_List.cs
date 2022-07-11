using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Local_Input_List : MonoBehaviour
{
    public  Keybinding Keybinding = new Keybinding();
}

[System.Serializable]
public class Keybinding
{ 
    public TouchPhase Began = TouchPhase.Began;
    public TouchPhase Moved = TouchPhase.Moved;
    public TouchPhase Stationary = TouchPhase.Stationary;
    public TouchPhase Ended = TouchPhase.Ended;
    public TouchPhase Canceled = TouchPhase.Canceled;

}
