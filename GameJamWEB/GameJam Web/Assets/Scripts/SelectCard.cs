using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SelectCard : MonoBehaviour
{
    public SpawnableScriptableObject abilityObject;
    [SerializeField] SelectingSystem selecting;
    [SerializeField] Image icon;
    [SerializeField] TMP_Text costText;
    
    private void Start()
    {
       icon = this.gameObject.GetComponent<Image>();
       costText = this.gameObject.GetComponentInChildren<TMP_Text>();
       icon = abilityObject.objectImage;
       costText.SetText("Capacity: " + abilityObject.costInCapacity);
    }
    public void SelectObject()
    {
        selecting.SelectObject(abilityObject);
    }    
}
