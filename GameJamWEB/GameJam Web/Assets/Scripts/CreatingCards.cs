using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingCards : MonoBehaviour
{
    [SerializeField] SelectedObjectDataBaseScriptableObjects selectedObjectDataBase;
    [SerializeField] GameObject cardObject;
    [SerializeField] RectTransform cardContainer;
    private void Awake() {
        for (int i = 0; i < selectedObjectDataBase.AbilitydataBase.Count; i++)
        {
           GameObject card = Instantiate(cardObject,cardContainer.position,Quaternion.identity);
           ShopCard shopCard = card.GetComponent<ShopCard>();
           shopCard.GetAbilityData(selectedObjectDataBase.AbilitydataBase[i]);
           card.GetComponent<EquipingDeEquipingScript>().AddShopManager(this.gameObject.GetComponent<ShopManager>());
           card.transform.SetParent(cardContainer);
        }
    }
}
