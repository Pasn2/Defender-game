using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServersSpawn : MonoBehaviour
{
    [SerializeField] SpawnableScriptableObject serverObject;
    [SerializeField] SelectingSystem selectingSystem;
    [SerializeField] float spawnFrecuency;
    float timer;
    void Start()
    {
        
    }
    private void FixedUpdate() 
    {
        timer += Time.fixedTime;
        if(timer >= spawnFrecuency)
        {
            selectingSystem.SelectObject(serverObject);
        }
    }
}
