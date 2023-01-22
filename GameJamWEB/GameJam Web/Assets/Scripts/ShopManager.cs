using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField] GameObject[] selectedCard;
    //sprawdzanie ilosci wybranych kart jeśli zostałby przekroczony limit jedna z kart odpada
    private void Update() {
       
        
    }
    public GameObject GetSelectedCard(){
        foreach (GameObject card in selectedCard)
        {
            if(!card.GetComponent<SelectCard>().isEmpty){
                break;
            }
            GameObject emptyCard = card;
            return emptyCard;
        }
        return null;
    }
    
}
