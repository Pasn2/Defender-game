using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    bool isPaused;
    [SerializeField] GameObject pauseMenuObject;
    [SerializeField] GameObject optionsObject;

    public void PauseBtn(){
        isPaused = !isPaused;
        switch(isPaused){
            case true:
                pauseMenuObject.SetActive(true);
                Time.timeScale = 0;
            break;
            case false:
                pauseMenuObject.SetActive(false);
                Time.timeScale = 1;
            break;
        }
    }
    public void OptionsBtn(){
        optionsObject.SetActive(true);
        pauseMenuObject.SetActive(false);
    }
    public void ReturnBtn(){
        optionsObject.SetActive(false);
        pauseMenuObject.SetActive(true);
    }

    public void QuitBtn(){
        SceneManager.LoadScene(0);
    }
}
