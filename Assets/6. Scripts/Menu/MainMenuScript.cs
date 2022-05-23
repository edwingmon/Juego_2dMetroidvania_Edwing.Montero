using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public Animator settingsAnim;

    // Start is called before the first frame update
    void Start()
    {
        /*Scene scene = SceneManager.GetActiveScene();

        if(scene.name == "Main Menu")
        {
            AudioManager.instance.backgroundMusic.Stop();
            AudioManager.instance.PlayAudio(AudioManager.instance.mainMenu);
        }*/

        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame() 
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame() 
    {
        Application.Quit();
        print("Game Closed");
    }

    public void GoToMainMenu() 
    {
        SceneManager.LoadScene(0);
    }

    public void ShowSettings() 
    {
        settingsAnim.SetBool("ShowSettings", true);
    }

    public void HideSettings()
    {
        settingsAnim.SetBool("ShowSettings", false);
    }
}
