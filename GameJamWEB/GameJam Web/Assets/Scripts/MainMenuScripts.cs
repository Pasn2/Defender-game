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
    [SerializeField] ShopManager shopManager;
    public static SpawnableScriptableObject[] selectToGameObjects;
    private void Start() 
    {
        AdManager.instance.ShowBanner();
    }
    public void PlayBtn(){
        selectToGameObjects = shopManager.GetSelectedCards();
        print(selectToGameObjects.Length);
        print(selectToGameObjects[2].name);
        if(selectToGameObjects.Length <= 0 )
        {
            return;
        }
        SceneManager.LoadScene(1);
        
    }
    public void ShopBtn(){
        shopUi.SetActive(!shopUi.activeSelf);
        mainUi.SetActive(!mainUi.activeSelf);
    }
    public void HelpBtn(){
        helpUi.SetActive(!helpUi.activeSelf);
        mainUi.SetActive(!mainUi.activeSelf);
    }
    public void SettingsBtn(){
        settingsUi.SetActive(!settingsUi.activeSelf);
        mainUi.SetActive(!mainUi.activeSelf);
    }
    
    
}
