using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CapacityMoneySystem : MonoBehaviour
{
    public int capacityMoney;
    [SerializeField] TMP_Text displayCapacity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayMoney();
    }
    void DisplayMoney(){
        displayCapacity.text = capacityMoney.ToString();
    }
    public void AddCapacity(int _capacityAdd)
    {
        capacityMoney += _capacityAdd;
        displayCapacity.text = capacityMoney.ToString();
    }
    public void RemoveCapacity(int _capacityRemove)
    {
        capacityMoney += _capacityRemove;
        if(capacityMoney < 0){return;}
    }
}
