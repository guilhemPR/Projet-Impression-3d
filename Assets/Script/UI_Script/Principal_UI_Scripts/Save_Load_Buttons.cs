using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

//For Save & Load Button; 
    
public class Save_Load_Buttons : MonoBehaviour
{

    public TimeData timeData;
    
    
    public void Save_Button()
    {
        Save_Game();
    }

    private void Save_Game()
    {
        string timeDataString = JsonUtility.ToJson(timeData);
        Debug.Log(timeDataString);
        string filePath = Application.persistentDataPath + "/TimeData.Json";
        System.IO.File.WriteAllText(filePath, timeDataString);
        
        Debug.Log("Save");
    }

    public void Load_Button()
    {
        Load_Game();
    }

    private void Load_Game()
    {
        timeData = new TimeData();
        object newTimeData = timeData;
        
        string filePath = Application.persistentDataPath + "/TimeData.Json";
        string timeDataString = System.IO.File.ReadAllText(filePath); 
        EditorJsonUtility.FromJsonOverwrite(timeDataString,timeData);
        
    }
    
}
