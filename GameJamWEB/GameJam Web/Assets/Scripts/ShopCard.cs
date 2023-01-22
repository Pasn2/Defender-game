using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
public class ShopCard : MonoBehaviour
{
    [SerializeField] bool isBuy = false;
    Image cardImage;
    TMP_Text cardCostText;
   public void UnlockItem(){
        isBuy = true;
   }
}
