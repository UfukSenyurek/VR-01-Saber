using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject InGameMenu;
    public GameObject PauseMenu;
    public GameObject CurrentMenu;

    private static MenuScript instance;

    void Awake()
    {
        // Check if an instance already exists
        if (instance == null)
        {
            // If not, set this as the instance
            instance = this;
            // Mark this GameObject to not be destroyed on load
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If an instance already exists, destroy the duplicate
            Destroy(gameObject);
        }
    }

    void Start()
    {
        CurrentMenu = MainMenu;
        ChangeMenu(MainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeMenu(GameObject TargetMenu)
    {
        CurrentMenu.SetActive(false);
        TargetMenu.SetActive(true);
        CurrentMenu=TargetMenu;
    } 
    public void StartGame() // MainMenu Button
    {
        ChangeMenu(InGameMenu);
        SceneManager.LoadScene(1);
    }
    public void ExitToDesktop() // MainMenu Button
    {
        Application.Quit();
    }
    public void OpenMainMenu() // PauseMenu Button
    {
        ChangeMenu(MainMenu);
        SceneManager.LoadScene(0);
    }
    public void ResumeGame() // PauseMenu Button
    {
        ChangeMenu(InGameMenu);
    }
    
    public void PauseGame()// In Game Menu Button
    {
        ChangeMenu(PauseMenu);
    }
   
    



}
