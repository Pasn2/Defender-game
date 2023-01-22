using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [SerializeField] GameObject[] objectToSpawnList;
    [SerializeField] float delayBetweenSpawn;
    [SerializeField] bool canSpawn = true;
    
    float timer;
    void Update()
    {
        if(!canSpawn){
            timer -= Time.deltaTime;
            if(timer <= 0){
                canSpawn = true;
                timer  = delayBetweenSpawn;
                Spawn();
            }
        }
    }
    void Spawn(){
        canSpawn = false;
        GameObject virus = Instantiate(objectToSpawnList[Random.Range(0,objectToSpawnList.Length)],transform.position,Quaternion.identity);
        
    }
}
