using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    [SerializeField] SelectingSystem selecting;
    [SerializeField] bool IsDelay;
    public void SpawnObject(GameObject _objectToSpawn,Vector3 _localization,float _spawnDelay){
        print("Spawn Objewct in Build Manager");
        if(!IsDelay){
            print("is delay == false");
            AudioManager.instance.PlaySound("BuildObject");
            Instantiate(_objectToSpawn,_localization,Quaternion.identity);
            print(_objectToSpawn.name + "XXXXXXXXXXXXXXXXXXXX");
            IsDelay = true;
            StartCoroutine(Delay(_spawnDelay));
        }
    }
    
    IEnumerator Delay(float _delay){
        
        yield return new WaitForSeconds(_delay);
        IsDelay = false;
    }
}
