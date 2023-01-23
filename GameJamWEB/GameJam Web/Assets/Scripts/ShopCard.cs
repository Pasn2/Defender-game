using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
public class ShopCard : MonoBehaviour
{
     [SerializeField] SpawnableScriptableObject spawnableScriptable;
     [SerializeField] Button button;
     [SerializeField] bool isBuy = false;
     [SerializeField]bool isEquip;
     Image cardImage;
     TMP_Text cardCostText;
     private void Awake() 
    {
          button = GetComponentInChildren<Button>();
          cardCostText = GetComponentInChildren<TMP_Text>();
          cardImage = GetComponentInChildren<Image>();
          cardCostText.text = spawnableScriptable.costInCurrency.ToString();
          cardImage = spawnableScriptable.objectImage;
    }
   public void UnlockItem()
   {
     if(GameManager.instance.CheckMoney() > spawnableScriptable.costInCurrency)
     {
          isBuy = true;
          button.GetComponentInChildren<TMP_Text>().text = "Equip";
          button.onClick.RemoveAllListeners();
          button.onClick.AddListener(() => EquipDeEquipItem());

     }
   }
   public void EquipDeEquipItem()
   {
     
   }
}
