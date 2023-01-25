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
     [SerializeField] bool isEquip = false;
    
     Image cardImage;
     TMP_Text cardCostText;
     ShopManager shopManager;
     TMP_Text buttonText;
     private const float aplhaChangeSpeed = 3f;
     private const float targetAlpha = 0;
     
     private void Start() 
     {
          button = GetComponentInChildren<Button>();
          cardCostText = GetComponentInChildren<TMP_Text>();
          cardImage = GetComponentInChildren<Image>();
          cardCostText.text = spawnableScriptable.costInCurrency.ToString();
          cardImage = spawnableScriptable.objectImage;
          buttonText = button.GetComponentInChildren<TMP_Text>();
     }
   public void UnlockItem()
   {
     if(GameManager.instance.GetMoney() >= spawnableScriptable.costInCurrency)
     {
          var colorAlpha = cardCostText.color.a;
          colorAlpha = 0;
          //To Do fix that shit
          //RectTransform cardCostRect = cardCostText.GetComponent<RectTransform>();
          //LeanTween.textAlpha(cardCostRect,targetAlpha,aplhaChangeSpeed);
          isBuy = true;
          button.onClick.RemoveAllListeners();
          button.onClick.AddListener(() => EquipDeEquipItem());
          buttonText.text = "Equip";
          Destroy(cardCostText);
     }
     
   }
   public void EquipDeEquipItem()
   {
     isEquip = !isEquip;
     switch(isEquip){
          case true:
               buttonText.text = "De Equip";
          break;
          case false:
               buttonText.text = "Equip";
          break;
     }
   }
   public void GetAbilityData(SpawnableScriptableObject abilityObject)
   {
     spawnableScriptable = abilityObject;
   }
   public void AddShopManager(ShopManager _shopManager)
   {
     shopManager = _shopManager;
   }
}
