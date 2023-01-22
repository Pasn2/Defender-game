using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
public class ShopCard : MonoBehaviour,IDragHandler,IEndDragHandler
{
    [SerializeField] SpawnableScriptableObject objectToBuy;
    [SerializeField] bool canEqiup;
    [SerializeField] RectTransform rectTransform;
    [SerializeField]Vector3 startpos;
    Image cardImage;
    TMP_Text cardCostText;
    private void Awake()
    {
        
        rectTransform = GetComponent<RectTransform>();
        startpos = rectTransform.position;
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
   

    public void OnEndDrag(PointerEventData eventData)
    {
        GameObject place = GameObject.FindGameObjectWithTag("Selected");
        SelectCard selectCard =place.GetComponent<SelectCard>();
        if(Vector2.Distance(transform.position,place.transform.position) < 50 && selectCard.isEmpty){
            if(selectCard != null)
            {
                selectCard.isEmpty = false;
            }
            transform.position = place.transform.position;
        }
        else{
            transform.position = startpos;
        }
    }
}
