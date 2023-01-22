using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
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
     void Start()
    {
        InvokeRepeating("SpawnTime",startTime,delayTime);
        
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
     void SpawnTime(){
        CreateNewObject(computerObject,computersSpawnArea);
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
    public void CheckAmountOfServers(){
        currentServers = GameObject.FindGameObjectsWithTag("Server");
        print(currentServers.Length);
        if(currentServers.Length == 1){
            print("Game Over!");
        }
    }
}
