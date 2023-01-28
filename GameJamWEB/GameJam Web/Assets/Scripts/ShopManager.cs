using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{

    [SerializeField] GameObject selectedCardContainer;
    [SerializeField] GameObject cardContainer;

    public bool CanBeSelected()
    {
        if(selectedCardContainer.transform.childCount >= 3)
        {
            return false;
            
        }
        return true;
    }
    public SpawnableScriptableObject[] GetSelectedCards()
    {
        
        SpawnableScriptableObject[] selectedAbilities = new SpawnableScriptableObject[3];
        ShopCard[] shopCards = selectedCardContainer.GetComponentsInChildren<ShopCard>();
        for (int i = 0; i < shopCards.Length; i++)
        {
            selectedAbilities[i] = shopCards[i].spawnableScriptable;
        }
        if(selectedAbilities.Length == 3){
            return selectedAbilities;
        }
        return null;
    }
    public void AddSelected(GameObject _card)
    {
        _card.transform.SetParent(selectedCardContainer.transform);
    }
    public void RemoveSelected(GameObject _card)
    {
        _card.transform.SetParent(cardContainer.transform);
    }
}
