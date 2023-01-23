using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class GameManager : MonoBehaviour
{
    //GameManager jak to manager jest odpowiedzialny za przekazywanie informacji
    public static GameManager instance;
    [SerializeField] MoneySystem moneySystem;
    [SerializeField] CapacityMoneySystem capacityMoney;
    public PlayerInput playerInput;
    
    
    private void Awake() {
        if (instance != null && instance != this) 
        { 
            Destroy(this); 
        } 
        else{
            instance = this;
        }
    }
     private void Start() {
        playerInput = GetComponent<PlayerInput>();
    }
 
    public void AddCapacity(int _capacityAdd)
    {
        capacityMoney.AddCapacity(_capacityAdd);
    }
    public void RemoveCapacity(int _capacityRemove)
    {
        capacityMoney.RemoveCapacity(_capacityRemove);
    }
    public int CheckCapacity(){
        
        return capacityMoney.CheckCapacity();
    }
    public void AddGold(int _goldAdd)
    {
        moneySystem.AddGold(_goldAdd);
    }
    public void RemoveGold(int _goldRemove)
    {
        moneySystem.RemoveGold(_goldRemove);
    }
    public int CheckMoney(){
        return moneySystem.CheckGold();
    }

  
    
}
