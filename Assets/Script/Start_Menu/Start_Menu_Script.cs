using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Scene = UnityEngine.SceneManagement.Scene;

public class Start_Menu_Script : MonoBehaviour
{
    [SerializeField] private Button startNewGameButton;
    [SerializeField] private Button loadGameButton;
    [SerializeField] private Button configurationButton;
    [SerializeField] private Button exitButton; 
        
    void Start()
    {
        startNewGameButton.onClick.AddListener(StartNewGameButtonFonction);
        loadGameButton.onClick.AddListener(LoadGameButtonFonction);
        configurationButton.onClick.AddListener(ConfigurationButtonFonction);
        exitButton.onClick.AddListener(ExitButtonFonction);
    
    }

    private void StartNewGameButtonFonction()
    {
        SceneManager.LoadScene("Game_Principal_Scene");
    }

    private void LoadGameButtonFonction()
    {
        
    }

    private void ConfigurationButtonFonction()
    {
        SceneManager.LoadScene("Configuration_Menu_Scene");
    }

    private void ExitButtonFonction()
    {

        Debug.Log("exit");
        UnityEditor.EditorApplication.isPlaying = false;
         Application.Quit(); 
      
    }
}
