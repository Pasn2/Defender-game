using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameManager : MonoBehaviour
{
    [SerializeField] SelectCard[] selectCards;
    private void Awake() {
        for (int i = 0; i < MainMenuScripts.selectToGameObjects.Length; i++)
        {
            selectCards[i].abilityObject = MainMenuScripts.selectToGameObjects[i];
        }
    }
    
        
    

    void Update()
    {
        
    }
}
