using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameManager : MonoBehaviour
{
    [SerializeField] GameObject soundManager;
    [SerializeField] SelectCard[] selectCards;
    private void Awake() 
    {
        Instantiate(soundManager,transform.position,Quaternion.identity);
        for (int i = 0; i < MainMenuScripts.selectToGameObjects.Length; i++)
        {
            selectCards[i].abilityObject = MainMenuScripts.selectToGameObjects[i];
        }
    }
}
