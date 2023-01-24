using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MoneySystem : MonoBehaviour
{
    public int goldMoney;
    [SerializeField] TMP_Text displayGold;
    void Update()
    {
        DisplayMoney();
    }
    void DisplayMoney()
    {
        displayGold.text = goldMoney.ToString();
    }
    public int CheckGold()
    {
        
        return goldMoney;
    }
    public void AddGold(int _addGold)
    {
        goldMoney += _addGold;
        displayGold.text = goldMoney.ToString();
    }
    public void RemoveGold(int _removeGold)
    {
        goldMoney += _removeGold;
        if(goldMoney < 0){return;}
    }
}
