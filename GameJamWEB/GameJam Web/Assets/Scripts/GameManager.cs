using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] MoneySystem moneySystem;
    [SerializeField] CapacityMoneySystem capacityMoney;
    public PlayerInput playerInput;
    
    [SerializeField] GameObject gameOverMenu;
    private void Awake() {
        if (instance != null && instance != this) 
        { 
            Destroy(this); 
        } 
        else{
            instance = this;
        }
    }
     private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
    }
    private void LateUpdate() 
    {
        CheckGameOver();
    }
    public void AddCapacity(int _capacityAdd)
    {
        capacityMoney.AddCapacity(_capacityAdd);
    }
    public void RemoveCapacity(int _capacityRemove)
    {
        capacityMoney.RemoveCapacity(_capacityRemove);
    }
    public int GetCapacity(){
        
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
    public int GetMoney(){
        return moneySystem.CheckGold();
    }
    public int CheckAmountOfServers()
    {
        return GetAllServers().Length;
    }
    public GameObject[] GetAllServers()
    {
        GameObject[] servers = GameObject.FindGameObjectsWithTag("Server");
        return servers;
    }
    public void HealAllServers()
    {
        foreach (GameObject server in GetAllServers())
        {
            server.GetComponent<Server>().Health(200);
        }
    }
    public void CheckGameOver()
    {
        if(GetAllServers().Length <= 0)
        {
            gameOverMenu.SetActive(true);
            Time.timeScale =0;
        }
    }
}
