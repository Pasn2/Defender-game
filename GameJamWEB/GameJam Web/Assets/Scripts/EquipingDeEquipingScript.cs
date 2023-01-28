using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EquipingDeEquipingScript : MonoBehaviour
{
    [SerializeField]ShopManager shopManager;
    [SerializeField] bool isEquip = false;
    [SerializeField] Button button;
    TMP_Text buttonText;
    private void Start() 
    {
        button = GetComponentInChildren<Button>();
        buttonText = button.GetComponentInChildren<TMP_Text>();
    }
    public void AddToSelect()
    {
        shopManager.AddSelected(gameObject);
    }
    public void AddShopManager(ShopManager _shopManager)
    {
        shopManager = _shopManager;
    }
    public void RemoveFromSelect()
    {
        shopManager.RemoveSelected(gameObject);
    }
    public void EquipDeEquipItem()
    {
        
        switch(isEquip)
        {
            case true:
                if(shopManager.CanBeSelected())
                {
                    AddToSelect();
                    buttonText.text = "De Equip";
                    isEquip = false;
                } 
                    
            break;
            case false:
                RemoveFromSelect();
                buttonText.text = "Equip";
                isEquip = true;
            break;
        }
        
    }
}
