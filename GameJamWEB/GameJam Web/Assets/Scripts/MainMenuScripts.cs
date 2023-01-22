using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScripts : MonoBehaviour
{
    [SerializeField] GameObject mainUi;
    [SerializeField] GameObject shopUi;
    [SerializeField] GameObject helpUi;
    [SerializeField] GameObject settingsUi;
    public void PlayBtn(){
        SceneManager.LoadScene(1);
    }
    public void ShopBtn(){
        shopUi.SetActive(!shopUi.activeSelf);
        mainUi.SetActive(!mainUi.activeSelf);
    }
    public void HelpBtn(){
        helpUi.SetActive(!shopUi.activeSelf);
        mainUi.SetActive(!mainUi.activeSelf);
    }
    public void SettingsBtn(){
        settingsUi.SetActive(!settingsUi.activeSelf);
        mainUi.SetActive(!mainUi.activeSelf);
    }
    
}
