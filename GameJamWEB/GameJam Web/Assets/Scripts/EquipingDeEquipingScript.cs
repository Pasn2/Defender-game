using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EquipingDeEquipingScript : MonoBehaviour
{
    ShopManager shopManager;
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
        if(shopManager.CanBeSelected() || isEquip || !isEquip)
        {
            isEquip = !isEquip;
            switch(isEquip)
            {
                case true:
                    AddToSelect();
                    buttonText.text = "De Equip";
                break;
                case false:
                    RemoveFromSelect();
                    buttonText.text = "Equip";
                break;
            }
        }
        
    }
}
