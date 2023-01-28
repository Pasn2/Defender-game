using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
public class ShopCard : MonoBehaviour
{
     public SpawnableScriptableObject spawnableScriptable;
     [SerializeField] Button button;
     [SerializeField] bool isBuy = false;

    
     Image cardImage;
     TMP_Text cardCostText;

 
     private const float aplhaChangeSpeed = 3f;
     private const float targetAlpha = 0;
     
     private void Start() 
     {
          button = GetComponentInChildren<Button>();
          cardCostText = GetComponentInChildren<TMP_Text>();
          cardImage = GetComponentInChildren<Image>();
          cardCostText.text = spawnableScriptable.costInCurrency.ToString();
          cardImage = spawnableScriptable.objectImage;
          
     }
   public void UnlockItem()
   {
     //if(GameManager.instance.GetMoney() >= spawnableScriptable.costInCurrency)
     //{
        var colorAlpha = cardCostText.color.a;
        colorAlpha = 0;
        isBuy = true;
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(() => gameObject.GetComponent<EquipingDeEquipingScript>().EquipDeEquipItem());
        Destroy(cardCostText);
     //}
     
   }
  
  public void GetAbilityData(SpawnableScriptableObject abilityObject)
  {
    spawnableScriptable = abilityObject;
  }
   
}
