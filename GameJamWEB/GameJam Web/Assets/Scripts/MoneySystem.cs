using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MoneySystem : MonoBehaviour
{
    public int goldMoney;
    [SerializeField] TMP_Text displayGold;
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
        displayGold.text = goldMoney.ToString();
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
