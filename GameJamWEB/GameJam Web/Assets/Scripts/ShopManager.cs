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
    public void AddSelected(GameObject _card)
    {
        if(CanBeSelected())
        {
            _card.transform.SetParent(selectedCardContainer.transform);
        }
        else
        {
            
        }
    }
     public void RemoveSelected(GameObject _card)
    {
        _card.transform.SetParent(cardContainer.transform);
    }
}
