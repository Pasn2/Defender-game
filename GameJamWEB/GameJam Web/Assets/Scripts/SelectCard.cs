using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCard : MonoBehaviour
{
    [SerializeField] SelectingSystem selecting;
    public SpawnableScriptableObject abilityObject;
    public void SelectObject(){
        print("Selected!");
        selecting.SelectObject(abilityObject);
    }    
}
