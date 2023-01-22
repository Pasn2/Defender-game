using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int currentMoney;
    public PlayerInput playerInput;
    [SerializeField] TMP_Text displayMoney;
    [SerializeField] int startAmountOfServers;
    [SerializeField] GameObject serverObject;
    [SerializeField] GameObject computerObject;
    [SerializeField] BoxCollider2D computersSpawnArea;
    [SerializeField] BoxCollider2D serversSpawnArea;
    [SerializeField] float areaMultiPlayer;
    [SerializeField] float maxSpawnAreaSize;
    [SerializeField] float startTime;
    [SerializeField] float delayTime;
    GameObject[] currentServers;
    private void Awake() {
        if (instance != null && instance != this) 
        { 
            Destroy(this); 
        } 
        else{
            instance = this;
        }
    }
    void Start()
    {
        InvokeRepeating("SpawnTime",startTime,delayTime);
        playerInput = GetComponent<PlayerInput>();
        for (int i = 0; i < startAmountOfServers; i++)
        {
            CreateNewObject(serverObject,serversSpawnArea);
        } 
    }
    void ExpandZone(BoxCollider2D _zone){
        Vector2 expanse = new Vector2(areaMultiPlayer,areaMultiPlayer);
        _zone.size += expanse;
        switch(_zone.name){
            case "Computer Spawn Area":
                _zone.offset -= new Vector2(0,areaMultiPlayer);
            break;
            case "Server Spawn Area":
                _zone.offset += new Vector2(0,areaMultiPlayer);
            break;
        }
    }
    void CreateNewObject(GameObject _objectType,BoxCollider2D _area)
    {
        float randomXValue = Random.Range(_area.transform.position.x - _area.size.x / 2,_area.transform.position.x + _area.size.x / 2);
        float randomYValue = Random.Range(minInclusive: _area.transform.position.y - _area.size.y / 2,_area.transform.position.y + _area.size.y / 2);
        RaycastHit2D check = Physics2D.CircleCast(new Vector2(randomXValue,randomYValue), (float)0.5,Vector2.zero);
        Vector2 spawnVector2 = new Vector2(randomXValue,randomYValue);
        if(check.collider != null)
        {
            if(check.collider.name == "Web" || check.collider.name == _objectType.name) {
                CreateNewObject(_objectType,_area);
            }
        }
        Instantiate(_objectType,spawnVector2,Quaternion.identity);
        ExpandZone(_area);
    }
    void Update()
    {
       DisplayMoney();
    }
    void SpawnTime(){
        CreateNewObject(computerObject,computersSpawnArea);
    }
    void DisplayMoney(){
        displayMoney.text = currentMoney.ToString();
    }
    public void AddMoney(int _moneyAdded)
    {
        currentMoney += _moneyAdded;
        displayMoney.text = currentMoney.ToString();
    }
    public void RemoveMoney(int _removeMoney)
    {
        currentMoney += _removeMoney;
        if(currentMoney < 0){return;}
    }
    public void CheckAmountOfServers(){
        currentServers = GameObject.FindGameObjectsWithTag("Server");
        print(currentServers.Length);
        if(currentServers.Length == 1){
            print("Game Over!");
        }
    }
}
